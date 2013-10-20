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
            this.SuspendLayout();
            // 
            // AchievementComboBox
            // 
            this.AchievementComboBox.FormattingEnabled = true;
            this.AchievementComboBox.Location = new System.Drawing.Point(12, 7);
            this.AchievementComboBox.Name = "AchievementComboBox";
            this.AchievementComboBox.Size = new System.Drawing.Size(373, 21);
            this.AchievementComboBox.TabIndex = 0;
            this.AchievementComboBox.SelectionChangeCommitted += new System.EventHandler(this.AchievementComboBox_SelectionChangeCommitted);
            // 
            // AcceptAchievementButton
            // 
            this.AcceptAchievementButton.Location = new System.Drawing.Point(229, 39);
            this.AcceptAchievementButton.Name = "AcceptAchievementButton";
            this.AcceptAchievementButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptAchievementButton.TabIndex = 1;
            this.AcceptAchievementButton.Text = "Aceptar";
            this.AcceptAchievementButton.UseVisualStyleBackColor = true;
            this.AcceptAchievementButton.Click += new System.EventHandler(this.AcceptAchievementButton_Click);
            // 
            // CancelAchievementButton
            // 
            this.CancelAchievementButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAchievementButton.Location = new System.Drawing.Point(310, 39);
            this.CancelAchievementButton.Name = "CancelAchievementButton";
            this.CancelAchievementButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAchievementButton.TabIndex = 2;
            this.CancelAchievementButton.Text = "Cancelar";
            this.CancelAchievementButton.UseVisualStyleBackColor = true;
            // 
            // AddAchievementForm
            // 
            this.AcceptButton = this.AcceptAchievementButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAchievementButton;
            this.ClientSize = new System.Drawing.Size(397, 74);
            this.Controls.Add(this.CancelAchievementButton);
            this.Controls.Add(this.AcceptAchievementButton);
            this.Controls.Add(this.AchievementComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAchievementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementComboBox;
        private System.Windows.Forms.Button AcceptAchievementButton;
        private System.Windows.Forms.Button CancelAchievementButton;
    }
}