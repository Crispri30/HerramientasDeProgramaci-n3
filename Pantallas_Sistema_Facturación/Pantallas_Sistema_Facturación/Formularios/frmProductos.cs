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
    public partial class frmProductos : MaterialForm
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errorProvider1.SetError(txtNombreProducto, "El nombre es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtCodigoReferencia.Text))
            {
                errorProvider1.SetError(txtCodigoReferencia, "El código es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                errorProvider1.SetError(txtPrecioCompra, "El precio de compra es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                errorProvider1.SetError(txtPrecioVenta, "El precio de venta es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtCantidadStock.Text))
            {
                errorProvider1.SetError(txtCantidadStock, "La cantidad en Stock obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtRutaImagen.Text))
            {
                errorProvider1.SetError(txtRutaImagen, "El ruta de imagen obligatorio.");
                hayError = true;
            }
            if(cmbCategorias.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCategorias, "La categoría es obligatoria.");
                hayError = true;
            }
            if (dgProductos.Rows.Count == 0)
            {
                errorProvider1.SetError(dgProductos, "El data grid view no puede estar vacío.");
                hayError = true;
            }

            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Rol actualizado exitosamente.", "Actualizado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}