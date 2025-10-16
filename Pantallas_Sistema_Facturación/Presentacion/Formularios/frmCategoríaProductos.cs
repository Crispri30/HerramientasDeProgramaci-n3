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
    public partial class frmCategoríaProductos : MaterialForm
    {
        public frmCategoríaProductos()
        {
            InitializeComponent();
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                string nombre = txtNombreCategoria.Text.Trim();
                var repo = new Datos.RepositoriosCRUD.CategoriaRepository();
                repo.ActualizarProducto(codigo, nombre);
                MessageBox.Show("Categoría actualizada exitosamente: " + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la categoría: " + ex.Message);
            }

            /*
            errorProvider1.Clear();
            bool hayError = false;
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                errorProvider1.SetError(txtNombreCategoria, "El nombre es obligatorio.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                string nombre = txtNombreCategoria.Text.Trim();
                var repo = new Datos.RepositoriosCRUD.CategoriaRepository();
                repo.AgregarProducto(codigo, nombre);  
                MessageBox.Show("Categoría agregada exitosamente: " + nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categoría: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                var repo = new Datos.RepositoriosCRUD.CategoriaRepository();
                repo.EliminarProducto(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
            }
        }
    }
}