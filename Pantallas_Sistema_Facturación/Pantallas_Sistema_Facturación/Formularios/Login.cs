using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pantallas_Sistema_Facturación.Utilidades;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try 
            {
                string usuario = txtUsuario.Text.Trim();
                string clave = txtContrasena.Text.Trim();

                var repo = new RepositoriosCRUD.UsuariosRepository();
                repo.ValidarLogin(usuario, clave);
                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }

        }
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
    }
}
