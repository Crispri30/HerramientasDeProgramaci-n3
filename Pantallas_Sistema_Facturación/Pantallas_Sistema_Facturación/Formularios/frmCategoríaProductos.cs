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
    public partial class frmCategoríaProductos : MaterialForm
    {
        public frmCategoríaProductos()
        {
            InitializeComponent();
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                errorProvider1.SetError(txtNombreCategoria, "El nombre es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtBusquedaCategoria.Text))
            {
                errorProvider1.SetError(txtBusquedaCategoria, "La busqueda obligatoria.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
