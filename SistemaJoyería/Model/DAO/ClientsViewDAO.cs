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
                //Establecemos la conexión para el command
                command.Connection = getConnection();
                //Definimos la consulta para seleccionar datos
                string query = "SELECT * FROM vw_ClientesInfo";
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                //Ejecutamos la consulta y obtenemos los datos
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "vw_ClientesInfo");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show($"Error al intentar mostrar datos, verifique su conexión a internet o acceso al servidor o base de datos estén activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                //Cerramos conexión
                command.Connection.Close();
            }
        }

        public int EliminarClient()
        {
            try
            {
                //Establecemos la conexión para el comando
                command.Connection = getConnection();
                //Definimos la consulta para eliminar el cliente
                string queryDelete = "DELETE Clients WHERE idClient = @param1";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IdClient);
                //Ejecutamos la consulta de eliminación y retornamos el resultado
                return cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo eliminar la información del cliente, verifique su conexión a internet o que los servicios estén activos", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                //Cerramos conexión
                command.Connection.Close();
            }
        }

    }
}
