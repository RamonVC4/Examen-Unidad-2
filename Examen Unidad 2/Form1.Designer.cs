namespace Examen_Unidad_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnUsuarios = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(97, 447);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 13);
            label3.Name = "label3";
            label3.Size = new Size(39, 418);
            label3.TabIndex = 4;
            label3.Text = "G\r\nR\r\nU\r\nP\r\nO\r\n\r\nF\r\nE\r\nN\r\nI\r\nX";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(115, 145);
            label4.Name = "label4";
            label4.Size = new Size(262, 38);
            label4.TabIndex = 12;
            label4.Text = "Tablas disponibles:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Location = new Point(115, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(675, 10);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(293, 88);
            label2.Name = "label2";
            label2.Size = new Size(339, 41);
            label2.TabIndex = 11;
            label2.Text = "Base de Datos: Agenda";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.ForeColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(115, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 10);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(115, 12);
            label1.Name = "label1";
            label1.Size = new Size(690, 60);
            label1.TabIndex = 8;
            label1.Text = "Administrador de Base de Datos";
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(359, 227);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(176, 62);
            btnUsuarios.TabIndex = 13;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fenix;
            pictureBox1.Location = new Point(670, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 452);
            Controls.Add(pictureBox1);
            Controls.Add(btnUsuarios);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button btnUsuarios;
        private PictureBox pictureBox1;
    }
}
