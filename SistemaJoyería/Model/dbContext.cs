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

        private string server;
        private string database;

        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }

        public static SqlConnection getConnection()
        {
                try
                {
                    string server = "";
                    string database = "DB_CRUD";              
                    SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; Integrated Security=True;");
                    conexion.Open();
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
