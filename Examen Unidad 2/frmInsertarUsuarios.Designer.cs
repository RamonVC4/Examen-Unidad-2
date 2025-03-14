namespace Examen_Unidad_2
{
    partial class frmInsertarUsuarios
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
            button1 = new Button();
            panel2 = new Panel();
            txtCorreo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtAMaterno = new TextBox();
            label4 = new Label();
            txtAPaterno = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F);
            button1.Location = new Point(347, 296);
            button1.Name = "button1";
            button1.Size = new Size(161, 48);
            button1.TabIndex = 30;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(10, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 10);
            panel2.TabIndex = 18;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(195, 231);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(331, 27);
            txtCorreo.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(195, 193);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 28;
            label7.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 193);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 26;
            label6.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(532, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(532, 112);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 24;
            label5.Text = "Nombre";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(276, 143);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(250, 27);
            txtAMaterno.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(276, 112);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 22;
            label4.Text = "Apellido Materno";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(8, 143);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(250, 27);
            txtAPaterno.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 112);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 20;
            label3.Text = "Apellido Paterno";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Location = new Point(10, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 10);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(278, 26);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 16;
            label1.Text = "Tabla: Usuarios";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(10, 231);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 27);
            txtTelefono.TabIndex = 31;
            // 
            // frmInsertarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(txtTelefono);
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
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmInsertarUsuarios";
            Text = "Insertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel2;
        private TextBox txtCorreo;
        private Label label7;
        private Label label6;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtAMaterno;
        private Label label4;
        private TextBox txtAPaterno;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private TextBox txtTelefono;
    }
}