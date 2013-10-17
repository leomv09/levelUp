using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LevelUpApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginAcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Authenticate()
        {
            string PasswordHash = GetPasswordHash();
            string Username = GetUsername();

            return true;
        }

        private string GetPasswordHash()
        {
            SHA256 Hash = SHA256Managed.Create();
            Byte[] PasswordBytes = Encoding.UTF8.GetBytes(GetPassword());
            Byte[] PasswordHashBytes = Hash.ComputeHash(PasswordBytes);
            return BitConverter.ToString(PasswordHashBytes).Replace("-", "").ToLower();
        }

        private string GetPassword()
        {
            string Password = PasswordTextBox.Text;
            if (Password == null)
            {
                return String.Empty;
            }
            else
            {
                return Password;
            }
        }

        private string GetUsername()
        {
            string Username = UsernameTextBox.Text;
            if (Username == null)
            {
                return String.Empty;
            }
            else
            {
                return Username;
            }
        }

        /// <summary>
        /// Deshabilita el botón de salir.
        /// </summary>
        /// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ClassStyle = CP.ClassStyle | 0x200;
                return CP;
            }
        }

    }
}
