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
    public partial class RuleDetailsForm : Form
    {
        public RuleDetailsForm(Form Parent)
        {
            InitializeComponent();
            AppController = ((MainForm)Parent).GetController();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            //verify();
            this.Close();
        }

        private void ApplyRuleButton_Click(object sender, EventArgs e)
        {
            //verify();
        }

        private void CancelRuleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RuleDetailsForm_Shown(object sender, EventArgs e)
        {
            LoadAchievements();
            LoadAwards();
        }

        private void LoadAchievements()
        {
            string Department = ""; //Get Department
            AchievementName.Items.AddRange(AppController.GetDepartmentAchievements(Department));
        }

        private void LoadAwards()
        {
            string Department = ""; //Get Department
            AwardName.Items.AddRange(AppController.GetDepartmentAwards(Department));
        }

        private void AwardsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                AwardDetailsForm Form = new AwardDetailsForm();
                Form.ShowDialog(this);
            }
            else if (e.ColumnIndex == 2)
            {
                AwardsDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private bool verify()
        {
            DataGridViewRowCollection Rows = AchievementsDataGridView.Rows;
            for (int i = 0; i < Rows.Count; i++ )
            {
                string achievement = Rows[i].Cells[0].Value.ToString();

                bool IsDuplicated = AchievementsDataGridView.Rows.Cast<DataGridViewRow>().Count(
                    c => c.Cells[0].Value.ToString() == achievement) > 1;

                if (IsDuplicated)
                {
                    MessageBox.Show(this, "La regla no puede contenir logros duplicados.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

    }
}
