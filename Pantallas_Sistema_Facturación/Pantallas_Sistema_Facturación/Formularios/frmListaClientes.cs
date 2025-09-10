using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pantallas_Sistema_Facturación.RepositoriosCRUD;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditarCliente")
            {
                int posicion = dgClientes.CurrentRow.Index;
                frmEditarCliente editarCliente = new frmEditarCliente();
                //Convertir el valor de la celda a entero y asignarlo a la propiedad IdCliente del formulario editarCliente
                editarCliente.IdCliente = Convert.ToInt32(dgClientes.Rows[posicion].Cells["txtID"].Value);
                editarCliente.ShowDialog();
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEliminarCliente")
            {
                //Crear un cuadro de diálogo para confirmar la eliminación
                var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    // Lógica para eliminar el cliente
                    MessageBox.Show("Cliente eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        int documento = Convert.ToInt32(dgClientes.Rows[dgClientes.CurrentRow.Index].Cells["txtID"].Value);

                        var repo = new ClientesRepository();
                        repo.EliminarCliente(documento);


                    }
                    catch (Exception ex)
                    {
                        materialLabel1.Text = "Error al eliminar el cliente: " + ex.Message;
                    }
                }
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmEditarCliente editarCliente = new frmEditarCliente();
            editarCliente.IdCliente = 0; // Indica que es un nuevo cliente
            editarCliente.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                errorProvider1.SetError(txtBuscarCliente, "El nombre es obligatorio.");
                hayError = true;
            }
           if (dgClientes.Rows.Count == 1)
            {
                errorProvider1.SetError(dgClientes, "El data grid view no puede estar vacío.");
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
