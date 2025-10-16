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
using Datos;

namespace Presentacion
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

                var repo = new Datos.RepositoriosCRUD.UsuariosRepository();
                bool logincorrecto = repo.ValidarLogin(usuario, clave);
                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.Show();

                if (logincorrecto)
                {
                    MessageBox.Show($"¡Bienvenido {usuario}!");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Inténtelo de nuevo.");
                    this.Show();
                }
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
