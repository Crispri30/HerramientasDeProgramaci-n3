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

namespace Pantallas_Sistema_Facturación
{
    public partial class frmEmpleados : MaterialForm
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;

            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                errorProvider1.SetError(txtNombreEmpleado, "El nombre es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtDocumentoEmpleado.Text))
            {
                errorProvider1.SetError(txtDocumentoEmpleado, "El documento es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtDirecciónEmpleado.Text))
            {
                errorProvider1.SetError(txtDirecciónEmpleado, "La dirección es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEmailEmpleado.Text))
            {
                errorProvider1.SetError(txtEmailEmpleado, "El email es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtTelefonoEmpleado.Text))
            {
                errorProvider1.SetError(txtTelefonoEmpleado, "El telefono es obligatorio.");
                hayError = true;
            }
            if (cmbRolEmpleado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRolEmpleado, "El rol es obligatorio.");
                hayError = true;
            }


            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Empleado actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
