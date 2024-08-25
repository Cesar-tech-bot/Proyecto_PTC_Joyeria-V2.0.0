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
        //Creamos variables para guardar el server y la DB 
        private string server;
        private string database;

        //Creamos un Setter Y getter para cada variables para poder trabajar con ellas
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }

        public static SqlConnection getConnection()
        {
                try
                {
                    //Defininmos el server
                    string server = "";
                    //Ahora la DB
                    string database = "DB_CRUD";          
                     //Creamos la conexión 
                    SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; Integrated Security=True;");
                    conexion.Open();
                    //Retornamos la conexion abierta
                    return conexion;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"{ex.Message} No fue posible conectarse a la base de datos, favor verifique las credenciales o que tenga acceso al sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
        }

    }
}
