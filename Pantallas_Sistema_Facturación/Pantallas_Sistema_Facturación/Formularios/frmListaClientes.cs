using Pantallas_Sistema_Facturación.RepositoriosCRUD;
using Pantallas_Sistema_Facturación.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }
        //Evento Load del formulario
        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            dgClientes.AutoGenerateColumns = false;
            CargarDataGrid();
            timer1.Interval = 10000; //10 segundos
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditarCliente")
            {
                int posicion = dgClientes.CurrentRow.Index;
                frmEditarCliente editarCliente = new frmEditarCliente();
                //Convertir el valor de la celda a entero y asignarlo a la propiedad IdCliente del formulario editarCliente
                editarCliente.IdCliente = Convert.ToInt32(dgClientes.Rows[posicion].Cells["txtDocumento"].Value);
                editarCliente.ShowDialog();
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrarCliente")
            {
                //Crear un cuadro de diálogo para confirmar la eliminación
                var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    // Lógica para eliminar el cliente
                    MessageBox.Show("Cliente eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        int documento = Convert.ToInt32(dgClientes.Rows[dgClientes.CurrentRow.Index].Cells["txtDocumento"].Value);

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
            string documento = txtBuscarCliente.Text.Trim(); //Obtener el texto y quitar espacios en blanco
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlDataAdapter datadapter = new SqlDataAdapter("SELECT DocumentoCliente, NombreCliente,Email, Direccion, Telefono FROM Clientes WHERE DocumentoCliente = @documento", conexion))
            {
                DataTable dt = new DataTable();
                datadapter.SelectCommand.Parameters.AddWithValue("@documento", documento); //Agregar el parámetro a la consulta
                datadapter.Fill(dt);
                dgClientes.AutoGenerateColumns = false;
                dgClientes.DataSource = dt;
                //Asignar las columnas del DataGridView a las propiedades de la tabla
                dgClientes.Columns["txtDocumento"].DataPropertyName = "DocumentoCliente";
                dgClientes.Columns["txtNombre"].DataPropertyName = "NombreCliente";
                dgClientes.Columns["txtTelefono"].DataPropertyName = "Telefono";
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();

            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                errorProvider1.SetError(txtBuscarCliente, "El nombre es obligatorio.");
                CargarDataGrid(); //Recargar el data grid view con todos los clientes
                hayError = true;
            }

            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void CargarDataGrid() 
        { 
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlDataAdapter datadapter = new SqlDataAdapter("SELECT DocumentoCliente, NombreCliente,Email, Direccion, Telefono FROM Clientes", conexion))
            {
                DataTable dt = new DataTable(); //Crear tabla de datos para almacenar los datos
                datadapter.Fill(dt); //Llenar la tabla con los datos obtenidos de la consulta
                dgClientes.DataSource = dt; //Asignar la tabla como origen de datos del data grid view
                //Asignar las columnas del DataGridView a las propiedades de la tabla
                dgClientes.Columns["txtDocumento"].DataPropertyName = "DocumentoCliente";
                dgClientes.Columns["txtNombre"].DataPropertyName = "NombreCliente";
                dgClientes.Columns["txtTelefono"].DataPropertyName = "Email";
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
