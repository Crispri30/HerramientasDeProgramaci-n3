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
using Datos;

namespace Presentacion
{
    public partial class frmRolEmpleado : MaterialForm
    {
        public frmRolEmpleado()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                errorProvider1.SetError(txtNombreRol, "El rol es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcionRol.Text))
            {
                errorProvider1.SetError(txtDescripcionRol, "La descripción es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtBusquedaRol.Text))
            {
                errorProvider1.SetError(txtBusquedaRol, "La busqueda es obligatorio.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Rol actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}