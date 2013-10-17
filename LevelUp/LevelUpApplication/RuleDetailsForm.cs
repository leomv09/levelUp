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
        public RuleDetailsForm()
        {
            InitializeComponent();
            AppController = Controller.Instance;
            StartDateTimePicker.MinDate = DateTime.Today;
            EndDateTimePicker.MinDate = DateTime.Today;
            RuleNameTextBox.MaxLength = 100;
            RuleDescripcionTextBox.MaxLength = 500;
            LoadAchievements();
            LoadAwards();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                Save();
                this.Close();
            }
        }

        private void ApplyRuleButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                Save();
            }
        }

        private void CancelRuleButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar este premio?", "Eliminar Premio",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AwardsDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void AchievementsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show(this, "¿Está seguro que desea eliminar este logro?", "Eliminar Logro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AchievementsDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void AchievementsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int amountCellIndex = 1;
            for (int i = 0; i < e.RowCount; i++)
            {
                AchievementsDataGridView.Rows[e.RowIndex + i - 1].Cells[amountCellIndex].Value = 1;
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
            else if (!AllAchievementsHaveValidName())
            {
                MessageBox.Show(this, "Seleccione un logro de la lista desplegable.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!AllAchievementsHaveValidAmount())
            {
                MessageBox.Show(this, "Ingrese cantidades válidas para los logros.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Functions.DataGridViewHasDuplicatedValues(AchievementsDataGridView))
            {
                MessageBox.Show(this, "La regla no puede contenir logros duplicados.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Functions.DataGridViewHasDuplicatedValues(AwardsDataGridView))
            {
                MessageBox.Show(this, "La regla no puede contenir premios duplicados.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Save()
        {
        }

        private bool RuleHasValidName()
        {
            string Name = RuleNameTextBox.Text;
            return !String.IsNullOrEmpty(Name);
        }

        private bool RuleHasValidDates()
        {
            DateTime StartDate = StartDateTimePicker.Value;
            DateTime EndDate = EndDateTimePicker.Value;
            int result = StartDate.CompareTo(EndDate);
            return result <= 0;
        }

        private bool AllAchievementsHaveValidName()
        {
            int Name = 0;

            int AchievementsWithInvalidName = AchievementsDataGridView.Rows.Cast<DataGridViewRow>()
                .Count(R => !Functions.IsNullRow(R) && R.Cells[Name].Value == null);

            return AchievementsWithInvalidName == 0;
        }

        private bool AllAchievementsHaveValidAmount()
        {
            int Amount = 1;

            int AchievementsWithInvalidAmount = AchievementsDataGridView.Rows.Cast<DataGridViewRow>()
                .Count(R =>
                    !Functions.IsNullRow(R) &&
                    (
                        R.Cells[Amount].Value == null ||
                        !Functions.IsNumeric(R.Cells[Amount].Value.ToString())
                    )
                );

            return AchievementsWithInvalidAmount == 0;
        }

    }
}
