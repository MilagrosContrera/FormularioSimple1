using FormularioSimple1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioSimple1
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexion dataAccess = new Conexion();

            string servidor = txtServidor.Text;
            string usuario = txtUsuario.Text;
            string bd = txtBaseDeDatos.Text;
            string contrasena = txtContraseña.Text;

            string cadena = $"Server={servidor}; Database={bd}; User= {usuario}; Password={contrasena};";

           if (dataAccess.IntentoDeConexion(cadena))
            {
               dgvDatos.DataSource = dataAccess.ObtenerDatos(cadena);
            }
           else
            {
                MessageBox.Show("No se pudo establecer la conexión");
            }
        }
    }
}
