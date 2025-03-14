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
    public partial class frmActualizaUsuarios : Form
    {
        public frmActualizaUsuarios(string ID, string APaterno, string AMaterno,
                                    string Nombre, string Telefono, string correo)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtAPaterno.Text = APaterno;
            txtAMaterno.Text = AMaterno;
            txtNombre.Text = Nombre;
            txtTelefono.Text = Telefono;
            txtCorreo.Text = correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from USUARIOS where ID = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmUsuarios usuarios = new frmUsuarios();
                    usuarios.Show();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmActualizaUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string correo = "";
                string telefono = "";

                if (txtCorreo.Text.Length == 0)
                {
                    correo = "NULL";
                }
                else
                {
                    correo = "'" + txtCorreo.Text + "'";
                }

                Datos datos = new Datos();
                bool f = datos.comando("UPDATE usuarios " +
                                       "SET APATERNO = '" + txtAPaterno.Text +
                                       "', AMATERNO = '" + txtAMaterno.Text +
                                       "', NOMBRE = '" + txtNombre.Text +
                                       "', TELEFONO = " + txtTelefono.Text +
                                       ", CORREO = " + correo +
                                       " WHERE ID = " + txtID.Text);

                if (f == true)
                {
                    MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Alguno de los datos en inconsistente, favor de revisar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
