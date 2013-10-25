namespace LevelUp.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DepartamentRuleLabel = new System.Windows.Forms.Label();
            this.DepartamentRuleComboBox = new System.Windows.Forms.ComboBox();
            this.RulesDataGridView = new System.Windows.Forms.DataGridView();
            this.RulesColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RulesColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RulesColumnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RulesColumnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TapControl = new System.Windows.Forms.TabControl();
            this.RulesTap = new System.Windows.Forms.TabPage();
            this.ViewRuleButton = new System.Windows.Forms.Button();
            this.RemoveRuleButton = new System.Windows.Forms.Button();
            this.AddRuleButton = new System.Windows.Forms.Button();
            this.AchievementsTap = new System.Windows.Forms.TabPage();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.SelectedUserJob = new System.Windows.Forms.Label();
            this.SelectedUserDepartment = new System.Windows.Forms.Label();
            this.SelectedUserUsername = new System.Windows.Forms.Label();
            this.SelectedUserName = new System.Windows.Forms.Label();
            this.SelectedUserJobLabel = new System.Windows.Forms.Label();
            this.SelectedUserDepartmentLabel = new System.Windows.Forms.Label();
            this.SelectedUsernameLabel = new System.Windows.Forms.Label();
            this.SelectedUserLabel = new System.Windows.Forms.Label();
            this.AddAchievementButton = new System.Windows.Forms.Button();
            this.RemoveAchievementButton = new System.Windows.Forms.Button();
            this.SearchUserButton = new System.Windows.Forms.Button();
            this.AchievementsDataGridView = new System.Windows.Forms.DataGridView();
            this.EnabledCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AchievementsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AchievementsColumnDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAchievementsTextBox = new System.Windows.Forms.TextBox();
            this.UserAchievementsLabel = new System.Windows.Forms.Label();
            this.FileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).BeginInit();
            this.TapControl.SuspendLayout();
            this.RulesTap.SuspendLayout();
            this.AchievementsTap.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsDataGridView)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartamentRuleLabel
            // 
            resources.ApplyResources(this.DepartamentRuleLabel, "DepartamentRuleLabel");
            this.DepartamentRuleLabel.Name = "DepartamentRuleLabel";
            // 
            // DepartamentRuleComboBox
            // 
            resources.ApplyResources(this.DepartamentRuleComboBox, "DepartamentRuleComboBox");
            this.DepartamentRuleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartamentRuleComboBox.FormattingEnabled = true;
            this.DepartamentRuleComboBox.Name = "DepartamentRuleComboBox";
            this.DepartamentRuleComboBox.Sorted = true;
            this.DepartamentRuleComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartamentRuleComboBox_SelectedIndexChanged);
            // 
            // RulesDataGridView
            // 
            resources.ApplyResources(this.RulesDataGridView, "RulesDataGridView");
            this.RulesDataGridView.AllowUserToAddRows = false;
            this.RulesDataGridView.AllowUserToDeleteRows = false;
            this.RulesDataGridView.AllowUserToOrderColumns = true;
            this.RulesDataGridView.AllowUserToResizeRows = false;
            this.RulesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RulesColumnName,
            this.RulesColumnDescripcion,
            this.RulesColumnStartDate,
            this.RulesColumnEndDate});
            this.RulesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RulesDataGridView.MultiSelect = false;
            this.RulesDataGridView.Name = "RulesDataGridView";
            this.RulesDataGridView.ReadOnly = true;
            this.RulesDataGridView.RowHeadersVisible = false;
            this.RulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RulesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RulesDataGridView_CellMouseDoubleClick);
            // 
            // RulesColumnName
            // 
            this.RulesColumnName.DataPropertyName = "Name";
            resources.ApplyResources(this.RulesColumnName, "RulesColumnName");
            this.RulesColumnName.Name = "RulesColumnName";
            this.RulesColumnName.ReadOnly = true;
            // 
            // RulesColumnDescripcion
            // 
            this.RulesColumnDescripcion.DataPropertyName = "Description";
            resources.ApplyResources(this.RulesColumnDescripcion, "RulesColumnDescripcion");
            this.RulesColumnDescripcion.Name = "RulesColumnDescripcion";
            this.RulesColumnDescripcion.ReadOnly = true;
            // 
            // RulesColumnStartDate
            // 
            this.RulesColumnStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RulesColumnStartDate.DataPropertyName = "StartDate";
            resources.ApplyResources(this.RulesColumnStartDate, "RulesColumnStartDate");
            this.RulesColumnStartDate.Name = "RulesColumnStartDate";
            this.RulesColumnStartDate.ReadOnly = true;
            // 
            // RulesColumnEndDate
            // 
            this.RulesColumnEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RulesColumnEndDate.DataPropertyName = "EndDate";
            resources.ApplyResources(this.RulesColumnEndDate, "RulesColumnEndDate");
            this.RulesColumnEndDate.Name = "RulesColumnEndDate";
            this.RulesColumnEndDate.ReadOnly = true;
            // 
            // TapControl
            // 
            resources.ApplyResources(this.TapControl, "TapControl");
            this.TapControl.Controls.Add(this.RulesTap);
            this.TapControl.Controls.Add(this.AchievementsTap);
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            // 
            // RulesTap
            // 
            resources.ApplyResources(this.RulesTap, "RulesTap");
            this.RulesTap.Controls.Add(this.ViewRuleButton);
            this.RulesTap.Controls.Add(this.RemoveRuleButton);
            this.RulesTap.Controls.Add(this.AddRuleButton);
            this.RulesTap.Controls.Add(this.DepartamentRuleComboBox);
            this.RulesTap.Controls.Add(this.RulesDataGridView);
            this.RulesTap.Controls.Add(this.DepartamentRuleLabel);
            this.RulesTap.Name = "RulesTap";
            this.RulesTap.UseVisualStyleBackColor = true;
            // 
            // ViewRuleButton
            // 
            resources.ApplyResources(this.ViewRuleButton, "ViewRuleButton");
            this.ViewRuleButton.Name = "ViewRuleButton";
            this.ViewRuleButton.UseVisualStyleBackColor = true;
            this.ViewRuleButton.Click += new System.EventHandler(this.ViewRuleButton_Click);
            // 
            // RemoveRuleButton
            // 
            resources.ApplyResources(this.RemoveRuleButton, "RemoveRuleButton");
            this.RemoveRuleButton.Name = "RemoveRuleButton";
            this.RemoveRuleButton.UseVisualStyleBackColor = true;
            this.RemoveRuleButton.Click += new System.EventHandler(this.RemoveRuleButton_Click);
            // 
            // AddRuleButton
            // 
            resources.ApplyResources(this.AddRuleButton, "AddRuleButton");
            this.AddRuleButton.Name = "AddRuleButton";
            this.AddRuleButton.UseVisualStyleBackColor = true;
            this.AddRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // AchievementsTap
            // 
            resources.ApplyResources(this.AchievementsTap, "AchievementsTap");
            this.AchievementsTap.Controls.Add(this.UserInfoPanel);
            this.AchievementsTap.Controls.Add(this.AddAchievementButton);
            this.AchievementsTap.Controls.Add(this.RemoveAchievementButton);
            this.AchievementsTap.Controls.Add(this.SearchUserButton);
            this.AchievementsTap.Controls.Add(this.AchievementsDataGridView);
            this.AchievementsTap.Controls.Add(this.UserAchievementsTextBox);
            this.AchievementsTap.Controls.Add(this.UserAchievementsLabel);
            this.AchievementsTap.Name = "AchievementsTap";
            this.AchievementsTap.UseVisualStyleBackColor = true;
            // 
            // UserInfoPanel
            // 
            resources.ApplyResources(this.UserInfoPanel, "UserInfoPanel");
            this.UserInfoPanel.BackColor = System.Drawing.Color.DarkGray;
            this.UserInfoPanel.Controls.Add(this.SelectedUserJob);
            this.UserInfoPanel.Controls.Add(this.SelectedUserDepartment);
            this.UserInfoPanel.Controls.Add(this.SelectedUserUsername);
            this.UserInfoPanel.Controls.Add(this.SelectedUserName);
            this.UserInfoPanel.Controls.Add(this.SelectedUserJobLabel);
            this.UserInfoPanel.Controls.Add(this.SelectedUserDepartmentLabel);
            this.UserInfoPanel.Controls.Add(this.SelectedUsernameLabel);
            this.UserInfoPanel.Controls.Add(this.SelectedUserLabel);
            this.UserInfoPanel.Name = "UserInfoPanel";
            // 
            // SelectedUserJob
            // 
            resources.ApplyResources(this.SelectedUserJob, "SelectedUserJob");
            this.SelectedUserJob.Name = "SelectedUserJob";
            // 
            // SelectedUserDepartment
            // 
            resources.ApplyResources(this.SelectedUserDepartment, "SelectedUserDepartment");
            this.SelectedUserDepartment.Name = "SelectedUserDepartment";
            // 
            // SelectedUserUsername
            // 
            resources.ApplyResources(this.SelectedUserUsername, "SelectedUserUsername");
            this.SelectedUserUsername.Name = "SelectedUserUsername";
            // 
            // SelectedUserName
            // 
            resources.ApplyResources(this.SelectedUserName, "SelectedUserName");
            this.SelectedUserName.Name = "SelectedUserName";
            // 
            // SelectedUserJobLabel
            // 
            resources.ApplyResources(this.SelectedUserJobLabel, "SelectedUserJobLabel");
            this.SelectedUserJobLabel.Name = "SelectedUserJobLabel";
            // 
            // SelectedUserDepartmentLabel
            // 
            resources.ApplyResources(this.SelectedUserDepartmentLabel, "SelectedUserDepartmentLabel");
            this.SelectedUserDepartmentLabel.Name = "SelectedUserDepartmentLabel";
            // 
            // SelectedUsernameLabel
            // 
            resources.ApplyResources(this.SelectedUsernameLabel, "SelectedUsernameLabel");
            this.SelectedUsernameLabel.Name = "SelectedUsernameLabel";
            // 
            // SelectedUserLabel
            // 
            resources.ApplyResources(this.SelectedUserLabel, "SelectedUserLabel");
            this.SelectedUserLabel.Name = "SelectedUserLabel";
            // 
            // AddAchievementButton
            // 
            resources.ApplyResources(this.AddAchievementButton, "AddAchievementButton");
            this.AddAchievementButton.Name = "AddAchievementButton";
            this.AddAchievementButton.UseVisualStyleBackColor = true;
            this.AddAchievementButton.Click += new System.EventHandler(this.AddAchievementButton_Click);
            // 
            // RemoveAchievementButton
            // 
            resources.ApplyResources(this.RemoveAchievementButton, "RemoveAchievementButton");
            this.RemoveAchievementButton.Name = "RemoveAchievementButton";
            this.RemoveAchievementButton.UseVisualStyleBackColor = true;
            this.RemoveAchievementButton.Click += new System.EventHandler(this.RemoveAchievementButton_Click);
            // 
            // SearchUserButton
            // 
            resources.ApplyResources(this.SearchUserButton, "SearchUserButton");
            this.SearchUserButton.Name = "SearchUserButton";
            this.SearchUserButton.UseVisualStyleBackColor = true;
            this.SearchUserButton.Click += new System.EventHandler(this.SearchUserButton_Click);
            // 
            // AchievementsDataGridView
            // 
            resources.ApplyResources(this.AchievementsDataGridView, "AchievementsDataGridView");
            this.AchievementsDataGridView.AllowUserToAddRows = false;
            this.AchievementsDataGridView.AllowUserToDeleteRows = false;
            this.AchievementsDataGridView.AllowUserToOrderColumns = true;
            this.AchievementsDataGridView.AllowUserToResizeRows = false;
            this.AchievementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AchievementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AchievementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnabledCheckBox,
            this.AchievementsColumn,
            this.AchievementsColumnDetails});
            this.AchievementsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AchievementsDataGridView.MultiSelect = false;
            this.AchievementsDataGridView.Name = "AchievementsDataGridView";
            this.AchievementsDataGridView.RowHeadersVisible = false;
            this.AchievementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AchievementsDataGridView.StandardTab = true;
            this.AchievementsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AchievementsDataGridView_DataError);
            // 
            // EnabledCheckBox
            // 
            this.EnabledCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnabledCheckBox.FalseValue = "0";
            resources.ApplyResources(this.EnabledCheckBox, "EnabledCheckBox");
            this.EnabledCheckBox.IndeterminateValue = "0";
            this.EnabledCheckBox.Name = "EnabledCheckBox";
            this.EnabledCheckBox.TrueValue = "1";
            // 
            // AchievementsColumn
            // 
            this.AchievementsColumn.DataPropertyName = "Achievement";
            resources.ApplyResources(this.AchievementsColumn, "AchievementsColumn");
            this.AchievementsColumn.Name = "AchievementsColumn";
            this.AchievementsColumn.ReadOnly = true;
            this.AchievementsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AchievementsColumnDetails
            // 
            this.AchievementsColumnDetails.DataPropertyName = "Detail";
            resources.ApplyResources(this.AchievementsColumnDetails, "AchievementsColumnDetails");
            this.AchievementsColumnDetails.Name = "AchievementsColumnDetails";
            this.AchievementsColumnDetails.ReadOnly = true;
            // 
            // UserAchievementsTextBox
            // 
            resources.ApplyResources(this.UserAchievementsTextBox, "UserAchievementsTextBox");
            this.UserAchievementsTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UserAchievementsTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UserAchievementsTextBox.Name = "UserAchievementsTextBox";
            this.UserAchievementsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserAchievementsTextBox_KeyDown);
            // 
            // UserAchievementsLabel
            // 
            resources.ApplyResources(this.UserAchievementsLabel, "UserAchievementsLabel");
            this.UserAchievementsLabel.Name = "UserAchievementsLabel";
            // 
            // FileButton
            // 
            resources.ApplyResources(this.FileButton, "FileButton");
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutButton,
            this.ExitButton});
            this.FileButton.Name = "FileButton";
            // 
            // LogoutButton
            // 
            resources.ApplyResources(this.LogoutButton, "LogoutButton");
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MenuStrip
            // 
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton,
            this.ToolsButton});
            this.MenuStrip.Name = "MenuStrip";
            // 
            // ToolsButton
            // 
            resources.ApplyResources(this.ToolsButton, "ToolsButton");
            this.ToolsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsButton});
            this.ToolsButton.Name = "ToolsButton";
            // 
            // OptionsButton
            // 
            resources.ApplyResources(this.OptionsButton, "OptionsButton");
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TapControl);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).EndInit();
            this.TapControl.ResumeLayout(false);
            this.RulesTap.ResumeLayout(false);
            this.RulesTap.PerformLayout();
            this.AchievementsTap.ResumeLayout(false);
            this.AchievementsTap.PerformLayout();
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsDataGridView)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DepartamentRuleLabel;
        private System.Windows.Forms.ComboBox DepartamentRuleComboBox;
        private System.Windows.Forms.DataGridView RulesDataGridView;
        private System.Windows.Forms.TabControl TapControl;
        private System.Windows.Forms.TabPage RulesTap;
        private System.Windows.Forms.TabPage AchievementsTap;
        private System.Windows.Forms.Button AddRuleButton;
        private System.Windows.Forms.Button RemoveRuleButton;
        private System.Windows.Forms.DataGridView AchievementsDataGridView;
        private System.Windows.Forms.TextBox UserAchievementsTextBox;
        private System.Windows.Forms.Label UserAchievementsLabel;
        private System.Windows.Forms.ToolStripMenuItem FileButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LogoutButton;
        private System.Windows.Forms.Button SearchUserButton;
        private System.Windows.Forms.Button RemoveAchievementButton;
        private System.Windows.Forms.Button ViewRuleButton;
        private System.Windows.Forms.Button AddAchievementButton;
        private System.Windows.Forms.ToolStripMenuItem ToolsButton;
        private System.Windows.Forms.ToolStripMenuItem OptionsButton;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Label SelectedUserJobLabel;
        private System.Windows.Forms.Label SelectedUserDepartmentLabel;
        private System.Windows.Forms.Label SelectedUsernameLabel;
        private System.Windows.Forms.Label SelectedUserLabel;
        private System.Windows.Forms.Label SelectedUserJob;
        private System.Windows.Forms.Label SelectedUserDepartment;
        private System.Windows.Forms.Label SelectedUserUsername;
        private System.Windows.Forms.Label SelectedUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnEndDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnabledCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievementsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievementsColumnDetails;
    }
}

