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
        public static SqlConnection getConnection()
        {
            //Conexion
            try
            {
                String test = "Server = SALVADORPC\\SQLEXPRESS; Database = DB_LUXST_ITR; Security Integrated = true;";

                //string server = "";

                //string database = "";

                //Creamos la conexión 
                SqlConnection conexion = new SqlConnection(test);
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