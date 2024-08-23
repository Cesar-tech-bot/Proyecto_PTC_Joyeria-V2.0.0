using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.Model.DTO;

namespace SistemaJoyería.Model.DAO
{
    public class ClientsViewDAO : ClientsViewDTO
    {
        SqlCommand command = new SqlCommand();
        public DataSet ShowDGV()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT*FROM vw_ClientesInfo";
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "vw_ClientesInfo");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show($"Error al intentar mostrar datos, verifique su conexiòn a internet o acceso al servidor o base de datos estèn activos", "Error de ejecuciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }

        }
    }
}
