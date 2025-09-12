using Pantallas_Sistema_Facturación.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_Facturación.RepositoriosCRUD
{
    public class CategoriaRepository
    {
        public void AgregarProducto(int codigo, string nombre)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Categorias (CodigoCat, Nombre) VALUES (@codigo, @nombre)",conexion))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public void ActualizarProducto(int codigo, string nombre)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("UPDATE Categorias SET Nombre = @nombre WHERE CodigoCat = @codigo", conexion))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public void EliminarProducto(int codigo)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand("DELETE Categorias WHERE CodigoCat = @codigo"))
            {
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
    }
}