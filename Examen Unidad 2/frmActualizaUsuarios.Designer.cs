namespace Examen_Unidad_2
{
    partial class frmActualizaUsuarios
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtID = new TextBox();
            txtAPaterno = new TextBox();
            label3 = new Label();
            txtAMaterno = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtCorreo = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            btnActualizar = new Button();
            pictureBox1 = new PictureBox();
            txtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(294, 20);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 0;
            label1.Text = "Tabla: Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(26, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 10);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(26, 130);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(150, 27);
            txtID.TabIndex = 3;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(26, 200);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(250, 27);
            txtAPaterno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 4;
            label3.Text = "Apellido Paterno";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(294, 200);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(250, 27);
            txtAMaterno.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(294, 169);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(550, 200);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(550, 169);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 250);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 10;
            label6.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(213, 288);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(331, 27);
            txtCorreo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(213, 250);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 12;
            label7.Text = "Correo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(26, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 10);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F);
            button1.Location = new Point(240, 363);
            button1.Name = "button1";
            button1.Size = new Size(161, 43);
            button1.TabIndex = 14;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 16.2F);
            btnActualizar.Location = new Point(407, 363);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(161, 43);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fenix;
            pictureBox1.Location = new Point(714, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(26, 281);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 27);
            txtTelefono.TabIndex = 17;
            // 
            // frmActualizaUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 450);
            Controls.Add(txtTelefono);
            Controls.Add(pictureBox1);
            Controls.Add(btnActualizar);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(txtAMaterno);
            Controls.Add(label4);
            Controls.Add(txtAPaterno);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmActualizaUsuarios";
            Text = "Actualizar";
            Load += frmActualizaUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtAPaterno;
        private Label label3;
        private TextBox txtAMaterno;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private Label label6;
        private TextBox txtCorreo;
        private Label label7;
        private Panel panel2;
        private Button button1;
        private Button btnActualizar;
        private PictureBox pictureBox1;
        private TextBox txtTelefono;
    }
}