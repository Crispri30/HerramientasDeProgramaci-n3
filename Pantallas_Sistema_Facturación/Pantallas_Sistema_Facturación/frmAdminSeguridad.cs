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
    public partial class frmAdminSeguridad : MaterialForm
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
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
            if (cmbEmpleado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEmpleado, "El empleado es obligatorio.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Empleado actualizado exitosamente.", "Actualizado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
