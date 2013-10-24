using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelUpService;

namespace LevelUpApplication
{
    public partial class AwardDetailsForm : Form
    {
        private Controller m_controller;
        private Award m_award;
        private string m_photourl;

        public AwardDetailsForm(Award award)
        {
            InitializeComponent();
            m_controller = Controller.Instance;
            m_award = award;
            NameTextBox.MaxLength = Constants.AwardName_MaxLength;
            DescriptionTextBox.MaxLength = Constants.AwardDescription_MaxLength;
            OpenFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            FillTypes();
            FillCurrency();
            CurrencyComboBox.SelectedIndex = 0;
            ResizeNormal();
            LoadData();
        }

        private void LoadData()
        {
            this.AwardName = this.Award.Name;
            this.Description = this.Award.Description;
            this.Type = this.Award.Type;
            this.PhotoUrl = this.Award.PhotoUrl;

            if (this.Award.Type == Constants.AwardType_Points)
            {
                this.Detail = this.Award.Amount.ToString();
            }
            else if (this.Award.Type == Constants.AwardType_Money)
            {
                this.Detail = this.Award.Money.ToString();
                this.Currency = this.Award.Currency;
            }

            LoadPhoto();
        }

        private void LoadPhoto()
        {
            try
            {
                PhotoPictureBox.Image = Image.FromFile(this.PhotoUrl);
            }
            catch (Exception) { }
        }

        private void FillTypes()
        {
            TypeComboBox.Items.AddRange(m_controller.GetAwardsTypes());
        }

        private void FillCurrency()
        {
            CurrencyComboBox.Items.Clear();
            CurrencyComboBox.DataSource = m_controller.GetCurrency();
            CurrencyComboBox.DisplayMember = "Name";
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                //Save();
                this.Close();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                //Save();
            }
        }

        private void Save()
        {
            this.Award.Name = this.AwardName;
            this.Award.Description = this.Description;
            this.Award.Type = this.Type;
            this.Award.PhotoUrl = this.PhotoUrl;

            if (this.Type == Constants.AwardType_Points)
            {
                this.Award.Amount = Convert.ToInt32(this.Detail);
            }
            else if (this.Type == Constants.AwardType_Money)
            {
                this.Award.Currency = this.Currency;
                this.Award.Money = Convert.ToDouble(this.Detail);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.PhotoUrl = OpenFileDialog.FileName;
                LoadPhoto();
            }
        }

        private void TypeComboBox_TextChanged(object sender, EventArgs e)
        {
            switch (this.Type)
            {
                case Constants.AwardType_Money:
                    ResizeMoney();
                    break;
                case Constants.AwardType_Points:
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

        private bool AwardHasValidName()
        {
            return !String.IsNullOrEmpty(this.AwardName);
        }

        private bool AwardHasValidDescription()
        {
            return true;
            //return !String.IsNullOrEmpty(this.Description);
        }

        private bool AwardHasValidType()
        {
            return this.Type != null;
        }

        private bool AwardHasValidDetail(out string message)
        {
            switch (this.Type)
            {
                case Constants.AwardType_Money:
                    return ValidateMoney(out message);
                case Constants.AwardType_Points:
                    if (Functions.IsNumeric(this.Detail) && Convert.ToInt32(this.Detail) > 0)
                    {
                        message = String.Empty;
                        return true;
                    }
                    else
                    {
                        message = "Ingrese un puntaje válido.";
                        return false;
                    }
                default:
                    message = String.Empty;
                    return true;
            }
        }

        private bool ValidateMoney(out string message)
        {
            if (!Functions.IsMoney(this.Detail))
            {
                message = "Ingrese un monto válido de dinero.";
                return false;
            }
            else if (this.Currency == null)
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
            ChangeVerticalButtonsLocation(345);
        }

        private void ResizePoint()
        {
            this.Size = new Size(458, 385);
            CurrencyVisible(false);
            DetailVisible(true);
            ChangeVerticalButtonsLocation(301);
        }

        private void ResizeNormal()
        {
            this.Size = new Size(458, 379);
            CurrencyVisible(false);
            DetailVisible(false);
            ChangeVerticalButtonsLocation(301);
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

        private void ChangeVerticalButtonsLocation(int y)
        {
            AwardAcceptButton.Location = new Point(AwardAcceptButton.Location.X, y);
            AwardCancelButton.Location = new Point(AwardCancelButton.Location.X, y);
            AwardApplyButton.Location = new Point(AwardApplyButton.Location.X, y);
        }

        private Award Award
        {
            get { return m_award; }
            set { m_award = value; }
        }

        private string AwardName
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }

        private string Description
        {
            get { return DescriptionTextBox.Text; }
            set { DescriptionTextBox.Text = value; }
        }

        private string Type
        {
            get { return TypeComboBox.SelectedItem.ToString(); }
            set { TypeComboBox.SelectedItem = value; }
        }

        private Currency Currency
        {
            get { return (Currency) CurrencyComboBox.SelectedItem; }
            set { CurrencyComboBox.SelectedItem = value; }
        }

        private string Detail
        {
            get { return DetailTextBox.Text; }
            set { DetailTextBox.Text = value; }
        }

        private string PhotoUrl
        {
            get { return m_photourl; }
            set { m_photourl = value; }
        }
    }
}
