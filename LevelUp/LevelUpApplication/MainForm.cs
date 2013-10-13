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
            SelectedDepartment = null;
            SelectedRule = 0;
        }

        private void LoadDepartments()
        {
            DepartamentRuleComboBox.Items.Clear();
            DepartamentRuleComboBox.Items.AddRange( AppController.GetDepartments() );
            if (SelectedDepartment != null)
            {
                DepartamentRuleComboBox.SelectedItem = SelectedDepartment;
            }
            else
            {
                DepartamentRuleComboBox.SelectedIndex = 0;
            }
        }

        private void LoadRules()
        {
            RulesDataGridView.Rows.Clear();
            string[][] Rules = AppController.GetRules( (string) DepartamentRuleComboBox.SelectedItem );

            foreach (string[] Rule in Rules)
            {
                RulesDataGridView.Rows.Add(Rule);
            }

            RulesDataGridView.Rows[SelectedRule].Selected = true;
        }

        private void LoadAchievements()
        {
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
            AgregarLogroForm Form = new AgregarLogroForm();
            Form.ShowDialog(this);
        }

        private void Achievements_Enter(object sender, EventArgs e)
        {
            LoadAchievements();
        }

        private void Rules_Enter(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadRules();
        }

        private void RulesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRule = e.RowIndex;
        }

        private void DepartamentRuleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedDepartment = DepartamentRuleComboBox.SelectedItem;
            LoadRules();
        }

        private void RulesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddRuleForm Form = new AddRuleForm();
            Form.ShowDialog(this);
        }

        private void AchievementsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Show Achievement
        }

    }
}
