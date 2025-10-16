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
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Presentacion
{
    public partial class frmProductos : MaterialForm
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        private void frmProductos_load(object sender, EventArgs e)
        {
            CargarDataGrid();
            CargarCategorias();
            timer1.Interval = 10000; // Intervalo de 10 segundos (10000 milisegundos)
            timer1.Tick += Timer1_Tick; // Suscribirse al evento Tick
            timer1.Start();

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarDataGrid();
        }
        private void CargarDataGrid()
        {
            var conexion = Datos.Utilidades.ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT CodigoCat, NombreProducto, PrecioCompra, PrecioVenta, Categoria, CantStock FROM Productos", conexion))
            {
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgProductos.DataSource = dt;
            }
            Datos.Utilidades.ConexionBD.ObtenerInstancia().CerrarConexion();
        }
        private void CargarCategorias()
        {
            var conexion = Datos.Utilidades.ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT CodigoCat, Nombre FROM Categorias", conexion))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategorias.DataSource = dt;
                cmbCategorias.DisplayMember = "Nombre";
                cmbCategorias.ValueMember = "CodigoCat";
            }

            Datos.Utilidades.ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigoReferencia.Text.Trim());
                string nombre = txtNombreProducto.Text.Trim();
                int preciocompra = Convert.ToInt32(txtPrecioCompra.Text.Trim());
                int precioventa = Convert.ToInt32(txtPrecioVenta.Text.Trim());
                int cantstock = Convert.ToInt32(txtCantidadStock.Text.Trim());
                int categoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                var repo = new Datos.RepositoriosCRUD.ProductosRepository();
                repo.ActualizarProducto(codigo, nombre, preciocompra, precioventa, categoria, cantstock);
                MessageBox.Show("Producto actualizado exitosamente: " + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }

            CargarDataGrid();
            CargarCategorias();

            /* errorProvider1.Clear();
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
               */
        }

        private void btnSalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigoReferencia.Text.Trim());
                string nombre = txtNombreProducto.Text.Trim();
                int preciocompra = Convert.ToInt32(txtPrecioCompra.Text.Trim());
                int precioventa = Convert.ToInt32(txtPrecioVenta.Text.Trim());
                int cantstock = Convert.ToInt32(txtCantidadStock.Text.Trim());
                int categoria = Convert.ToInt32(cmbCategorias.SelectedValue);
                var repo = new Datos.RepositoriosCRUD.ProductosRepository();
                repo.AgregarProducto(codigo, nombre, preciocompra, precioventa, categoria, cantstock);
                MessageBox.Show("Producto agregado exitosamente: " + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigoReferencia.Text.Trim());
                var repo = new Datos.RepositoriosCRUD.ProductosRepository();
                repo.EliminarProducto(codigo);
                MessageBox.Show("Producto eliminado exitosamente con código: " + codigo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }
    }
}