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
    public partial class frmInformes : MaterialForm
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;
            if (cmbSeleccionarinforme.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbSeleccionarinforme, "Debe seleccionar un informe.");
                hayError = true;
            }
            if (cmbOrdenar.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOrdenar, "Debe ordenar el informe.");
                hayError = true;
            }
            if (dgInformes.Rows.Count == 0)
            {
                errorProvider1.SetError(dgInformes, "El data grid view no puede estar vacío.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Informe generado exitosamente.", "Informe exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
