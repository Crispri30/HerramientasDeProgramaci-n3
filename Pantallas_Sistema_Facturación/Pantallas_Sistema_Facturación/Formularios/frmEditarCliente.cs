using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmEditarCliente : MaterialForm
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }
        public int IdCliente { get; set; }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                //Nuevo cliente
                lblEditarCliente.Text = "Nuevo Cliente";
            }
            else
            {
                //Editar cliente existente
                lblEditarCliente.Text = "Editar Cliente";
                // Cargar los datos del cliente desde la base de datos
            }
        }
        private void btnEditarSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int documento = int.Parse(txtEditarDocumento.Text);
                string nombre = txtEditarNombre.Text;
                string correo = txtEditarCorreo.Text;
                string direccion = txtEditarDireccion.Text;
                int telefono = int.Parse(txtEditarTelefono.Text);

                var repo = new RepositoriosCRUD.ClientesRepository();
                repo.EditarCliente(documento, nombre, correo, direccion, telefono);

                txtEditarDocumento.Clear();
                txtEditarNombre.Clear();
                txtEditarCorreo.Clear();
                txtEditarDireccion.Clear();
                txtEditarTelefono.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
            }
            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtEditarNombre.Text))
            {
                errorProvider1.SetError(txtEditarNombre, "El nombre es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarDocumento.Text))
            {
                errorProvider1.SetError(txtEditarDocumento, "El documento es obligatoria.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarTelefono.Text))
            {
                errorProvider1.SetError(txtEditarTelefono, "El telefono es obligatoria.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarDireccion.Text))
            {
                errorProvider1.SetError(txtEditarDireccion, "La dirección es obligatoria.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarCorreo.Text))
            {
                errorProvider1.SetError(txtEditarCorreo, "El correo es obligatorio.");
                hayError = true;
            }

            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cliente actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                int documento = int.Parse(txtEditarDocumento.Text);
                string nombre = txtEditarNombre.Text;
                string correo = txtEditarCorreo.Text;
                string direccion = txtEditarDireccion.Text;
                int telefono = int.Parse(txtEditarTelefono.Text);

                var repo = new RepositoriosCRUD.ClientesRepository();
                repo.AgregarCliente(documento, nombre, correo, direccion, telefono);

                txtEditarDocumento.Clear();
                txtEditarNombre.Clear();
                txtEditarCorreo.Clear();
                txtEditarDireccion.Clear();
                txtEditarTelefono.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }

            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtEditarNombre.Text))
            {
                errorProvider1.SetError(txtEditarNombre, "El nombre es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarDocumento.Text))
            {
                errorProvider1.SetError(txtEditarDocumento, "El documento es obligatoria.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarTelefono.Text))
            {
                errorProvider1.SetError(txtEditarTelefono, "El telefono es obligatoria.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarDireccion.Text))
            {
                errorProvider1.SetError(txtEditarDireccion, "La dirección es obligatoria.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEditarCorreo.Text))
            {
                errorProvider1.SetError(txtEditarCorreo, "El correo es obligatorio.");
                hayError = true;
            }

            //Validacion de los formatos
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cliente agregado exitosamente.", "Agregado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
