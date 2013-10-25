namespace LevelUp.App
{
    partial class AddAchievementPerUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAchievementPerUserForm));
            this.AchievementComboBox = new System.Windows.Forms.ComboBox();
            this.CancelAchievementButton = new System.Windows.Forms.Button();
            this.AcceptAchievementButton = new System.Windows.Forms.Button();
            this.DetailTextBox = new System.Windows.Forms.TextBox();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.AchievementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AchievementComboBox
            // 
            resources.ApplyResources(this.AchievementComboBox, "AchievementComboBox");
            this.AchievementComboBox.FormattingEnabled = true;
            this.AchievementComboBox.Name = "AchievementComboBox";
            this.AchievementComboBox.SelectionChangeCommitted += new System.EventHandler(this.AchievementComboBox_SelectionChangeCommitted);
            // 
            // CancelAchievementButton
            // 
            resources.ApplyResources(this.CancelAchievementButton, "CancelAchievementButton");
            this.CancelAchievementButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAchievementButton.Name = "CancelAchievementButton";
            this.CancelAchievementButton.UseVisualStyleBackColor = true;
            // 
            // AcceptAchievementButton
            // 
            resources.ApplyResources(this.AcceptAchievementButton, "AcceptAchievementButton");
            this.AcceptAchievementButton.Name = "AcceptAchievementButton";
            this.AcceptAchievementButton.UseVisualStyleBackColor = true;
            this.AcceptAchievementButton.Click += new System.EventHandler(this.AcceptAchievementButton_Click);
            // 
            // DetailTextBox
            // 
            resources.ApplyResources(this.DetailTextBox, "DetailTextBox");
            this.DetailTextBox.Name = "DetailTextBox";
            this.DetailTextBox.TextChanged += new System.EventHandler(this.DetailTextBox_TextChanged);
            // 
            // DetailLabel
            // 
            resources.ApplyResources(this.DetailLabel, "DetailLabel");
            this.DetailLabel.Name = "DetailLabel";
            // 
            // AchievementLabel
            // 
            resources.ApplyResources(this.AchievementLabel, "AchievementLabel");
            this.AchievementLabel.Name = "AchievementLabel";
            // 
            // AddAchievementPerUserForm
            // 
            this.AcceptButton = this.AcceptAchievementButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAchievementButton;
            this.Controls.Add(this.AchievementLabel);
            this.Controls.Add(this.DetailLabel);
            this.Controls.Add(this.DetailTextBox);
            this.Controls.Add(this.CancelAchievementButton);
            this.Controls.Add(this.AcceptAchievementButton);
            this.Controls.Add(this.AchievementComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "AddAchievementPerUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementComboBox;
        private System.Windows.Forms.Button CancelAchievementButton;
        private System.Windows.Forms.Button AcceptAchievementButton;
        private System.Windows.Forms.TextBox DetailTextBox;
        private System.Windows.Forms.Label DetailLabel;
        private System.Windows.Forms.Label AchievementLabel;
    }
}