namespace LevelUpApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DepartamentoReglaLabel = new System.Windows.Forms.Label();
            this.DepartamentoReglaComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReglaGrid = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TapControl = new System.Windows.Forms.TabControl();
            this.Reglas = new System.Windows.Forms.TabPage();
            this.Logros = new System.Windows.Forms.TabPage();
            this.AgregarReglaButton = new System.Windows.Forms.Button();
            this.EliminarReglaButton = new System.Windows.Forms.Button();
            this.ModificarReglaButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReglaGrid)).BeginInit();
            this.TapControl.SuspendLayout();
            this.Reglas.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartamentoReglaLabel
            // 
            this.DepartamentoReglaLabel.AutoSize = true;
            this.DepartamentoReglaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartamentoReglaLabel.Location = new System.Drawing.Point(16, 10);
            this.DepartamentoReglaLabel.Name = "DepartamentoReglaLabel";
            this.DepartamentoReglaLabel.Size = new System.Drawing.Size(94, 16);
            this.DepartamentoReglaLabel.TabIndex = 0;
            this.DepartamentoReglaLabel.Text = "Departamento";
            // 
            // DepartamentoReglaComboBox
            // 
            this.DepartamentoReglaComboBox.FormattingEnabled = true;
            this.DepartamentoReglaComboBox.Location = new System.Drawing.Point(16, 29);
            this.DepartamentoReglaComboBox.Name = "DepartamentoReglaComboBox";
            this.DepartamentoReglaComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartamentoReglaComboBox.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(766, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // ReglaGrid
            // 
            this.ReglaGrid.AllowUserToDeleteRows = false;
            this.ReglaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReglaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReglaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.FechaInicio,
            this.FechaFinal});
            this.ReglaGrid.Location = new System.Drawing.Point(3, 70);
            this.ReglaGrid.MultiSelect = false;
            this.ReglaGrid.Name = "ReglaGrid";
            this.ReglaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReglaGrid.Size = new System.Drawing.Size(748, 426);
            this.ReglaGrid.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // FechaFinal
            // 
            this.FechaFinal.HeaderText = "Fecha de Finalización";
            this.FechaFinal.Name = "FechaFinal";
            // 
            // TapControl
            // 
            this.TapControl.Controls.Add(this.Reglas);
            this.TapControl.Controls.Add(this.Logros);
            this.TapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TapControl.Location = new System.Drawing.Point(0, 24);
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(766, 537);
            this.TapControl.TabIndex = 4;
            // 
            // Reglas
            // 
            this.Reglas.Controls.Add(this.ModificarReglaButton);
            this.Reglas.Controls.Add(this.EliminarReglaButton);
            this.Reglas.Controls.Add(this.AgregarReglaButton);
            this.Reglas.Controls.Add(this.DepartamentoReglaComboBox);
            this.Reglas.Controls.Add(this.ReglaGrid);
            this.Reglas.Controls.Add(this.DepartamentoReglaLabel);
            this.Reglas.Location = new System.Drawing.Point(4, 22);
            this.Reglas.Name = "Reglas";
            this.Reglas.Padding = new System.Windows.Forms.Padding(3);
            this.Reglas.Size = new System.Drawing.Size(758, 511);
            this.Reglas.TabIndex = 0;
            this.Reglas.Text = "Reglas";
            this.Reglas.UseVisualStyleBackColor = true;
            // 
            // Logros
            // 
            this.Logros.Location = new System.Drawing.Point(4, 22);
            this.Logros.Name = "Logros";
            this.Logros.Padding = new System.Windows.Forms.Padding(3);
            this.Logros.Size = new System.Drawing.Size(755, 474);
            this.Logros.TabIndex = 1;
            this.Logros.Text = "Logros";
            this.Logros.UseVisualStyleBackColor = true;
            // 
            // AgregarReglaButton
            // 
            this.AgregarReglaButton.Location = new System.Drawing.Point(493, 10);
            this.AgregarReglaButton.Name = "AgregarReglaButton";
            this.AgregarReglaButton.Size = new System.Drawing.Size(75, 40);
            this.AgregarReglaButton.TabIndex = 4;
            this.AgregarReglaButton.Text = "Agregar";
            this.AgregarReglaButton.UseVisualStyleBackColor = true;
            // 
            // EliminarReglaButton
            // 
            this.EliminarReglaButton.Location = new System.Drawing.Point(574, 10);
            this.EliminarReglaButton.Name = "EliminarReglaButton";
            this.EliminarReglaButton.Size = new System.Drawing.Size(75, 40);
            this.EliminarReglaButton.TabIndex = 5;
            this.EliminarReglaButton.Text = "Eliminar";
            this.EliminarReglaButton.UseVisualStyleBackColor = true;
            // 
            // ModificarReglaButton
            // 
            this.ModificarReglaButton.Location = new System.Drawing.Point(655, 10);
            this.ModificarReglaButton.Name = "ModificarReglaButton";
            this.ModificarReglaButton.Size = new System.Drawing.Size(75, 40);
            this.ModificarReglaButton.TabIndex = 6;
            this.ModificarReglaButton.Text = "Modificar";
            this.ModificarReglaButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 561);
            this.Controls.Add(this.TapControl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Level Up";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReglaGrid)).EndInit();
            this.TapControl.ResumeLayout(false);
            this.Reglas.ResumeLayout(false);
            this.Reglas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DepartamentoReglaLabel;
        private System.Windows.Forms.ComboBox DepartamentoReglaComboBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.DataGridView ReglaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.TabControl TapControl;
        private System.Windows.Forms.TabPage Reglas;
        private System.Windows.Forms.TabPage Logros;
        private System.Windows.Forms.Button AgregarReglaButton;
        private System.Windows.Forms.Button ModificarReglaButton;
        private System.Windows.Forms.Button EliminarReglaButton;
    }
}

