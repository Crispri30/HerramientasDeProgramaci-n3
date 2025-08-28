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
    public partial class FrmFacturas : MaterialForm
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void btnActualizarFactura_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;

            if (string.IsNullOrWhiteSpace(txtNroFactura.Text))
            {
                errorProvider1.SetError(txtNroFactura, "El número de factura es obligatorio.");
                hayError = true;
            }
            if (cmbCliente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCliente, "El cliente es obligatorio.");
                hayError = true;
            }
            if (cmbEmpleado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEmpleado, "El empleado es obligatorio.");
                hayError = true;
            }
            if (cmbEstadoFactura.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEstadoFactura, "El estado de la factura es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                errorProvider1.SetError(txtDescuento, "El descuento es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtTotalFactura.Text))
            {
                errorProvider1.SetError(txtTotalFactura, "El total de la factura es obligatorio.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtTotalIVA.Text))
            {
                errorProvider1.SetError(txtTotalIVA, "El total del iva es obligatorio.");
                hayError = true;
            }
            if (dgDetalleFactura.Rows.Count == 0)
            {
                errorProvider1.SetError(dgDetalleFactura, "El data grid view no puede estar vacío.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cliente actualizado exitosamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}