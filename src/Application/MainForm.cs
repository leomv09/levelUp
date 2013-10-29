using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using LevelUp.Data;
using LevelUp.Logic;
using LevelUp.App.Properties;

namespace LevelUp.App
{
    public partial class MainForm : Form
    {
        private Controller m_controller;
        private User m_loggedUser;
        private User m_selectedUser;

        public MainForm()
        {
            LoadConfiguration();
            InitializeComponent();
            m_controller = Controller.Instance;
            LoadUsers();
        }

        private void LoadConfiguration()
        {
            string language = Settings.Default["language"].ToString();
            if (String.IsNullOrEmpty(language))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                Settings.Default["language"] = "en";
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            }
        }

        private void Reset()
        {
            ClearDepartments();
            ClearRules();
            ClearSelectedUser();
            ClearAchievements();
            ClearLoggedUser();
        }

        private void Init()
        {
            LoadDepartments();
            DepartamentRuleComboBox.SelectedIndex = 0;
            LoadRules();
        }

        private void LoadDepartments()
        {
            ClearDepartments();
            DepartamentRuleComboBox.DataSource = m_controller.GetDepartments();
            DepartamentRuleComboBox.DisplayMember = "Name";
        }

        private void LoadRules()
        {
            ClearRules();

            if (this.SelectedDepartment != null)
            {
                Rule[] rules = m_controller.GetDepartmentRules(this.SelectedDepartment); 
                BindingList<Rule> ruleList = new BindingList<Rule>();

                ruleList.AllowEdit = true;
                ruleList.AllowNew = true;
                ruleList.AllowRemove = true;

                foreach (Rule rule in rules)
                {
                    ruleList.Add(rule);
                }

                RulesDataGridView.AutoGenerateColumns = false;
                RulesDataGridView.DataSource = ruleList;
            }
        }

        private void LoadAchievements()
        {
            ClearAchievements();

            if (this.SelectedUser != null)
            {
                Department userDepartment = new Department();

                AchievementPerUser[] achievements = m_controller.GetUserAchievements(this.SelectedUser);
                BindingList<AchievementPerUser> achievementList = new BindingList<AchievementPerUser>();
                achievementList.AllowEdit = true;
                achievementList.AllowNew = true;
                achievementList.AllowRemove = true;

                foreach (AchievementPerUser achievement in achievements)
                {
                    achievementList.Add(achievement);
                }

                AchievementsDataGridView.AutoGenerateColumns = false;
                AchievementsDataGridView.DataSource = achievementList;
            }
        }

        private void LoadUsers()
        {
            UserAchievementsTextBox.AutoCompleteCustomSource.Clear();
            UserAchievementsTextBox.AutoCompleteCustomSource.AddRange(m_controller.GetUsers());
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedDepartment == null)
            {
                MessageBox.Show(this, "Seleccione un departamento.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RuleDetailsForm form = new RuleDetailsForm(new Rule(), this.SelectedDepartment);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Rule ruleAdded = form.Rule;
                    ruleAdded.CreationDate = DateTime.Today;
                    ruleAdded.Creator = m_loggedUser;
                    try
                    {
                        ruleAdded = m_controller.AddRuleToDepartment(ruleAdded, this.SelectedDepartment);
                        ((BindingList<Rule>)RulesDataGridView.DataSource).Add(ruleAdded);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error al enviar la solicitud: " + ex.Message, "Error",
                        MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void RulesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RuleDetailsForm form = new RuleDetailsForm(this.SelectedRule, this.SelectedDepartment);
            form.ShowDialog(this);
        }

        private void ViewRuleButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedRule != null)
            {
                RuleDetailsForm form = new RuleDetailsForm(this.SelectedRule, this.SelectedDepartment);
                form.ShowDialog(this);
                LoadRules();
            }
            else
            {
                MessageBox.Show(this, "Seleccione una regla.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveRuleButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedRule != null)
            {
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar esta regla?", "Eliminar Regla",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.Yes)
                {
                    BindingList<Rule> ruleList = (BindingList<Rule>)RulesDataGridView.DataSource;
                    try
                    {
                        m_controller.RemoveRuleFromDepartment(this.SelectedRule, this.SelectedDepartment);
                        ruleList.Remove(this.SelectedRule);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error al enviar la solicitud: " + ex.Message, "Error",
                        MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione una regla.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Reset();
            LoginForm form = new LoginForm();
            form.ShowDialog(this);
            m_loggedUser = form.User;
            Init();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Reset();
            LoginForm form = new LoginForm();
            form.ShowDialog(this);
            m_loggedUser = form.User;
            Init();
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            if (SearchUser())
            {
                LoadAchievements();
            }
        }

        private void UserAchievementsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SearchUser())
                {
                    LoadAchievements();
                }
            }
        }

        private bool SearchUser()
        {
            string username = UserAchievementsTextBox.Text;
            m_selectedUser = null;
            this.SelectedUserName.Text = null;
            this.SelectedUserUsername.Text = null;
            this.SelectedUserDepartment.Text = null;
            this.SelectedUserJob.Text = null;
            ClearAchievements();

            if (!String.IsNullOrEmpty(username))
            {
                User fetchedUser = m_controller.GetUser(username);
                m_controller.GetUserDepartment(ref fetchedUser);
                m_controller.GetUserJob(ref fetchedUser);

                if (User.IsValid(fetchedUser))
                {
                    m_selectedUser = fetchedUser;
                    this.SelectedUserName.Text = fetchedUser.Name + " " + fetchedUser.LastName1 + " " + fetchedUser.LastName2;
                    this.SelectedUserUsername.Text = fetchedUser.Username;
                    this.SelectedUserDepartment.Text = fetchedUser.Department.Name;
                    this.SelectedUserJob.Text = fetchedUser.Job.Name;
                    return true;
                }
                else
                {
                    MessageBox.Show(this, "Usuario no encontrado.");
                    return false;
                }
            }

            return false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DepartamentRuleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRules();
        }

        private void AddAchievementButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedUser != null)
            {
                Department userDepartment = new Department();
                AddAchievementPerUserForm form = new AddAchievementPerUserForm(userDepartment);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (CountUserAchievements(form.SelectedAchievement.Achievement) < form.SelectedAchievement.Achievement.MaxAmount)
                    {
                        BindingList<AchievementPerUser> achievementList =
                        (BindingList<AchievementPerUser>)AchievementsDataGridView.DataSource;

                        AchievementPerUser newAchievement = form.SelectedAchievement;
                        newAchievement.Creator = this.m_loggedUser;
                        newAchievement.ObtainingDate = DateTime.Today;
                        try
                        {
                            m_controller.AddAchievementToUser(this.SelectedUser, newAchievement);
                            achievementList.Add(newAchievement);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Error al enviar la solicitud: " + ex.Message, "Error",
                            MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "El usuario ya no puede tener más logros de este tipo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione un usuario.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CountUserAchievements(Achievement achievement)
        {
            int count = 0;
            foreach (AchievementPerUser ach in this.Achievements)
            {
                if (ach.Achievement.ID == achievement.ID)
                {
                    count += 1;
                }
            }
            return count;
        }

        private void RemoveAchievementButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedUser != null)
            {
                if (this.SelectedAchievements.Length > 0)
                {
                    if (MessageBox.Show(this, "¿Está seguro que desea eliminar estos logros?", "Eliminar Logros",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                    {
                        BindingList<AchievementPerUser> achievementList =
                            (BindingList<AchievementPerUser>)AchievementsDataGridView.DataSource;

                        try
                        {
                            foreach (AchievementPerUser achievement in this.SelectedAchievements)
                            {
                                m_controller.RemoveAchievementFromUser(this.SelectedUser, achievement);
                                achievementList.Remove(achievement);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Error al enviar la solicitud: " + ex.Message, "Error",
                            MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Seleccione un logro.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione un usuario.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm(this);
            form.ShowDialog(this);
        }

        private void ClearDepartments()
        {
            DepartamentRuleComboBox.DataSource = null;
            DepartamentRuleComboBox.Items.Clear();
        }

        private void ClearRules()
        {
            RulesDataGridView.DataSource = null;
            RulesDataGridView.Rows.Clear();
        }

        private void ClearAchievements()
        {
            AchievementsDataGridView.DataSource = null;
            AchievementsDataGridView.Rows.Clear();
        }

        private void ClearSelectedUser()
        {
            m_selectedUser = null;
            UserAchievementsTextBox.Text = null;
            SelectedUserName.Text = null;
            SelectedUserUsername.Text = null;
            SelectedUserDepartment.Text = null;
            SelectedUserJob.Text = null;
        }

        private void ClearLoggedUser()
        {
            m_loggedUser = null;
        }

        private Rule[] Rules
        {
            get
            {
                return ((BindingList<Rule>)RulesDataGridView.DataSource)
                    .ToArray<Rule>();
            }
            set
            {
                BindingList<Rule> ruleList =
                    (BindingList<Rule>)RulesDataGridView.DataSource;
                ruleList.Clear();
                foreach (Rule rule in value)
                {
                    ruleList.Add(rule);
                }
            }
        }

        private AchievementPerUser[] Achievements
        {
            get
            {
                return ((BindingList<AchievementPerUser>)AchievementsDataGridView.DataSource)
                    .ToArray<AchievementPerUser>();
            }
            set
            {
                BindingList<AchievementPerUser> achievementList =
                    (BindingList<AchievementPerUser>)AchievementsDataGridView.DataSource;
                achievementList.Clear();
                foreach (AchievementPerUser achievement in value)
                {
                    achievementList.Add(achievement);
                }
            }
        }

        private Department SelectedDepartment
        {
            get { return (Department) DepartamentRuleComboBox.SelectedItem; }
        }

        private Rule SelectedRule
        {
            get
            { 
                try
                { 
                    return (Rule)RulesDataGridView.SelectedRows[0].DataBoundItem;
                } 
                catch (Exception) 
                { 
                    return null; 
                } 
            }
        }

        private AchievementPerUser[] SelectedAchievements
        {
            get
            {
                List<AchievementPerUser> list = new List<AchievementPerUser>();
                object rowState;
                foreach (DataGridViewRow row in AchievementsDataGridView.Rows)
                {
                    rowState = row.Cells[EnabledCheckBox.Name].FormattedValue;
                    if (rowState != null && Convert.ToBoolean(rowState))
                    {
                        list.Add((AchievementPerUser)row.DataBoundItem);
                    }
                }
                return list.ToArray();
            }
        }

        public User SelectedUser
        {
            get { return m_selectedUser; }
        }

        public User LoggedUser
        {
            get { return m_loggedUser; }
        }

        private void AchievementsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

    }
}
