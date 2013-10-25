namespace LevelUp.App
{
    partial class AddAwardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAwardForm));
            this.AwardComboBox = new System.Windows.Forms.ComboBox();
            this.CancelAwardButton = new System.Windows.Forms.Button();
            this.AcceptAwardButton = new System.Windows.Forms.Button();
            this.AwardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AwardComboBox
            // 
            resources.ApplyResources(this.AwardComboBox, "AwardComboBox");
            this.AwardComboBox.FormattingEnabled = true;
            this.AwardComboBox.Name = "AwardComboBox";
            this.AwardComboBox.SelectionChangeCommitted += new System.EventHandler(this.AwardComboBox_SelectionChangeCommitted);
            // 
            // CancelAwardButton
            // 
            resources.ApplyResources(this.CancelAwardButton, "CancelAwardButton");
            this.CancelAwardButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAwardButton.Name = "CancelAwardButton";
            this.CancelAwardButton.UseVisualStyleBackColor = true;
            // 
            // AcceptAwardButton
            // 
            resources.ApplyResources(this.AcceptAwardButton, "AcceptAwardButton");
            this.AcceptAwardButton.Name = "AcceptAwardButton";
            this.AcceptAwardButton.UseVisualStyleBackColor = true;
            this.AcceptAwardButton.Click += new System.EventHandler(this.AcceptAwardButton_Click);
            // 
            // AwardLabel
            // 
            resources.ApplyResources(this.AwardLabel, "AwardLabel");
            this.AwardLabel.Name = "AwardLabel";
            // 
            // AddAwardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AwardLabel);
            this.Controls.Add(this.CancelAwardButton);
            this.Controls.Add(this.AcceptAwardButton);
            this.Controls.Add(this.AwardComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "AddAwardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AwardComboBox;
        private System.Windows.Forms.Button CancelAwardButton;
        private System.Windows.Forms.Button AcceptAwardButton;
        private System.Windows.Forms.Label AwardLabel;
    }
}