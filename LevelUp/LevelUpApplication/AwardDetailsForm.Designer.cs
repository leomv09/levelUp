namespace LevelUpApplication
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
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 24);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nombre";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 43);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(247, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Location = new System.Drawing.Point(278, 24);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(150, 126);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoPictureBox.TabIndex = 2;
            this.PhotoPictureBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 85);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(80, 16);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Descripcion";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(15, 104);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(244, 96);
            this.DescriptionTextBox.TabIndex = 4;
            this.DescriptionTextBox.Text = "";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Enabled = false;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(15, 242);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(244, 21);
            this.TypeComboBox.TabIndex = 5;
            this.TypeComboBox.TextChanged += new System.EventHandler(this.TypeComboBox_TextChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(12, 223);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(36, 16);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Tipo";
            // 
            // DetailLabel
            // 
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabel.Location = new System.Drawing.Point(275, 223);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(51, 16);
            this.DetailLabel.TabIndex = 7;
            this.DetailLabel.Text = "Detalle";
            this.DetailLabel.Visible = false;
            // 
            // DetailTextBox
            // 
            this.DetailTextBox.Location = new System.Drawing.Point(278, 243);
            this.DetailTextBox.Name = "DetailTextBox";
            this.DetailTextBox.ReadOnly = true;
            this.DetailTextBox.Size = new System.Drawing.Size(144, 20);
            this.DetailTextBox.TabIndex = 8;
            this.DetailTextBox.Visible = false;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel.Location = new System.Drawing.Point(12, 282);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(58, 16);
            this.CurrencyLabel.TabIndex = 9;
            this.CurrencyLabel.Text = "Moneda";
            this.CurrencyLabel.Visible = false;
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.Enabled = false;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(12, 301);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(248, 21);
            this.CurrencyComboBox.TabIndex = 10;
            this.CurrencyComboBox.Visible = false;
            // 
            // AwardAcceptButton
            // 
            this.AwardAcceptButton.Location = new System.Drawing.Point(191, 345);
            this.AwardAcceptButton.Name = "AwardAcceptButton";
            this.AwardAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AwardAcceptButton.TabIndex = 11;
            this.AwardAcceptButton.Text = "Aceptar";
            this.AwardAcceptButton.UseVisualStyleBackColor = true;
            this.AwardAcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AwardCancelButton
            // 
            this.AwardCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AwardCancelButton.Location = new System.Drawing.Point(353, 345);
            this.AwardCancelButton.Name = "AwardCancelButton";
            this.AwardCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AwardCancelButton.TabIndex = 12;
            this.AwardCancelButton.Text = "Cancelar";
            this.AwardCancelButton.UseVisualStyleBackColor = true;
            this.AwardCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AwardApplyButton
            // 
            this.AwardApplyButton.Enabled = false;
            this.AwardApplyButton.Location = new System.Drawing.Point(272, 345);
            this.AwardApplyButton.Name = "AwardApplyButton";
            this.AwardApplyButton.Size = new System.Drawing.Size(75, 23);
            this.AwardApplyButton.TabIndex = 13;
            this.AwardApplyButton.Text = "Aplicar";
            this.AwardApplyButton.UseVisualStyleBackColor = true;
            this.AwardApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Enabled = false;
            this.FileSelectButton.Location = new System.Drawing.Point(278, 156);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(150, 23);
            this.FileSelectButton.TabIndex = 14;
            this.FileSelectButton.Text = "Selecionar Imagen";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // AwardDetailsForm
            // 
            this.AcceptButton = this.AwardAcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AwardCancelButton;
            this.ClientSize = new System.Drawing.Size(442, 391);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AwardDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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