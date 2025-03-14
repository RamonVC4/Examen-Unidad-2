using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Unidad_2
{
    public partial class frmInsertarUsuarios : Form
    {
        public frmInsertarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool f = datos.comando("insert into USUARIOS values ('" + txtAPaterno.Text+ "','" + 
                    txtAMaterno.Text + "','" + txtNombre.Text + "','" + txtTelefono.Text + "','" + 
                    txtCorreo.Text + "');");

                if (f == true)
                {
                    MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmUsuarios titulos = new frmUsuarios();
                    titulos.Show();
                }
                else
                {
                    MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error al insertar. Favor de verificar los tipos de datos ingresados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
