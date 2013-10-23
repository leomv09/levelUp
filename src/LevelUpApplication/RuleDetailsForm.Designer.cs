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
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AcceptRuleButton = new System.Windows.Forms.Button();
            this.ApplyRuleButton = new System.Windows.Forms.Button();
            this.CancelRuleButton = new System.Windows.Forms.Button();
            this.AchievementsDataGridView = new System.Windows.Forms.DataGridView();
            this.AchievementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AchievementAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveAchievementButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AchievementListLabel = new System.Windows.Forms.Label();
            this.AwardsDataGridView = new System.Windows.Forms.DataGridView();
            this.AwardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwardDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AwardListLabel = new System.Windows.Forms.Label();
            this.AddAchievementButton = new System.Windows.Forms.Button();
            this.AddAwardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AwardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RuleNameLabel
            // 
            this.RuleNameLabel.AutoSize = true;
            this.RuleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleNameLabel.Location = new System.Drawing.Point(616, 36);
            this.RuleNameLabel.Name = "RuleNameLabel";
            this.RuleNameLabel.Size = new System.Drawing.Size(57, 16);
            this.RuleNameLabel.TabIndex = 0;
            this.RuleNameLabel.Text = "Nombre";
            // 
            // RuleDescripcionLabel
            // 
            this.RuleDescripcionLabel.AutoSize = true;
            this.RuleDescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleDescripcionLabel.Location = new System.Drawing.Point(616, 103);
            this.RuleDescripcionLabel.Name = "RuleDescripcionLabel";
            this.RuleDescripcionLabel.Size = new System.Drawing.Size(80, 16);
            this.RuleDescripcionLabel.TabIndex = 1;
            this.RuleDescripcionLabel.Text = "Descripción";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(616, 352);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(78, 16);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "Fecha Final";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(616, 288);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(80, 16);
            this.StartDateLabel.TabIndex = 3;
            this.StartDateLabel.Text = "Fecha Inicio";
            // 
            // RuleNameTextBox
            // 
            this.RuleNameTextBox.Location = new System.Drawing.Point(616, 55);
            this.RuleNameTextBox.Name = "RuleNameTextBox";
            this.RuleNameTextBox.Size = new System.Drawing.Size(277, 20);
            this.RuleNameTextBox.TabIndex = 4;
            // 
            // RuleDescripcionTextBox
            // 
            this.RuleDescripcionTextBox.Location = new System.Drawing.Point(616, 122);
            this.RuleDescripcionTextBox.Name = "RuleDescripcionTextBox";
            this.RuleDescripcionTextBox.Size = new System.Drawing.Size(277, 129);
            this.RuleDescripcionTextBox.TabIndex = 5;
            this.RuleDescripcionTextBox.Text = "";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(616, 371);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.EndDateTimePicker.TabIndex = 6;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(616, 307);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.StartDateTimePicker.TabIndex = 7;
            // 
            // AcceptRuleButton
            // 
            this.AcceptRuleButton.Location = new System.Drawing.Point(655, 435);
            this.AcceptRuleButton.Name = "AcceptRuleButton";
            this.AcceptRuleButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptRuleButton.TabIndex = 8;
            this.AcceptRuleButton.Text = "Aceptar";
            this.AcceptRuleButton.UseVisualStyleBackColor = true;
            this.AcceptRuleButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // ApplyRuleButton
            // 
            this.ApplyRuleButton.Location = new System.Drawing.Point(737, 435);
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
            this.CancelRuleButton.Location = new System.Drawing.Point(818, 435);
            this.CancelRuleButton.Name = "CancelRuleButton";
            this.CancelRuleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelRuleButton.TabIndex = 10;
            this.CancelRuleButton.Text = "Cancelar";
            this.CancelRuleButton.UseVisualStyleBackColor = true;
            this.CancelRuleButton.Click += new System.EventHandler(this.CancelRuleButton_Click);
            // 
            // AchievementsDataGridView
            // 
            this.AchievementsDataGridView.AllowUserToAddRows = false;
            this.AchievementsDataGridView.AllowUserToResizeRows = false;
            this.AchievementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AchievementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AchievementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AchievementName,
            this.AchievementAmount,
            this.RemoveAchievementButton});
            this.AchievementsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AchievementsDataGridView.Location = new System.Drawing.Point(12, 36);
            this.AchievementsDataGridView.Name = "AchievementsDataGridView";
            this.AchievementsDataGridView.RowHeadersVisible = false;
            this.AchievementsDataGridView.Size = new System.Drawing.Size(584, 215);
            this.AchievementsDataGridView.TabIndex = 11;
            this.AchievementsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AchievementsDataGridView_CellContentClick);
            this.AchievementsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AchievementsDataGridView_DataError);
            // 
            // AchievementName
            // 
            this.AchievementName.DataPropertyName = "Achievement";
            this.AchievementName.HeaderText = "Logro";
            this.AchievementName.Name = "AchievementName";
            this.AchievementName.ReadOnly = true;
            this.AchievementName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AchievementName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AchievementAmount
            // 
            this.AchievementAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AchievementAmount.DataPropertyName = "Amount";
            this.AchievementAmount.HeaderText = "Cantidad";
            this.AchievementAmount.Name = "AchievementAmount";
            this.AchievementAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AchievementAmount.Width = 74;
            // 
            // RemoveAchievementButton
            // 
            this.RemoveAchievementButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RemoveAchievementButton.HeaderText = "Eliminar";
            this.RemoveAchievementButton.Name = "RemoveAchievementButton";
            this.RemoveAchievementButton.Text = "Eliminar";
            this.RemoveAchievementButton.UseColumnTextForButtonValue = true;
            this.RemoveAchievementButton.Width = 50;
            // 
            // AchievementListLabel
            // 
            this.AchievementListLabel.AutoSize = true;
            this.AchievementListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchievementListLabel.Location = new System.Drawing.Point(9, 15);
            this.AchievementListLabel.Name = "AchievementListLabel";
            this.AchievementListLabel.Size = new System.Drawing.Size(100, 16);
            this.AchievementListLabel.TabIndex = 12;
            this.AchievementListLabel.Text = "Lista de Logros";
            // 
            // AwardsDataGridView
            // 
            this.AwardsDataGridView.AllowUserToAddRows = false;
            this.AwardsDataGridView.AllowUserToResizeRows = false;
            this.AwardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AwardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AwardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwardName,
            this.AwardDetails,
            this.Remove});
            this.AwardsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AwardsDataGridView.Location = new System.Drawing.Point(12, 288);
            this.AwardsDataGridView.Name = "AwardsDataGridView";
            this.AwardsDataGridView.RowHeadersVisible = false;
            this.AwardsDataGridView.Size = new System.Drawing.Size(584, 170);
            this.AwardsDataGridView.TabIndex = 13;
            this.AwardsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AwardsDataGridView_CellContentClick);
            // 
            // AwardName
            // 
            this.AwardName.DataPropertyName = "Name";
            this.AwardName.FillWeight = 194.9239F;
            this.AwardName.HeaderText = "Premio";
            this.AwardName.Name = "AwardName";
            this.AwardName.ReadOnly = true;
            this.AwardName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AwardName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AwardDetails
            // 
            this.AwardDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AwardDetails.FillWeight = 5.076142F;
            this.AwardDetails.HeaderText = "Detalles";
            this.AwardDetails.Name = "AwardDetails";
            this.AwardDetails.Text = "Ver";
            this.AwardDetails.UseColumnTextForButtonValue = true;
            this.AwardDetails.Width = 50;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Remove.HeaderText = "Eliminar";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Eliminar";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 50;
            // 
            // AwardListLabel
            // 
            this.AwardListLabel.AutoSize = true;
            this.AwardListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwardListLabel.Location = new System.Drawing.Point(12, 267);
            this.AwardListLabel.Name = "AwardListLabel";
            this.AwardListLabel.Size = new System.Drawing.Size(108, 16);
            this.AwardListLabel.TabIndex = 14;
            this.AwardListLabel.Text = "Lista de Premios";
            // 
            // AddAchievementButton
            // 
            this.AddAchievementButton.Location = new System.Drawing.Point(521, 8);
            this.AddAchievementButton.Name = "AddAchievementButton";
            this.AddAchievementButton.Size = new System.Drawing.Size(75, 23);
            this.AddAchievementButton.TabIndex = 15;
            this.AddAchievementButton.Text = "Agregar";
            this.AddAchievementButton.UseVisualStyleBackColor = true;
            this.AddAchievementButton.Click += new System.EventHandler(this.AddAchievementButton_Click);
            // 
            // AddAwardButton
            // 
            this.AddAwardButton.Location = new System.Drawing.Point(521, 259);
            this.AddAwardButton.Name = "AddAwardButton";
            this.AddAwardButton.Size = new System.Drawing.Size(75, 23);
            this.AddAwardButton.TabIndex = 16;
            this.AddAwardButton.Text = "Agregar";
            this.AddAwardButton.UseVisualStyleBackColor = true;
            this.AddAwardButton.Click += new System.EventHandler(this.AddAwardButton_Click);
            // 
            // RuleDetailsForm
            // 
            this.AcceptButton = this.AcceptRuleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRuleButton;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.AddAwardButton);
            this.Controls.Add(this.AddAchievementButton);
            this.Controls.Add(this.AwardListLabel);
            this.Controls.Add(this.AwardsDataGridView);
            this.Controls.Add(this.AchievementListLabel);
            this.Controls.Add(this.AchievementsDataGridView);
            this.Controls.Add(this.CancelRuleButton);
            this.Controls.Add(this.ApplyRuleButton);
            this.Controls.Add(this.AcceptRuleButton);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.RuleDescripcionTextBox);
            this.Controls.Add(this.RuleNameTextBox);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.RuleDescripcionLabel);
            this.Controls.Add(this.RuleNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RuleDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.AchievementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AwardsDataGridView)).EndInit();
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
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Button AcceptRuleButton;
        private System.Windows.Forms.Button ApplyRuleButton;
        private System.Windows.Forms.Button CancelRuleButton;
        private System.Windows.Forms.DataGridView AchievementsDataGridView;
        private System.Windows.Forms.Label AchievementListLabel;
        private System.Windows.Forms.DataGridView AwardsDataGridView;
        private System.Windows.Forms.Label AwardListLabel;
        private System.Windows.Forms.Button AddAchievementButton;
        private System.Windows.Forms.Button AddAwardButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievementAmount;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveAchievementButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardName;
        private System.Windows.Forms.DataGridViewButtonColumn AwardDetails;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}