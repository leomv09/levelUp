namespace LevelUpApplication
{
    partial class RuleDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleDetailsForm));
            this.RuleNameLabel = new System.Windows.Forms.Label();
            this.RuleDescripcionLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.RuleNameTextBox = new System.Windows.Forms.TextBox();
            this.RuleDescripcionTextBox = new System.Windows.Forms.RichTextBox();
            this.EndFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AcceptRuleButton = new System.Windows.Forms.Button();
            this.ApplyRuleButton = new System.Windows.Forms.Button();
            this.CancelRuleButton = new System.Windows.Forms.Button();
            this.AchievementsDataGridView = new System.Windows.Forms.DataGridView();
            this.Achievement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AchievementListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RuleNameLabel
            // 
            this.RuleNameLabel.AutoSize = true;
            this.RuleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleNameLabel.Location = new System.Drawing.Point(9, 15);
            this.RuleNameLabel.Name = "RuleNameLabel";
            this.RuleNameLabel.Size = new System.Drawing.Size(57, 16);
            this.RuleNameLabel.TabIndex = 0;
            this.RuleNameLabel.Text = "Nombre";
            // 
            // RuleDescripcionLabel
            // 
            this.RuleDescripcionLabel.AutoSize = true;
            this.RuleDescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleDescripcionLabel.Location = new System.Drawing.Point(9, 78);
            this.RuleDescripcionLabel.Name = "RuleDescripcionLabel";
            this.RuleDescripcionLabel.Size = new System.Drawing.Size(80, 16);
            this.RuleDescripcionLabel.TabIndex = 1;
            this.RuleDescripcionLabel.Text = "Descripción";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(6, 293);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(78, 16);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "Fecha Final";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(9, 216);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(80, 16);
            this.StartDateLabel.TabIndex = 3;
            this.StartDateLabel.Text = "Fecha Inicio";
            // 
            // RuleNameTextBox
            // 
            this.RuleNameTextBox.Location = new System.Drawing.Point(12, 34);
            this.RuleNameTextBox.Name = "RuleNameTextBox";
            this.RuleNameTextBox.Size = new System.Drawing.Size(277, 20);
            this.RuleNameTextBox.TabIndex = 4;
            // 
            // RuleDescripcionTextBox
            // 
            this.RuleDescripcionTextBox.Location = new System.Drawing.Point(9, 97);
            this.RuleDescripcionTextBox.Name = "RuleDescripcionTextBox";
            this.RuleDescripcionTextBox.Size = new System.Drawing.Size(277, 96);
            this.RuleDescripcionTextBox.TabIndex = 5;
            this.RuleDescripcionTextBox.Text = "";
            // 
            // EndFinalDateTimePicker
            // 
            this.EndFinalDateTimePicker.Location = new System.Drawing.Point(9, 312);
            this.EndFinalDateTimePicker.Name = "EndFinalDateTimePicker";
            this.EndFinalDateTimePicker.Size = new System.Drawing.Size(280, 20);
            this.EndFinalDateTimePicker.TabIndex = 6;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(9, 235);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.StartDateTimePicker.TabIndex = 7;
            // 
            // AcceptRuleButton
            // 
            this.AcceptRuleButton.Location = new System.Drawing.Point(656, 360);
            this.AcceptRuleButton.Name = "AcceptRuleButton";
            this.AcceptRuleButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptRuleButton.TabIndex = 8;
            this.AcceptRuleButton.Text = "Aceptar";
            this.AcceptRuleButton.UseVisualStyleBackColor = true;
            this.AcceptRuleButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // ApplyRuleButton
            // 
            this.ApplyRuleButton.Location = new System.Drawing.Point(738, 360);
            this.ApplyRuleButton.Name = "ApplyRuleButton";
            this.ApplyRuleButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyRuleButton.TabIndex = 9;
            this.ApplyRuleButton.Text = "Aplicar";
            this.ApplyRuleButton.UseVisualStyleBackColor = true;
            this.ApplyRuleButton.Click += new System.EventHandler(this.ApplyRuleButton_Click);
            // 
            // CancelRuleButton
            // 
            this.CancelRuleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRuleButton.Location = new System.Drawing.Point(819, 360);
            this.CancelRuleButton.Name = "CancelRuleButton";
            this.CancelRuleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelRuleButton.TabIndex = 10;
            this.CancelRuleButton.Text = "Cancelar";
            this.CancelRuleButton.UseVisualStyleBackColor = true;
            // 
            // AchievementsDataGridView
            // 
            this.AchievementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AchievementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AchievementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Achievement,
            this.Amount,
            this.CreationDate,
            this.Creator});
            this.AchievementsDataGridView.Location = new System.Drawing.Point(305, 36);
            this.AchievementsDataGridView.Name = "AchievementsDataGridView";
            this.AchievementsDataGridView.Size = new System.Drawing.Size(589, 296);
            this.AchievementsDataGridView.TabIndex = 11;
            // 
            // Achievement
            // 
            this.Achievement.HeaderText = "Logro";
            this.Achievement.Name = "Achievement";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Cantidad";
            this.Amount.Name = "Amount";
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "Fecha Creación";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // Creator
            // 
            this.Creator.HeaderText = "Creador";
            this.Creator.Name = "Creator";
            this.Creator.ReadOnly = true;
            // 
            // AchievementListLabel
            // 
            this.AchievementListLabel.AutoSize = true;
            this.AchievementListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievementListLabel.Location = new System.Drawing.Point(302, 15);
            this.AchievementListLabel.Name = "AchievementListLabel";
            this.AchievementListLabel.Size = new System.Drawing.Size(100, 16);
            this.AchievementListLabel.TabIndex = 12;
            this.AchievementListLabel.Text = "Lista de Logros";
            // 
            // RuleDetailsForm
            // 
            this.AcceptButton = this.AcceptRuleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRuleButton;
            this.ClientSize = new System.Drawing.Size(906, 395);
            this.Controls.Add(this.AchievementListLabel);
            this.Controls.Add(this.AchievementsDataGridView);
            this.Controls.Add(this.CancelRuleButton);
            this.Controls.Add(this.ApplyRuleButton);
            this.Controls.Add(this.AcceptRuleButton);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.EndFinalDateTimePicker);
            this.Controls.Add(this.RuleDescripcionTextBox);
            this.Controls.Add(this.RuleNameTextBox);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.RuleDescripcionLabel);
            this.Controls.Add(this.RuleNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RuleDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RuleNameLabel;
        private System.Windows.Forms.Label RuleDescripcionLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.TextBox RuleNameTextBox;
        private System.Windows.Forms.RichTextBox RuleDescripcionTextBox;
        private System.Windows.Forms.DateTimePicker EndFinalDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Button AcceptRuleButton;
        private System.Windows.Forms.Button ApplyRuleButton;
        private System.Windows.Forms.Button CancelRuleButton;
        private System.Windows.Forms.DataGridView AchievementsDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn Achievement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.Label AchievementListLabel;
    }
}