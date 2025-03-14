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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarUsuarios Titulos = new frmInsertarUsuarios();
            Titulos.Show();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select ID as ID, APATERNO as [Apellido Paterno], AMATERNO as [Apellido Materno], " +
                "NOMBRE as [Nombre], TELEFONO as [Telefono], CORREO as [Correo] FROM USUARIOS");

            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaUsuarios actualiza = new frmActualizaUsuarios(dgvUsuarios[0, e.RowIndex].Value.ToString(),
                                                  dgvUsuarios[1, e.RowIndex].Value.ToString(),
                                                  dgvUsuarios[2, e.RowIndex].Value.ToString(),
                                                  dgvUsuarios[3, e.RowIndex].Value.ToString(),
                                                  dgvUsuarios[4, e.RowIndex].Value.ToString(),
                                                  dgvUsuarios[5, e.RowIndex].Value.ToString());

            actualiza.Show();
            this.Close();
        }

        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * For USUARIOS");

            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];
            }
        }
        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
    }
}
