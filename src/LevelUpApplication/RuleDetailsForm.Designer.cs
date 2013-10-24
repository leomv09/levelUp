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
            resources.ApplyResources(this.RuleNameLabel, "RuleNameLabel");
            this.RuleNameLabel.Name = "RuleNameLabel";
            // 
            // RuleDescripcionLabel
            // 
            resources.ApplyResources(this.RuleDescripcionLabel, "RuleDescripcionLabel");
            this.RuleDescripcionLabel.Name = "RuleDescripcionLabel";
            // 
            // EndDateLabel
            // 
            resources.ApplyResources(this.EndDateLabel, "EndDateLabel");
            this.EndDateLabel.Name = "EndDateLabel";
            // 
            // StartDateLabel
            // 
            resources.ApplyResources(this.StartDateLabel, "StartDateLabel");
            this.StartDateLabel.Name = "StartDateLabel";
            // 
            // RuleNameTextBox
            // 
            resources.ApplyResources(this.RuleNameTextBox, "RuleNameTextBox");
            this.RuleNameTextBox.Name = "RuleNameTextBox";
            // 
            // RuleDescripcionTextBox
            // 
            resources.ApplyResources(this.RuleDescripcionTextBox, "RuleDescripcionTextBox");
            this.RuleDescripcionTextBox.Name = "RuleDescripcionTextBox";
            // 
            // EndDateTimePicker
            // 
            resources.ApplyResources(this.EndDateTimePicker, "EndDateTimePicker");
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            // 
            // StartDateTimePicker
            // 
            resources.ApplyResources(this.StartDateTimePicker, "StartDateTimePicker");
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            // 
            // AcceptRuleButton
            // 
            resources.ApplyResources(this.AcceptRuleButton, "AcceptRuleButton");
            this.AcceptRuleButton.Name = "AcceptRuleButton";
            this.AcceptRuleButton.UseVisualStyleBackColor = true;
            this.AcceptRuleButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // ApplyRuleButton
            // 
            resources.ApplyResources(this.ApplyRuleButton, "ApplyRuleButton");
            this.ApplyRuleButton.Name = "ApplyRuleButton";
            this.ApplyRuleButton.UseVisualStyleBackColor = true;
            this.ApplyRuleButton.Click += new System.EventHandler(this.ApplyRuleButton_Click);
            // 
            // CancelRuleButton
            // 
            resources.ApplyResources(this.CancelRuleButton, "CancelRuleButton");
            this.CancelRuleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRuleButton.Name = "CancelRuleButton";
            this.CancelRuleButton.UseVisualStyleBackColor = true;
            this.CancelRuleButton.Click += new System.EventHandler(this.CancelRuleButton_Click);
            // 
            // AchievementsDataGridView
            // 
            resources.ApplyResources(this.AchievementsDataGridView, "AchievementsDataGridView");
            this.AchievementsDataGridView.AllowUserToAddRows = false;
            this.AchievementsDataGridView.AllowUserToResizeRows = false;
            this.AchievementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AchievementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AchievementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AchievementName,
            this.AchievementAmount,
            this.RemoveAchievementButton});
            this.AchievementsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AchievementsDataGridView.Name = "AchievementsDataGridView";
            this.AchievementsDataGridView.RowHeadersVisible = false;
            this.AchievementsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AchievementsDataGridView_CellContentClick);
            this.AchievementsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AchievementsDataGridView_DataError);
            // 
            // AchievementName
            // 
            this.AchievementName.DataPropertyName = "Achievement";
            resources.ApplyResources(this.AchievementName, "AchievementName");
            this.AchievementName.Name = "AchievementName";
            this.AchievementName.ReadOnly = true;
            this.AchievementName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AchievementName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AchievementAmount
            // 
            this.AchievementAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AchievementAmount.DataPropertyName = "Amount";
            resources.ApplyResources(this.AchievementAmount, "AchievementAmount");
            this.AchievementAmount.Name = "AchievementAmount";
            this.AchievementAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // RemoveAchievementButton
            // 
            this.RemoveAchievementButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.RemoveAchievementButton, "RemoveAchievementButton");
            this.RemoveAchievementButton.Name = "RemoveAchievementButton";
            this.RemoveAchievementButton.Text = "Supprimer";
            this.RemoveAchievementButton.UseColumnTextForButtonValue = true;
            // 
            // AchievementListLabel
            // 
            resources.ApplyResources(this.AchievementListLabel, "AchievementListLabel");
            this.AchievementListLabel.Name = "AchievementListLabel";
            // 
            // AwardsDataGridView
            // 
            resources.ApplyResources(this.AwardsDataGridView, "AwardsDataGridView");
            this.AwardsDataGridView.AllowUserToAddRows = false;
            this.AwardsDataGridView.AllowUserToResizeRows = false;
            this.AwardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AwardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AwardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwardName,
            this.AwardDetails,
            this.Remove});
            this.AwardsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AwardsDataGridView.Name = "AwardsDataGridView";
            this.AwardsDataGridView.RowHeadersVisible = false;
            this.AwardsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AwardsDataGridView_CellContentClick);
            // 
            // AwardName
            // 
            this.AwardName.DataPropertyName = "Name";
            this.AwardName.FillWeight = 194.9239F;
            resources.ApplyResources(this.AwardName, "AwardName");
            this.AwardName.Name = "AwardName";
            this.AwardName.ReadOnly = true;
            this.AwardName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AwardName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AwardDetails
            // 
            this.AwardDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AwardDetails.FillWeight = 5.076142F;
            resources.ApplyResources(this.AwardDetails, "AwardDetails");
            this.AwardDetails.Name = "AwardDetails";
            this.AwardDetails.Text = "Voir";
            this.AwardDetails.UseColumnTextForButtonValue = true;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Remove, "Remove");
            this.Remove.Name = "Remove";
            this.Remove.Text = "Supprimer";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // AwardListLabel
            // 
            resources.ApplyResources(this.AwardListLabel, "AwardListLabel");
            this.AwardListLabel.Name = "AwardListLabel";
            // 
            // AddAchievementButton
            // 
            resources.ApplyResources(this.AddAchievementButton, "AddAchievementButton");
            this.AddAchievementButton.Name = "AddAchievementButton";
            this.AddAchievementButton.UseVisualStyleBackColor = true;
            this.AddAchievementButton.Click += new System.EventHandler(this.AddAchievementButton_Click);
            // 
            // AddAwardButton
            // 
            resources.ApplyResources(this.AddAwardButton, "AddAwardButton");
            this.AddAwardButton.Name = "AddAwardButton";
            this.AddAwardButton.UseVisualStyleBackColor = true;
            this.AddAwardButton.Click += new System.EventHandler(this.AddAwardButton_Click);
            // 
            // RuleDetailsForm
            // 
            this.AcceptButton = this.AcceptRuleButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRuleButton;
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
            this.MaximizeBox = false;
            this.Name = "RuleDetailsForm";
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