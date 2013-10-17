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
    public partial class AwardDetailsForm : Form
    {
        public AwardDetailsForm()
        {
            InitializeComponent();
            AppController = Controller.Instance;
            NameTextBox.MaxLength = 200;
            DescriptionTextBox.MaxLength = 700;
            OpenFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            FillTypes();
            FillCurrency();
            CurrencyComboBox.SelectedIndex = 0;
            ResizeNormal();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PhotoPictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                Save();
                this.Close();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                Save();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TypeComboBox_TextChanged(object sender, EventArgs e)
        {
            switch (TypeComboBox.Text)
            {
                case "Dinero":
                    ResizeMoney();
                    break;
                case "Puntos":
                    ResizePoint();
                    break;
                default:
                    ResizeNormal();
                    break;
            }
        }

        private bool Verify()
        {
            string message;

            if (!AwardHasValidName())
            {
                MessageBox.Show(this, "Ingrese un nombre válido de longitud menor que 200 caracteres.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!AwardHasValidDescription())
            {
                MessageBox.Show(this, "Ingrese una descripción válida de longitud menor que 700 caracteres.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!AwardHasValidType())
            {
                MessageBox.Show(this, "Ingrese un tipo de logro válido.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!AwardHasValidDetail(out message))
            {
                MessageBox.Show(this, message, "Error",
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

        private bool AwardHasValidName()
        {
            string Name = NameTextBox.Text;
            return !String.IsNullOrEmpty(Name);
        }

        private bool AwardHasValidDescription()
        {
            string Description = DescriptionTextBox.Text;
            return !String.IsNullOrEmpty(Description);
        }

        private bool AwardHasValidType()
        {
            object Type = TypeComboBox.SelectedItem;
            return Type != null;
        }

        private bool AwardHasValidDetail(out string message)
        {
            switch (TypeComboBox.Text)
            {
                case "Dinero":
                    return ValidateMoney(out message);
                case "Puntos":
                    message = "Ingrese un puntaje válido.";
                    return Functions.IsNumeric(DetailTextBox.Text) && Convert.ToInt32(DetailTextBox.Text) > 0;
                default:
                    message = "";
                    return true;
            }
        }

        private bool ValidateMoney(out string message)
        {
            if (!Functions.IsMoney(DetailTextBox.Text))
            {
                message = "Ingrese un monto válido de dinero.";
                return false;
            }
            else if (CurrencyComboBox.SelectedItem == null)
            {
                message = "Seleccione una moneda.";
                return false;
            }
            else
            {
                message = "";
                return true;
            }
        }

        private void ResizeMoney()
        {
            this.Size = new Size(458, 430);
            CurrencyVisible(true);
            DetailVisible(true);
            DetailLabel.Text = "Monto";
            ButtonsLocationY(345);
        }

        private void ResizePoint()
        {
            this.Size = new Size(458, 385);
            CurrencyVisible(false);
            DetailVisible(true);
            DetailLabel.Text = "Cantidad";
            ButtonsLocationY(301);
        }

        private void ResizeNormal()
        {
            this.Size = new Size(458, 379);
            CurrencyVisible(false);
            DetailVisible(false);
            ButtonsLocationY(301);
        }

        private void CurrencyVisible(bool state)
        {
            CurrencyLabel.Visible = state;
            CurrencyComboBox.Visible = state;
        }

        private void DetailVisible(bool state)
        {
            DetailLabel.Visible = state;
            DetailTextBox.Visible = state;
            DetailTextBox.Text = null;
        }

        private void ButtonsLocationY(int Y)
        {
            AwardAcceptButton.Location = new Point(AwardAcceptButton.Location.X, Y);
            AwardCancelButton.Location = new Point(AwardCancelButton.Location.X, Y);
            AwardApplyButton.Location = new Point(AwardApplyButton.Location.X, Y);
        }

        private void FillTypes()
        {
            TypeComboBox.Items.AddRange( AppController.GetAchievementsTypes() );
        }

        private void FillCurrency()
        {
            CurrencyComboBox.Items.AddRange( AppController.GetCurrencyNames() );
        }
    }
}
