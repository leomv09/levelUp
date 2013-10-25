namespace LevelUp.App
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.LoggedUserJob = new System.Windows.Forms.Label();
            this.LoggedUserDepartment = new System.Windows.Forms.Label();
            this.LoggedUserUsername = new System.Windows.Forms.Label();
            this.LoggedUser = new System.Windows.Forms.Label();
            this.LoggedUserJobLabel = new System.Windows.Forms.Label();
            this.LoggedUserDepartmentLabel = new System.Windows.Forms.Label();
            this.LoggedUsernameLabel = new System.Windows.Forms.Label();
            this.LoggedUserLabel = new System.Windows.Forms.Label();
            this.AcceptOptionsButton = new System.Windows.Forms.Button();
            this.ApplyOptionsButton = new System.Windows.Forms.Button();
            this.CancelOptionsButton = new System.Windows.Forms.Button();
            this.LanguagesLabel = new System.Windows.Forms.Label();
            this.LanguagesComboBox = new System.Windows.Forms.ComboBox();
            this.UserInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInfoPanel
            // 
            resources.ApplyResources(this.UserInfoPanel, "UserInfoPanel");
            this.UserInfoPanel.BackColor = System.Drawing.Color.LightGray;
            this.UserInfoPanel.Controls.Add(this.LoggedUserJob);
            this.UserInfoPanel.Controls.Add(this.LoggedUserDepartment);
            this.UserInfoPanel.Controls.Add(this.LoggedUserUsername);
            this.UserInfoPanel.Controls.Add(this.LoggedUser);
            this.UserInfoPanel.Controls.Add(this.LoggedUserJobLabel);
            this.UserInfoPanel.Controls.Add(this.LoggedUserDepartmentLabel);
            this.UserInfoPanel.Controls.Add(this.LoggedUsernameLabel);
            this.UserInfoPanel.Controls.Add(this.LoggedUserLabel);
            this.UserInfoPanel.Name = "UserInfoPanel";
            // 
            // LoggedUserJob
            // 
            resources.ApplyResources(this.LoggedUserJob, "LoggedUserJob");
            this.LoggedUserJob.Name = "LoggedUserJob";
            // 
            // LoggedUserDepartment
            // 
            resources.ApplyResources(this.LoggedUserDepartment, "LoggedUserDepartment");
            this.LoggedUserDepartment.Name = "LoggedUserDepartment";
            // 
            // LoggedUserUsername
            // 
            resources.ApplyResources(this.LoggedUserUsername, "LoggedUserUsername");
            this.LoggedUserUsername.Name = "LoggedUserUsername";
            // 
            // LoggedUser
            // 
            resources.ApplyResources(this.LoggedUser, "LoggedUser");
            this.LoggedUser.Name = "LoggedUser";
            // 
            // LoggedUserJobLabel
            // 
            resources.ApplyResources(this.LoggedUserJobLabel, "LoggedUserJobLabel");
            this.LoggedUserJobLabel.Name = "LoggedUserJobLabel";
            // 
            // LoggedUserDepartmentLabel
            // 
            resources.ApplyResources(this.LoggedUserDepartmentLabel, "LoggedUserDepartmentLabel");
            this.LoggedUserDepartmentLabel.Name = "LoggedUserDepartmentLabel";
            // 
            // LoggedUsernameLabel
            // 
            resources.ApplyResources(this.LoggedUsernameLabel, "LoggedUsernameLabel");
            this.LoggedUsernameLabel.Name = "LoggedUsernameLabel";
            // 
            // LoggedUserLabel
            // 
            resources.ApplyResources(this.LoggedUserLabel, "LoggedUserLabel");
            this.LoggedUserLabel.Name = "LoggedUserLabel";
            // 
            // AcceptOptionsButton
            // 
            resources.ApplyResources(this.AcceptOptionsButton, "AcceptOptionsButton");
            this.AcceptOptionsButton.Name = "AcceptOptionsButton";
            this.AcceptOptionsButton.UseVisualStyleBackColor = true;
            this.AcceptOptionsButton.Click += new System.EventHandler(this.AcceptOptionsButton_Click);
            // 
            // ApplyOptionsButton
            // 
            resources.ApplyResources(this.ApplyOptionsButton, "ApplyOptionsButton");
            this.ApplyOptionsButton.Name = "ApplyOptionsButton";
            this.ApplyOptionsButton.UseVisualStyleBackColor = true;
            this.ApplyOptionsButton.Click += new System.EventHandler(this.ApplyOptionsButton_Click);
            // 
            // CancelOptionsButton
            // 
            resources.ApplyResources(this.CancelOptionsButton, "CancelOptionsButton");
            this.CancelOptionsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelOptionsButton.Name = "CancelOptionsButton";
            this.CancelOptionsButton.UseVisualStyleBackColor = true;
            this.CancelOptionsButton.Click += new System.EventHandler(this.CancelOptionsButton_Click);
            // 
            // LanguagesLabel
            // 
            resources.ApplyResources(this.LanguagesLabel, "LanguagesLabel");
            this.LanguagesLabel.Name = "LanguagesLabel";
            // 
            // LanguagesComboBox
            // 
            resources.ApplyResources(this.LanguagesComboBox, "LanguagesComboBox");
            this.LanguagesComboBox.FormattingEnabled = true;
            this.LanguagesComboBox.Name = "LanguagesComboBox";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.AcceptOptionsButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelOptionsButton;
            this.Controls.Add(this.LanguagesComboBox);
            this.Controls.Add(this.LanguagesLabel);
            this.Controls.Add(this.CancelOptionsButton);
            this.Controls.Add(this.ApplyOptionsButton);
            this.Controls.Add(this.AcceptOptionsButton);
            this.Controls.Add(this.UserInfoPanel);
            this.Name = "OptionsForm";
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Label LoggedUserJobLabel;
        private System.Windows.Forms.Label LoggedUserDepartmentLabel;
        private System.Windows.Forms.Label LoggedUserLabel;
        private System.Windows.Forms.Label LoggedUserJob;
        private System.Windows.Forms.Label LoggedUserDepartment;
        private System.Windows.Forms.Label LoggedUserUsername;
        private System.Windows.Forms.Label LoggedUser;
        private System.Windows.Forms.Label LoggedUsernameLabel;
        private System.Windows.Forms.Button AcceptOptionsButton;
        private System.Windows.Forms.Button ApplyOptionsButton;
        private System.Windows.Forms.Button CancelOptionsButton;
        private System.Windows.Forms.Label LanguagesLabel;
        private System.Windows.Forms.ComboBox LanguagesComboBox;
    }
}