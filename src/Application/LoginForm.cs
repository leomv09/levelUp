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
using LevelUp.Data;
using LevelUp.Logic;

namespace LevelUp.App
{
    public partial class LoginForm : Form
    {
        private Controller m_controller;
        private User m_user;

        public LoginForm()
        {
            InitializeComponent();
            m_controller = Controller.Instance;
            UsernameTextBox.Text = "admin";
            PasswordTextBox.Text = "admin";
        }

        private void LoginAcceptButton_Click(object sender, EventArgs e)
        {
            if (Authenticate())
            {
                this.Close();
            }
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Authenticate()
        {
            string passwordHash = GetPasswordHash();
            string username = GetUsername();

            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show(this, "Ingrese su nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            Authentication auth = m_controller.GetUserAuthentication(username, passwordHash);

            if (auth.State == true)
            {
                Permission[] permissions = m_controller.GetUserPermissions(auth.User);
                if ( permissions.Contains(new Permission(){Code="login_pc_admin"}) )
                {
                    m_user = auth.User;
                    m_controller.GetUserDepartment(ref m_user);
                    m_controller.GetUserJob(ref m_user);
                    return true;
                }
                else
                {
                    MessageBox.Show(this, "Su usuario su no posee permiso para iniciar sesión", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(this, "Credenciales inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private string GetPasswordHash()
        {
            SHA1 hash = SHA1Managed.Create();
            Byte[] passwordBytes = Encoding.UTF8.GetBytes(GetPassword());
            Byte[] passwordHashBytes = hash.ComputeHash(passwordBytes);
            return BitConverter.ToString(passwordHashBytes).Replace("-", "").ToLower();
        }

        private string GetPassword()
        {
            string password = PasswordTextBox.Text;
            if (password == null)
            {
                return String.Empty;
            }
            else
            {
                return password;
            }
        }

        private string GetUsername()
        {
            string username = UsernameTextBox.Text;
            if (username == null)
            {
                return String.Empty;
            }
            else
            {
                return username;
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

        public User User
        {
            get { return m_user; }
        }

    }
}
