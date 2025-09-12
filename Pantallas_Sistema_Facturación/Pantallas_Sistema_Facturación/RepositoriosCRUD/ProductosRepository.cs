using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Pantallas_Sistema_Facturación.Utilidades;
using System.Windows.Forms;

namespace Pantallas_Sistema_Facturación.RepositoriosCRUD
{
    public class ProductosRepository
    {

        public void AgregarProducto(int codigo, string nombre, int preciocompra, int precioventa, int categoria, int cantstock)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Productos (CodigoCat, NombreProducto, PrecioCompra, PrecioVenta, Categoria, CantStock) VALUES (@codigo, @nombre, @preciocompra, @precioventa, @categoria,@cantStock)", conexion))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@preciocompra", preciocompra);
                cmd.Parameters.AddWithValue("@precioventa", precioventa);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@cantStock", cantstock);

                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public void ActualizarProducto(int codigo, string nombre, int preciocompra, int precioventa, int categoria, int cantstock)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("UPDATE Productos SET NombreProducto = @nombre, PrecioCompra = @preciocompra, PrecioVenta = @precioventa, Categoria = @categoria, CantStock = @cantStock WHERE CodigoCat = @codigo", conexion))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@preciocompra", preciocompra);
                cmd.Parameters.AddWithValue("@precioventa", precioventa);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@cantStock", cantstock);

                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public void EliminarProducto(int codigo)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("DELETE Productos WHERE CodigoCat = @codigo", conexion))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
    }
}