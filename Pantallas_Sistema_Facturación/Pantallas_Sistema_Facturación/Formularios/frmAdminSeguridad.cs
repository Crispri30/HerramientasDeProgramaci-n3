using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Pantallas_Sistema_Facturación.Utilidades;
using System.Data.SqlClient;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmAdminSeguridad : MaterialForm
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();

        }
        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }
        private void CargarUsuario()
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("SELECT Documento,Usuario FROM Usuarios", conexion))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbUsuario.Items.Add(new
                    {
                        Documento = reader.GetInt32(0),
                        Usuario = reader.GetString(1)
                    });
                }
            }
            cmbUsuario.DisplayMember = "Usuario";
            cmbUsuario.ValueMember = "Documento";
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string clave = txtClave.Text.Trim();
                int documento = Convert.ToInt32(cmbUsuario.SelectedValue); // Obtener el valor seleccionado del ComboBox

                var repo = new RepositoriosCRUD.UsuariosRepository();
                repo.EditarUsuario(documento, usuario, clave);

                MessageBox.Show("Empleado actualizado exitosamente " + usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "El usuario es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                errorProvider1.SetError(txtClave, "La contraseña es obligatoria.");
                hayError = true;
            }
            if (cmbUsuario.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbUsuario, "El empleado es obligatorio.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
