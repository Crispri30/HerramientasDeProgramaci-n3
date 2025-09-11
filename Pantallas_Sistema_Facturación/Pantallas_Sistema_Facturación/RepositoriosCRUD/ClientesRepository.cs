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
    public class ClientesRepository
    {
        //CRUD

        //Agregar Cliente
        public void AgregarCliente(int documento, string nombre, string email, string direccion, int telefono)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand verificar = new SqlCommand ("SELECT COUNT (*) FROM Clientes WHERE DocumentoCliente = @documento", conexion))
            {
                verificar.Parameters.AddWithValue("@documento", documento);
                int cantidad = (int)verificar.ExecuteScalar(); 
                if (cantidad > 0)
                {
                    throw new Exception("El cliente ya existe en la base de datos.");
                }
            }

            using (SqlCommand agregar = new SqlCommand ("INSERT INTO Clientes (DocumentoCliente, NombreCliente,Email,Direccion,Telefono) VALUES (@documento,@nombre,@email,@direccion,@telefono)", conexion))
            {
                agregar.Parameters.AddWithValue("@documento", documento);
                agregar.Parameters.AddWithValue("@nombre", nombre);
                agregar.Parameters.AddWithValue("@email", email);
                agregar.Parameters.AddWithValue("@direccion", direccion);
                agregar.Parameters.AddWithValue("@telefono", telefono);
                agregar.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

        //Editar Cliente
        public void EditarCliente(int documento, string nombre, string email, string direccion, int telefono)
        {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();

            using (SqlCommand act = new SqlCommand("UPDATE Clientes SET NombreCliente = @nombre, Email = @email, Direccion = @direccion, Telefono = @telefono WHERE DocumentoCliente = @documento", conexion))
            {
                act.Parameters.AddWithValue("@documento", documento);
                act.Parameters.AddWithValue("@nombre", nombre);
                act.Parameters.AddWithValue("@email", email);
                act.Parameters.AddWithValue("@direccion", direccion);
                act.Parameters.AddWithValue("@telefono", telefono);
                act.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }

       //Obtener Cliente

       //Eliminar Cliente
       public void EliminarCliente(int documento)
       {
            var conexion = ConexionBD.ObtenerInstancia().ObtenerConexion();
            using (SqlCommand eliminar = new SqlCommand("DELETE FROM Clientes WHERE DocumentoCliente = @documento", conexion))
            {
                eliminar.Parameters.AddWithValue("@documento", documento);
                eliminar.ExecuteNonQuery();
            }
            ConexionBD.ObtenerInstancia().CerrarConexion();
        }
    }
}
