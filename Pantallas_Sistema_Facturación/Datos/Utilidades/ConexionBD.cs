using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Utilidades
{
    public class ConexionBD
    {
        private readonly string cadenaConexion= "Server=localhost\\SQLEXPRESS;Database=Actividad2;Trusted_Connection=True;TrustServerCertificate=True";

        private static ConexionBD instancia; //Variable con la unica instancia de la clase

        private static readonly object lockObject = new object(); //objeto para bloqueo de los hilos para evitar si dos partes del programa intentan acceder al mismo tiempo

        private SqlConnection conexion;

        private ConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public static ConexionBD ObtenerInstancia()
        {
            if (instancia == null) //verificar si la instancia es nula
            {
                lock (lockObject) //bloquear para usar unicamente un hilo a la vez
                {
                    if (instancia == null) //verificar nuevamente que la instancia sea nula double-check
                    {
                        instancia = new ConexionBD(); //crear la conexion
                    }
                }
            }
            return instancia; //retornar la instancia creada o ya existente
        }

        //Abrir conexion
        public SqlConnection ObtenerConexion()
        {
            if(conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        //Cerrar conexion
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}