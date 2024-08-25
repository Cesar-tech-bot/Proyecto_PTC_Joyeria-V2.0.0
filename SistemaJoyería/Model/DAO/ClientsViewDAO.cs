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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Sockets;

namespace SistemaJoyería.Model.DAO
{
    public class ClientsViewDAO : ClientsViewDTO
    {
        SqlCommand command = new SqlCommand();
        public DataSet ShowDGV()
        {
            try
            {
                //Aquí se crea una conexión utilizando el Obj command
                command.Connection = getConnection();
                //Se define la consulta que se ejecutará, en este caso la vista vw_ClientesInfo
                string query = "SELECT * FROM vw_ClientesInfo";
                //Se crea un objeto para ejecutar la consulta con la conexión establecida
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                //Se ejecuta la consulta
                cmdSelect.ExecuteNonQuery();
                //Se crea un SqlDataAdapter que va a llenar el DataSet con los datos obtenidos de la consulta
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                //Se crea un DataSet para almacenar los datos obtenidos de la consulta
                DataSet ds = new DataSet();
                //Se llena el DataSet con los datos de vw_ClientesInfo
                adp.Fill(ds, "vw_ClientesInfo");
                //Se retorna el ds lleno de datos para el DataGridView
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar mostrar datos, verifique su conexión a internet o que el acceso al servidor o base de datos esté activo", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Se retorna null en caso de que ocurra una excepción
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int EliminateClients()
        {
            try
            {
                //Establecemos una conexión
                command.Connection = getConnection();
                // Se define la consulta que se ejecutará, en este caso DELETE
                string queryDelete = "DELETE Clients WHERE  idClient = @param1";
                // Se crea un objeto para ejecutar la consulta con la conexión establecida
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                //Definimos el valor del parametro con DTO
                cmdDelete.Parameters.AddWithValue("param1", IdClient);
                // Retornamos la ejecución de la consulta
                return cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo eliminar la información de libro, verifique su conexión a internet o que los servicios esten activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int UpdatesClients()
        {
            try
            {
                //Establecemos una conexión
                command.Connection = getConnection();
                //Definir qué consulta se hará, en este caso UPDATE
                string queryUpdate = "UPDATE Clients SET firstName = @param1, lastName = @param2, phone = @param3, email = @param4, birthDate = @param5, identityDocument = @param6, addressClient = @param7 WHERE idClient = @param8";
                // Se crea un objeto para ejecutar la consulta con la conexión establecida
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);      
                //Definimos el valor de cada parámetro con el DTO
                cmdUpdate.Parameters.AddWithValue("param1", FirstName);
                cmdUpdate.Parameters.AddWithValue("param2", LastName);
                cmdUpdate.Parameters.AddWithValue("param3", Phone);
                cmdUpdate.Parameters.AddWithValue("param4", Email);
                cmdUpdate.Parameters.AddWithValue("param5", BirthDate);
                cmdUpdate.Parameters.AddWithValue("param6", IdentityDocument);
                cmdUpdate.Parameters.AddWithValue("param7", AddressClient);
                cmdUpdate.Parameters.AddWithValue("param8", IdClient);
                // Retornamos la ejecución de la consulta
                return cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo actualizar la información de libro, verifique su conexión a internet o que los servicios esten activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }


    }
}
