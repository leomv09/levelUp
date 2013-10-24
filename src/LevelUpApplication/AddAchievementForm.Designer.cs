namespace LevelUpApplication
{
    partial class AddAchievementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAchievementForm));
            this.AchievementComboBox = new System.Windows.Forms.ComboBox();
            this.AcceptAchievementButton = new System.Windows.Forms.Button();
            this.CancelAchievementButton = new System.Windows.Forms.Button();
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
            // AcceptAchievementButton
            // 
            resources.ApplyResources(this.AcceptAchievementButton, "AcceptAchievementButton");
            this.AcceptAchievementButton.Name = "AcceptAchievementButton";
            this.AcceptAchievementButton.UseVisualStyleBackColor = true;
            this.AcceptAchievementButton.Click += new System.EventHandler(this.AcceptAchievementButton_Click);
            // 
            // CancelAchievementButton
            // 
            resources.ApplyResources(this.CancelAchievementButton, "CancelAchievementButton");
            this.CancelAchievementButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAchievementButton.Name = "CancelAchievementButton";
            this.CancelAchievementButton.UseVisualStyleBackColor = true;
            // 
            // AchievementLabel
            // 
            resources.ApplyResources(this.AchievementLabel, "AchievementLabel");
            this.AchievementLabel.Name = "AchievementLabel";
            // 
            // AddAchievementForm
            // 
            this.AcceptButton = this.AcceptAchievementButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAchievementButton;
            this.Controls.Add(this.AchievementLabel);
            this.Controls.Add(this.CancelAchievementButton);
            this.Controls.Add(this.AcceptAchievementButton);
            this.Controls.Add(this.AchievementComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddAchievementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementComboBox;
        private System.Windows.Forms.Button AcceptAchievementButton;
        private System.Windows.Forms.Button CancelAchievementButton;
        private System.Windows.Forms.Label AchievementLabel;
    }
}