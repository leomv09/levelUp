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
            LoadDepartments();
            LoadUsers();
            UserAchievementsTextBox.Text = "jason923";
            SelectedRule = 0;
            SelectedAchievement = 0;
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
            string[][] Rules = AppController.GetRules(Department);

            foreach (string[] Rule in Rules)
            {
                RulesDataGridView.Rows.Add(Rule);
            }

            RulesDataGridView.Rows[SelectedRule].Selected = true;
        }

        private void LoadAchievements()
        {
            AchievementsDataGridView.Rows.Clear();
            string User = UserAchievementsTextBox.Text;
            string[][] Achievements = AppController.GetAchievements(User);

            foreach (string[] Achievement in Achievements)
            {
                AchievementsDataGridView.Rows.Add(Achievement);
            }

            AchievementsDataGridView.Rows[SelectedAchievement].Selected = true;
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
            AddRuleForm Form = new AddRuleForm();
            Form.ShowDialog(this);
        }

        private void RemoveRuleButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection Rows = RulesDataGridView.SelectedRows;
            if (Rows.Count == 1)
            {
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar esta regla?", "Eliminar Regla",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.Yes)
                {
                    RulesDataGridView.Rows.RemoveAt( SelectedRule );
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione una regla.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAchievementButton_Click(object sender, EventArgs e)
        {
            AddAchievementForm Form = new AddAchievementForm();
            Form.ShowDialog(this);
        }

        private void Achievements_Enter(object sender, EventArgs e)
        {
            LoadAchievements();
        }

        private void Rules_Enter(object sender, EventArgs e)
        {
            LoadRules();
        }

        private void DepartamentRuleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadRules();
        }

        private void RulesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRule = e.RowIndex;
        }

        private void RulesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddRuleForm Form = new AddRuleForm();
            Form.ShowDialog(this);
        }

        private void AchievementsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedAchievement = e.RowIndex;
        }

        private void AchievementsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddAchievementForm Form = new AddAchievementForm();
            Form.ShowDialog(this);
        }

    }
}
