namespace LevelUpApplication
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
            this.SuspendLayout();
            // 
            // AchievementComboBox
            // 
            this.AchievementComboBox.FormattingEnabled = true;
            this.AchievementComboBox.Location = new System.Drawing.Point(12, 7);
            this.AchievementComboBox.Name = "AchievementComboBox";
            this.AchievementComboBox.Size = new System.Drawing.Size(373, 21);
            this.AchievementComboBox.TabIndex = 1;
            this.AchievementComboBox.SelectionChangeCommitted += new System.EventHandler(this.AchievementComboBox_SelectionChangeCommitted);
            // 
            // CancelAchievementButton
            // 
            this.CancelAchievementButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAchievementButton.Location = new System.Drawing.Point(310, 93);
            this.CancelAchievementButton.Name = "CancelAchievementButton";
            this.CancelAchievementButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAchievementButton.TabIndex = 4;
            this.CancelAchievementButton.Text = "Cancelar";
            this.CancelAchievementButton.UseVisualStyleBackColor = true;
            // 
            // AcceptAchievementButton
            // 
            this.AcceptAchievementButton.Location = new System.Drawing.Point(229, 93);
            this.AcceptAchievementButton.Name = "AcceptAchievementButton";
            this.AcceptAchievementButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptAchievementButton.TabIndex = 3;
            this.AcceptAchievementButton.Text = "Aceptar";
            this.AcceptAchievementButton.UseVisualStyleBackColor = true;
            this.AcceptAchievementButton.Click += new System.EventHandler(this.AcceptAchievementButton_Click);
            // 
            // DetailTextBox
            // 
            this.DetailTextBox.Location = new System.Drawing.Point(12, 59);
            this.DetailTextBox.Name = "DetailTextBox";
            this.DetailTextBox.Size = new System.Drawing.Size(372, 20);
            this.DetailTextBox.TabIndex = 5;
            this.DetailTextBox.TextChanged += new System.EventHandler(this.DetailTextBox_TextChanged);
            // 
            // DetailLabel
            // 
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabel.Location = new System.Drawing.Point(12, 40);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(51, 16);
            this.DetailLabel.TabIndex = 6;
            this.DetailLabel.Text = "Detalle";
            // 
            // AddAchievementPerUserForm
            // 
            this.AcceptButton = this.AcceptAchievementButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAchievementButton;
            this.ClientSize = new System.Drawing.Size(397, 128);
            this.Controls.Add(this.DetailLabel);
            this.Controls.Add(this.DetailTextBox);
            this.Controls.Add(this.CancelAchievementButton);
            this.Controls.Add(this.AcceptAchievementButton);
            this.Controls.Add(this.AchievementComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AddAchievementPerUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AchievementComboBox;
        private System.Windows.Forms.Button CancelAchievementButton;
        private System.Windows.Forms.Button AcceptAchievementButton;
        private System.Windows.Forms.TextBox DetailTextBox;
        private System.Windows.Forms.Label DetailLabel;
    }
}