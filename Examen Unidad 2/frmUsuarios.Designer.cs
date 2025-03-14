namespace Examen_Unidad_2
{
    partial class frmUsuarios
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
            menuStrip1 = new MenuStrip();
            tablaUsuariosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dgvUsuarios = new DataGridView();
            panel2 = new Panel();
            btnInsertar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablaUsuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(850, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablaUsuariosToolStripMenuItem
            // 
            tablaUsuariosToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            tablaUsuariosToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 64);
            tablaUsuariosToolStripMenuItem.Name = "tablaUsuariosToolStripMenuItem";
            tablaUsuariosToolStripMenuItem.Size = new Size(228, 42);
            tablaUsuariosToolStripMenuItem.Text = "Tabla: Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 10);
            panel1.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 65);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(819, 267);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(12, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(823, 10);
            panel2.TabIndex = 2;
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(298, 354);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(266, 47);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 417);
            Controls.Add(btnInsertar);
            Controls.Add(panel2);
            Controls.Add(dgvUsuarios);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUsuarios";
            Text = "Usuarios";
            Activated += frmUsuarios_Activated;
            Load += frmUsuarios_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tablaUsuariosToolStripMenuItem;
        private Panel panel1;
        private DataGridView dgvUsuarios;
        private Panel panel2;
        private Button btnInsertar;
    }
}