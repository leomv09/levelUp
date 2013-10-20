namespace LevelUpApplication
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
            this.SuspendLayout();
            // 
            // AwardComboBox
            // 
            this.AwardComboBox.FormattingEnabled = true;
            this.AwardComboBox.Location = new System.Drawing.Point(12, 7);
            this.AwardComboBox.Name = "AwardComboBox";
            this.AwardComboBox.Size = new System.Drawing.Size(373, 21);
            this.AwardComboBox.TabIndex = 1;
            this.AwardComboBox.SelectionChangeCommitted += new System.EventHandler(this.AwardComboBox_SelectionChangeCommitted);
            // 
            // CancelAwardButton
            // 
            this.CancelAwardButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAwardButton.Location = new System.Drawing.Point(310, 39);
            this.CancelAwardButton.Name = "CancelAwardButton";
            this.CancelAwardButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAwardButton.TabIndex = 4;
            this.CancelAwardButton.Text = "Cancelar";
            this.CancelAwardButton.UseVisualStyleBackColor = true;
            // 
            // AcceptAwardButton
            // 
            this.AcceptAwardButton.Location = new System.Drawing.Point(229, 39);
            this.AcceptAwardButton.Name = "AcceptAwardButton";
            this.AcceptAwardButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptAwardButton.TabIndex = 3;
            this.AcceptAwardButton.Text = "Aceptar";
            this.AcceptAwardButton.UseVisualStyleBackColor = true;
            this.AcceptAwardButton.Click += new System.EventHandler(this.AcceptAwardButton_Click);
            // 
            // AddAwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 74);
            this.Controls.Add(this.CancelAwardButton);
            this.Controls.Add(this.AcceptAwardButton);
            this.Controls.Add(this.AwardComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAwardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox AwardComboBox;
        private System.Windows.Forms.Button CancelAwardButton;
        private System.Windows.Forms.Button AcceptAwardButton;
    }
}