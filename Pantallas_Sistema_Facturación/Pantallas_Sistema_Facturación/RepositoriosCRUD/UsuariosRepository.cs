using Pantallas_Sistema_Facturación.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_Facturación.RepositoriosCRUD
{
    public class UsuariosRepository
    {
        //CRUD

        //Agregar Usuario
        public void AgregarUsuario(int documento, string usuario, string contrasena) 
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Documento = @documento", conexion)) 
            {
                int cantidad = (int)cmd1.ExecuteScalar();
                if (cantidad > 0)
                {
                    throw new Exception("El usuario ya existe en la base de datos.");
                    
                }
            }
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (Documento, Usuario, Clave) VALUES (@documento, @usuario, @clave)", conexion))
            {
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", contrasena);

                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
        public void ValidarLogin(string usuario, string clave) 
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand ("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Clave = @clave",conexion))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                int cantidad = (int)cmd.ExecuteScalar();
                if (cantidad == 1)
                {
                    MessageBox.Show($"¡Bienvenido {usuario}");
                }
                if (cantidad == 0)
                {
                    throw new Exception("Usuario o clave incorrectos.");
                }
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public void EditarUsuario(int documento, string usuario, string clave)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand cmd = new SqlCommand ("UPDATE Usuarios SET Usuario = @usuario, Clave = @clave WHERE Documento = @documento",conexion))
            {
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        public void EliminarUsuario(int documento)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand cmd = new SqlCommand ("DELETE FROM Usuarios WHERE Documento = @documento", conexion))
            {
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
    }
}
