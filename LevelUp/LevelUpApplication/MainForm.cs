using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelUpApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AppController = new Controller();
            InitializeData();
        }

        private void InitializeData()
        {
            LoadDepartments();
            LoadUsers();
        }

        private void Reset()
        {
            DepartamentRuleComboBox.SelectedIndex = -1;
            LoadRules();
            UserAchievementsTextBox.Text = "";
            LoadAchievements();
        }

        private void Init()
        {
            DepartamentRuleComboBox.SelectedIndex = 0;
            LoadRules();
        }

        private void LoadDepartments()
        {
            DepartamentRuleComboBox.Items.Clear();
            DepartamentRuleComboBox.Items.AddRange( AppController.GetDepartments() );
        }

        private void LoadRules()
        {
            RulesDataGridView.Rows.Clear();
            string Department = (string)DepartamentRuleComboBox.SelectedItem;

            if (!String.IsNullOrEmpty(Department))
            {
                string[][] Rules = AppController.GetRules(Department);
                foreach (string[] Rule in Rules)
                {
                    RulesDataGridView.Rows.Add(Rule);
                }
            }
        }

        private void LoadAchievements()
        {
            AchievementsDataGridView.Rows.Clear();
            string User = UserAchievementsTextBox.Text;

            if (!String.IsNullOrEmpty(User))
            {
                string Department = ""; // User Department.
                string[][] Achievements = AppController.GetUserAchievements(User);

                AchievementsColumn.Items.AddRange(AppController.GetDepartmentAchievements(Department));
                foreach (string[] Achievement in Achievements)
                {
                    AchievementsDataGridView.Rows.Add(Achievement);
                }
            }
        }

        private void LoadUsers()
        {
            UserAchievementsTextBox.AutoCompleteCustomSource.Clear();
            UserAchievementsTextBox.AutoCompleteCustomSource.AddRange(AppController.GetUsers());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DepartamentRuleComboBox.Text))
            {
                MessageBox.Show(this, "Seleccione un departamento.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RuleDetailsForm Form = new RuleDetailsForm(this);
                Form.ShowDialog(this);
            }
        }

        private void RemoveRuleButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = RulesDataGridView.SelectedRows;
            if (SelectedRows.Count == 1)
            {
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar esta regla?", "Eliminar Regla",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.Yes)
                {
                    int SelectedIndex = RulesDataGridView.CurrentCell.RowIndex;
                    RulesDataGridView.Rows.RemoveAt( SelectedIndex );
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione una regla.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RulesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RuleDetailsForm Form = new RuleDetailsForm(this);
            Form.ShowDialog(this);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Reset();
            //LoginForm Form = new LoginForm();
            //Form.ShowDialog(this);
            Init();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Reset();
            //Quitar info de usuario;
            LoginForm Form = new LoginForm();
            Form.ShowDialog(this);
            Init();
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            LoadAchievements();
        }

        private void RemoveAchievementButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = AchievementsDataGridView.SelectedRows;
            if (SelectedRows.Count == 1)
            { 
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar este logro?", "Eliminar Logro",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    int SelectedIndex = AchievementsDataGridView.CurrentCell.RowIndex;
                    if (SelectedIndex < AchievementsDataGridView.Rows.Count - 1)
                    {
                        AchievementsDataGridView.Rows.RemoveAt(SelectedIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione una logro.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserAchievementsTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadAchievements();
            }
        }

        private void DepartamentRuleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRules();
        }

        public Controller GetController()
        {
            return this.AppController;
        }

        private void ViewRuleButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedRows = RulesDataGridView.SelectedRows;
            if (SelectedRows.Count == 1)
            {
                RuleDetailsForm Form = new RuleDetailsForm(this);
                Form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(this, "Seleccione una regla.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
