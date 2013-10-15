namespace LevelUpApplication
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
            this.Rules = new System.Windows.Forms.TabPage();
            this.RemoveRuleButton = new System.Windows.Forms.Button();
            this.AddRuleButton = new System.Windows.Forms.Button();
            this.Achievements = new System.Windows.Forms.TabPage();
            this.RemoveAchievementButton = new System.Windows.Forms.Button();
            this.SearchUserButton = new System.Windows.Forms.Button();
            this.AchievementsDataGridView = new System.Windows.Forms.DataGridView();
            this.AchievementsColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AchievementsColumnDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AchievementsColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AchievementsColumnCreador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAchievementsTextBox = new System.Windows.Forms.TextBox();
            this.UserAchievementsLabel = new System.Windows.Forms.Label();
            this.FileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).BeginInit();
            this.TapControl.SuspendLayout();
            this.Rules.SuspendLayout();
            this.Achievements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsDataGridView)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartamentRuleLabel
            // 
            this.DepartamentRuleLabel.AutoSize = true;
            this.DepartamentRuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartamentRuleLabel.Location = new System.Drawing.Point(16, 10);
            this.DepartamentRuleLabel.Name = "DepartamentRuleLabel";
            this.DepartamentRuleLabel.Size = new System.Drawing.Size(94, 16);
            this.DepartamentRuleLabel.TabIndex = 0;
            this.DepartamentRuleLabel.Text = "Departamento";
            // 
            // DepartamentRuleComboBox
            // 
            this.DepartamentRuleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartamentRuleComboBox.FormattingEnabled = true;
            this.DepartamentRuleComboBox.Location = new System.Drawing.Point(19, 29);
            this.DepartamentRuleComboBox.Name = "DepartamentRuleComboBox";
            this.DepartamentRuleComboBox.Size = new System.Drawing.Size(246, 21);
            this.DepartamentRuleComboBox.Sorted = true;
            this.DepartamentRuleComboBox.TabIndex = 1;
            this.DepartamentRuleComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartamentRuleComboBox_SelectedIndexChanged);
            // 
            // RulesDataGridView
            // 
            this.RulesDataGridView.AllowUserToAddRows = false;
            this.RulesDataGridView.AllowUserToDeleteRows = false;
            this.RulesDataGridView.AllowUserToOrderColumns = true;
            this.RulesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RulesColumnName,
            this.RulesColumnDescripcion,
            this.RulesColumnStartDate,
            this.RulesColumnEndDate});
            this.RulesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RulesDataGridView.Location = new System.Drawing.Point(3, 70);
            this.RulesDataGridView.MultiSelect = false;
            this.RulesDataGridView.Name = "RulesDataGridView";
            this.RulesDataGridView.ReadOnly = true;
            this.RulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RulesDataGridView.Size = new System.Drawing.Size(892, 472);
            this.RulesDataGridView.TabIndex = 3;
            this.RulesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RulesDataGridView_CellMouseDoubleClick);
            // 
            // RulesColumnName
            // 
            this.RulesColumnName.HeaderText = "Nombre";
            this.RulesColumnName.Name = "RulesColumnName";
            this.RulesColumnName.ReadOnly = true;
            // 
            // RulesColumnDescripcion
            // 
            this.RulesColumnDescripcion.HeaderText = "Descripción";
            this.RulesColumnDescripcion.Name = "RulesColumnDescripcion";
            this.RulesColumnDescripcion.ReadOnly = true;
            // 
            // RulesColumnStartDate
            // 
            this.RulesColumnStartDate.HeaderText = "Fecha de Inicio";
            this.RulesColumnStartDate.Name = "RulesColumnStartDate";
            this.RulesColumnStartDate.ReadOnly = true;
            // 
            // RulesColumnEndDate
            // 
            this.RulesColumnEndDate.HeaderText = "Fecha de Finalización";
            this.RulesColumnEndDate.Name = "RulesColumnEndDate";
            this.RulesColumnEndDate.ReadOnly = true;
            // 
            // TapControl
            // 
            this.TapControl.Controls.Add(this.Rules);
            this.TapControl.Controls.Add(this.Achievements);
            this.TapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TapControl.Location = new System.Drawing.Point(0, 24);
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(906, 571);
            this.TapControl.TabIndex = 4;
            // 
            // Rules
            // 
            this.Rules.Controls.Add(this.RemoveRuleButton);
            this.Rules.Controls.Add(this.AddRuleButton);
            this.Rules.Controls.Add(this.DepartamentRuleComboBox);
            this.Rules.Controls.Add(this.RulesDataGridView);
            this.Rules.Controls.Add(this.DepartamentRuleLabel);
            this.Rules.Location = new System.Drawing.Point(4, 22);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(898, 545);
            this.Rules.TabIndex = 0;
            this.Rules.Text = "Reglas";
            this.Rules.UseVisualStyleBackColor = true;
            // 
            // RemoveRuleButton
            // 
            this.RemoveRuleButton.Location = new System.Drawing.Point(815, 10);
            this.RemoveRuleButton.Name = "RemoveRuleButton";
            this.RemoveRuleButton.Size = new System.Drawing.Size(75, 40);
            this.RemoveRuleButton.TabIndex = 5;
            this.RemoveRuleButton.Text = "Eliminar";
            this.RemoveRuleButton.UseVisualStyleBackColor = true;
            this.RemoveRuleButton.Click += new System.EventHandler(this.RemoveRuleButton_Click);
            // 
            // AddRuleButton
            // 
            this.AddRuleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRuleButton.Location = new System.Drawing.Point(734, 10);
            this.AddRuleButton.Name = "AddRuleButton";
            this.AddRuleButton.Size = new System.Drawing.Size(75, 40);
            this.AddRuleButton.TabIndex = 4;
            this.AddRuleButton.Text = "Agregar";
            this.AddRuleButton.UseVisualStyleBackColor = true;
            this.AddRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // Achievements
            // 
            this.Achievements.Controls.Add(this.RemoveAchievementButton);
            this.Achievements.Controls.Add(this.SearchUserButton);
            this.Achievements.Controls.Add(this.AchievementsDataGridView);
            this.Achievements.Controls.Add(this.UserAchievementsTextBox);
            this.Achievements.Controls.Add(this.UserAchievementsLabel);
            this.Achievements.Location = new System.Drawing.Point(4, 22);
            this.Achievements.Name = "Achievements";
            this.Achievements.Padding = new System.Windows.Forms.Padding(3);
            this.Achievements.Size = new System.Drawing.Size(898, 545);
            this.Achievements.TabIndex = 1;
            this.Achievements.Text = "Logros";
            this.Achievements.UseVisualStyleBackColor = true;
            // 
            // RemoveAchievementButton
            // 
            this.RemoveAchievementButton.Location = new System.Drawing.Point(815, 10);
            this.RemoveAchievementButton.Name = "RemoveAchievementButton";
            this.RemoveAchievementButton.Size = new System.Drawing.Size(75, 40);
            this.RemoveAchievementButton.TabIndex = 7;
            this.RemoveAchievementButton.Text = "Eliminar";
            this.RemoveAchievementButton.UseVisualStyleBackColor = true;
            this.RemoveAchievementButton.Click += new System.EventHandler(this.RemoveAchievementButton_Click);
            // 
            // SearchUserButton
            // 
            this.SearchUserButton.Location = new System.Drawing.Point(271, 27);
            this.SearchUserButton.Name = "SearchUserButton";
            this.SearchUserButton.Size = new System.Drawing.Size(75, 23);
            this.SearchUserButton.TabIndex = 6;
            this.SearchUserButton.Text = "Buscar";
            this.SearchUserButton.UseVisualStyleBackColor = true;
            this.SearchUserButton.Click += new System.EventHandler(this.SearchUserButton_Click);
            // 
            // AchievementsDataGridView
            // 
            this.AchievementsDataGridView.AllowUserToDeleteRows = false;
            this.AchievementsDataGridView.AllowUserToOrderColumns = true;
            this.AchievementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AchievementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AchievementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AchievementsColumn,
            this.AchievementsColumnDetails,
            this.AchievementsColumnDate,
            this.AchievementsColumnCreador});
            this.AchievementsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AchievementsDataGridView.Location = new System.Drawing.Point(3, 70);
            this.AchievementsDataGridView.MultiSelect = false;
            this.AchievementsDataGridView.Name = "AchievementsDataGridView";
            this.AchievementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AchievementsDataGridView.Size = new System.Drawing.Size(892, 472);
            this.AchievementsDataGridView.StandardTab = true;
            this.AchievementsDataGridView.TabIndex = 4;
            // 
            // AchievementsColumn
            // 
            this.AchievementsColumn.HeaderText = "Logro";
            this.AchievementsColumn.Name = "AchievementsColumn";
            this.AchievementsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AchievementsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AchievementsColumnDetails
            // 
            this.AchievementsColumnDetails.HeaderText = "Detalles";
            this.AchievementsColumnDetails.Name = "AchievementsColumnDetails";
            // 
            // AchievementsColumnDate
            // 
            this.AchievementsColumnDate.HeaderText = "Fecha Obtención";
            this.AchievementsColumnDate.Name = "AchievementsColumnDate";
            this.AchievementsColumnDate.ReadOnly = true;
            // 
            // AchievementsColumnCreador
            // 
            this.AchievementsColumnCreador.HeaderText = "Creador";
            this.AchievementsColumnCreador.Name = "AchievementsColumnCreador";
            this.AchievementsColumnCreador.ReadOnly = true;
            // 
            // UserAchievementsTextBox
            // 
            this.UserAchievementsTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.UserAchievementsTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UserAchievementsTextBox.Location = new System.Drawing.Point(19, 29);
            this.UserAchievementsTextBox.Name = "UserAchievementsTextBox";
            this.UserAchievementsTextBox.Size = new System.Drawing.Size(246, 20);
            this.UserAchievementsTextBox.TabIndex = 1;
            this.UserAchievementsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserAchievementsTextBox_KeyUp);
            // 
            // UserAchievementsLabel
            // 
            this.UserAchievementsLabel.AutoSize = true;
            this.UserAchievementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAchievementsLabel.Location = new System.Drawing.Point(16, 10);
            this.UserAchievementsLabel.Name = "UserAchievementsLabel";
            this.UserAchievementsLabel.Size = new System.Drawing.Size(55, 16);
            this.UserAchievementsLabel.TabIndex = 0;
            this.UserAchievementsLabel.Text = "Usuario";
            // 
            // FileButton
            // 
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutButton,
            this.ExitButton});
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(60, 20);
            this.FileButton.Text = "Archivo";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(143, 22);
            this.LogoutButton.Text = "Cerrar Sesión";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(143, 22);
            this.ExitButton.Text = "Salir";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(906, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 595);
            this.Controls.Add(this.TapControl);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Up";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).EndInit();
            this.TapControl.ResumeLayout(false);
            this.Rules.ResumeLayout(false);
            this.Rules.PerformLayout();
            this.Achievements.ResumeLayout(false);
            this.Achievements.PerformLayout();
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
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.TabPage Achievements;
        private System.Windows.Forms.Button AddRuleButton;
        private System.Windows.Forms.Button RemoveRuleButton;
        private System.Windows.Forms.DataGridView AchievementsDataGridView;
        private System.Windows.Forms.TextBox UserAchievementsTextBox;
        private System.Windows.Forms.Label UserAchievementsLabel;
        private System.Windows.Forms.ToolStripMenuItem FileButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RulesColumnEndDate;
        private System.Windows.Forms.ToolStripMenuItem LogoutButton;
        private System.Windows.Forms.Button SearchUserButton;
        private System.Windows.Forms.Button RemoveAchievementButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn AchievementsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievementsColumnDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievementsColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievementsColumnCreador;
        private Controller AppController;
    }
}

