using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelUpService;

namespace LevelUpApplication
{
    public partial class RuleDetailsForm : Form
    {
        private Controller m_controller;
        Rule m_rule;
        Department m_department;

        public RuleDetailsForm(Rule rule, Department department)
        {
            InitializeComponent();
            m_controller = Controller.Instance;
            m_rule = rule;
            m_department = department;
            RuleNameTextBox.MaxLength = Constants.RuleName_MaxLength;
            RuleDescripcionTextBox.MaxLength = Constants.RuleDescription_MaxLength;
            LoadData();
        }

        private void LoadData()
        {
            this.RuleName = Rule.Name;
            this.Description = Rule.Description;
            this.StartDate = Rule.StartDate;
            this.EndDate = Rule.EndDate;
            LoadAchievements();
            LoadAwards();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                Save();
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ApplyRuleButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                Save();
            }
        }

        private void Save()
        {
            this.Rule.Name = this.RuleName;
            this.Rule.Description = this.Description;
            this.Rule.StartDate = this.StartDate;
            this.Rule.EndDate = this.EndDate;
            this.Rule.Achievements = this.Achievements;
            this.Rule.Awards = this.Awards;
            //m_controller.ModifyRule(this.Rule);
        }

        private void CancelRuleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAchievements()
        {
            BindingList<AchievementPerRule> achievementList = new BindingList<AchievementPerRule>();
            achievementList.AllowEdit = true;
            achievementList.AllowNew = true;
            achievementList.AllowRemove = true;

            foreach (AchievementPerRule achievement in Rule.Achievements)
            {
                achievementList.Add(achievement);
            }

            AchievementsDataGridView.AutoGenerateColumns = false;
            AchievementsDataGridView.DataSource = achievementList;
        }

        private void LoadAwards()
        {
            BindingList<Award> awardList = new BindingList<Award>();
            awardList.AllowEdit = true;
            awardList.AllowNew = true;
            awardList.AllowRemove = true;

            foreach (Award award in Rule.Awards)
            {
                awardList.Add(award);
            }

            AwardsDataGridView.AutoGenerateColumns = false;
            AwardsDataGridView.DataSource = awardList;
        }

        private void AwardsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int) Constants.Rule_AwardColumns.View)
            {
                Award selectedAward = this.Awards[e.RowIndex];
                AwardDetailsForm form = new AwardDetailsForm(selectedAward);
                form.ShowDialog(this);
            }
            else if (e.ColumnIndex == (int) Constants.Rule_AwardColumns.Delete)
            {
                Award selectedAward = this.Awards[e.RowIndex];
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar este premio?", "Eliminar Premio",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AwardsDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void AchievementsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int) Constants.Rule_AchievementColumns.Delete)
            {
                AchievementPerRule selectedAchievement = this.Achievements[e.RowIndex];
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar este logro?", "Eliminar Logro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AchievementsDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void AddAchievementButton_Click(object sender, EventArgs e)
        {
            AddAchievementForm form = new AddAchievementForm(this.Department);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                BindingList<AchievementPerRule> achievementsList =
                    (BindingList<AchievementPerRule>)AchievementsDataGridView.DataSource;

                achievementsList.Add(
                    new AchievementPerRule()
                    {
                        Achievement = form.SelectedAchievement,
                        Amount = 1
                    });
            }
        }

        private void AddAwardButton_Click(object sender, EventArgs e)
        {
            AddAwardForm form = new AddAwardForm(this.Department);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                BindingList<Award> awardsList =
                    (BindingList<Award>)AwardsDataGridView.DataSource;

                awardsList.Add(form.Award);
            }
        }

        private bool Verify()
        {
            if (!RuleHasValidName())
            {
                MessageBox.Show(this, "Ingrese un nombre válido de longitud menor que 100 caracteres.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!RuleHasValidDates())
            {
                MessageBox.Show(this, "Las fechas son inconsistentes.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!RuleHasAchievements())
            {
                MessageBox.Show(this, "Debe seleccionar al menos un logro.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!RuleHasAwards())
            {
                MessageBox.Show(this, "Debe seleccionar al menos un premio.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!AllAchievementsHaveValidAmount())
            {
                MessageBox.Show(this, "Ingrese cantidades válidas para los logros.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Functions.DataGridViewHasDuplicatedValues(AchievementsDataGridView, (int) Constants.Rule_AchievementColumns.Name))
            {
                MessageBox.Show(this, "La regla no puede contener logros duplicados.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Functions.DataGridViewHasDuplicatedValues(AwardsDataGridView, (int) Constants.Rule_AwardColumns.Name))
            {
                MessageBox.Show(this, "La regla no puede contener premios duplicados.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool RuleHasValidName()
        {
            return !String.IsNullOrEmpty(this.RuleName);
        }

        private bool RuleHasValidDates()
        {
            DateTime startDate = StartDateTimePicker.Value;
            DateTime endDate = EndDateTimePicker.Value;
            int result = startDate.CompareTo(endDate);
            return result <= 0;
        }

        private bool RuleHasAchievements()
        {
            return Achievements.Length > 0;
        }

        private bool RuleHasAwards()
        {
            return Awards.Length > 0;
        }

        private bool AllAchievementsHaveValidAmount()
        {
            foreach (AchievementPerRule achievement in this.Achievements)
            {
                if (achievement.Amount <= 0)
                {
                    return false;
                }
            }
            return true;
        }

        public Rule Rule
        {
            get { return m_rule; }
            set { m_rule = value; }
        }

        private Department Department
        {
            get { return m_department; }
            set { m_department = value; }
        }

        private Award[] Awards
        {
            get
            {
                return ((BindingList<Award>)AwardsDataGridView.DataSource).ToArray<Award>();
            }
            set
            {
                BindingList<Award> awardsList =
                    (BindingList<Award>) AwardsDataGridView.DataSource;
                awardsList.Clear();
                foreach (Award award in value)
                {
                    awardsList.Add(award);
                }
            }
        }

        private AchievementPerRule[] Achievements
        {
            get 
            { 
                return ((BindingList<AchievementPerRule>)AchievementsDataGridView.DataSource)
                    .ToArray<AchievementPerRule>(); 
            }
            set 
            {
                BindingList<AchievementPerRule> achievementsList =
                    (BindingList<AchievementPerRule>) AchievementsDataGridView.DataSource;
                achievementsList.Clear();
                foreach (AchievementPerRule achievement in value)
                {
                    achievementsList.Add(achievement);
                }
            }
        }

        private string RuleName
        {
            get { return RuleNameTextBox.Text; }
            set { RuleNameTextBox.Text = value; }
        }

        private string Description
        {
            get { return RuleDescripcionTextBox.Text; }
            set { RuleDescripcionTextBox.Text = value; }
        }

        private string StartDate
        {
            get { return StartDateTimePicker.Value.ToString("yyyy-MM-dd"); }
            set { try { StartDateTimePicker.Value = DateTime.Parse(value); } catch(Exception){} }
        }

        private string EndDate
        {
            get { return EndDateTimePicker.Value.ToString("yyyy-MM-dd"); }
            set { try { EndDateTimePicker.Value = DateTime.Parse(value); } catch(Exception){} }
        }

        private void AchievementsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

    }
}
