﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using LevelUp.Data;
using LevelUp.App.Properties;

namespace LevelUp.App
{
    public partial class OptionsForm : Form
    {
        #region Contructors

        public OptionsForm()
        {
            InitializeComponent();
            FillLanguages();
        }

        public OptionsForm(MainForm Parent) : this()
        {

            LoadLoggedUserData(Parent.LoggedUser);
        }

        #endregion
        #region Methods
        public void FillLanguages()
        {
            LanguagesComboBox.DataSource = new CultureInfo[] { new CultureInfo("es"), new CultureInfo("en"), new CultureInfo("fr") };
            LanguagesComboBox.DisplayMember = "DisplayName";
            this.SelectedLanguage = this.CurrentLanguage;
        }

        public void LoadLoggedUserData(User loggedUser)
        {
            LoggedUser.Text = loggedUser.Name + " " + loggedUser.LastName1 + " " + loggedUser.LastName2;
            LoggedUserUsername.Text = loggedUser.Username;
            LoggedUserDepartment.Text = loggedUser.Department.Name;
            LoggedUserJob.Text = loggedUser.Job.Name;
        }

        public void Save()
        {
            if (!SelectedLanguage.Equals(CurrentLanguage))
            {
                Settings.Default["language"] = SelectedLanguage.Name;
                Settings.Default.Save();
                MessageBox.Show(this, "You must reboot for the changes to take effect.", "Language Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        #region EventMethods

        private void AcceptOptionsButton_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void ApplyOptionsButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void CancelOptionsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #region Properties

        private CultureInfo SelectedLanguage
        {
            get { return (CultureInfo) LanguagesComboBox.SelectedItem; }
            set { LanguagesComboBox.SelectedItem = value; }
        }

        private CultureInfo CurrentLanguage
        {
            get { return Thread.CurrentThread.CurrentUICulture; }
        }

        #endregion
    }
}
