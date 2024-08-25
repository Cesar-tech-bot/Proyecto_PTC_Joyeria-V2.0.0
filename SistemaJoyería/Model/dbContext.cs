using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Model
{
    public class dbContext
    {
        //Variables para almacenar el nombre del servidor y la base de datos
        private string server;
        private string database;
        //Propiedades para acceder y modificar el nombre del servidor y la base de datos
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }

        public static SqlConnection getConnection()
        {
            try
            {
                //Aquí se asigna el nombre del servidor y la base de datos
                string server = ""; //Nombre del servidor 
                string database = "DB_CRUD"; //Nombre de la base de datos
                // Se crea un objeto SqlConnection utilizando los parámetros del servidor y la base de datos
                SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; Integrated Security=True;");
                //Se abre la conexión a la base de datos
                conexion.Open();
                //Se retorna la conexión abierta para su uso en operaciones de base de datos
                return conexion;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message} No fue posible conectarse a la base de datos, favor verifique las credenciales o que tenga acceso al sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Se retorna 'null' en caso de que ocurra una excepción al intentar conectar.
                return null;
            }
        }
    }
}

