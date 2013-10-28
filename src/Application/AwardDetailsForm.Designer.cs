namespace LevelUp.App
{
    partial class AwardDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AwardDetailsForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.DetailTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.AwardAcceptButton = new System.Windows.Forms.Button();
            this.AwardCancelButton = new System.Windows.Forms.Button();
            this.AwardApplyButton = new System.Windows.Forms.Button();
            this.FileSelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            // 
            // PhotoPictureBox
            // 
            resources.ApplyResources(this.PhotoPictureBox, "PhotoPictureBox");
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.TabStop = false;
            // 
            // OpenFileDialog
            // 
            resources.ApplyResources(this.OpenFileDialog, "OpenFileDialog");
            // 
            // DescriptionLabel
            // 
            resources.ApplyResources(this.DescriptionLabel, "DescriptionLabel");
            this.DescriptionLabel.Name = "DescriptionLabel";
            // 
            // DescriptionTextBox
            // 
            resources.ApplyResources(this.DescriptionTextBox, "DescriptionTextBox");
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            // 
            // TypeComboBox
            // 
            resources.ApplyResources(this.TypeComboBox, "TypeComboBox");
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.TextChanged += new System.EventHandler(this.TypeComboBox_TextChanged);
            // 
            // TypeLabel
            // 
            resources.ApplyResources(this.TypeLabel, "TypeLabel");
            this.TypeLabel.Name = "TypeLabel";
            // 
            // DetailLabel
            // 
            resources.ApplyResources(this.DetailLabel, "DetailLabel");
            this.DetailLabel.Name = "DetailLabel";
            // 
            // DetailTextBox
            // 
            resources.ApplyResources(this.DetailTextBox, "DetailTextBox");
            this.DetailTextBox.Name = "DetailTextBox";
            this.DetailTextBox.ReadOnly = true;
            // 
            // CurrencyLabel
            // 
            resources.ApplyResources(this.CurrencyLabel, "CurrencyLabel");
            this.CurrencyLabel.Name = "CurrencyLabel";
            // 
            // CurrencyComboBox
            // 
            resources.ApplyResources(this.CurrencyComboBox, "CurrencyComboBox");
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            // 
            // AwardAcceptButton
            // 
            resources.ApplyResources(this.AwardAcceptButton, "AwardAcceptButton");
            this.AwardAcceptButton.Name = "AwardAcceptButton";
            this.AwardAcceptButton.UseVisualStyleBackColor = true;
            this.AwardAcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AwardCancelButton
            // 
            resources.ApplyResources(this.AwardCancelButton, "AwardCancelButton");
            this.AwardCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AwardCancelButton.Name = "AwardCancelButton";
            this.AwardCancelButton.UseVisualStyleBackColor = true;
            this.AwardCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AwardApplyButton
            // 
            resources.ApplyResources(this.AwardApplyButton, "AwardApplyButton");
            this.AwardApplyButton.Name = "AwardApplyButton";
            this.AwardApplyButton.UseVisualStyleBackColor = true;
            this.AwardApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FileSelectButton
            // 
            resources.ApplyResources(this.FileSelectButton, "FileSelectButton");
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // AwardDetailsForm
            // 
            this.AcceptButton = this.AwardAcceptButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AwardCancelButton;
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.AwardApplyButton);
            this.Controls.Add(this.AwardCancelButton);
            this.Controls.Add(this.AwardAcceptButton);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.DetailTextBox);
            this.Controls.Add(this.DetailLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AwardDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DetailLabel;
        private System.Windows.Forms.TextBox DetailTextBox;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.Button AwardAcceptButton;
        private System.Windows.Forms.Button AwardCancelButton;
        private System.Windows.Forms.Button AwardApplyButton;
        private System.Windows.Forms.Button FileSelectButton;
    }
}