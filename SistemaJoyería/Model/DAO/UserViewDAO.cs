using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Model.DTO;

namespace SistemaJoyería.Model.DAO
{
    public class UserViewDAO : UserViewDTO
    {
        SqlCommand command = new SqlCommand();

        public DataSet ShowDGV()
        {
            try
            {
                // Establecemos la conexión para el command
                command.Connection = getConnection();
                // Definimos la consulta para seleccionar datos
                string query = "SELECT * FROM v_Users";
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                // Ejecutamos la consulta y obtenemos los datos
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "v_Users");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show($"Error al intentar mostrar datos, verifique su conexión a internet o acceso al servidor o base de datos estén activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                // Cerramos conexión
                command.Connection.Close();
            }
        }

        public int UpdateUser()
        {
            try
            {
                // Establecemos una conexión
                command.Connection = getConnection();

                // Definir que acción se desea realizar
                string queryUpdate = "UPDATE Users SET LoginName = @param1, Password = @param2, UserEmail = @param3, Estado = @param4, idRoles = @param5 WHERE IDUser = @param6";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);

                // Agregamos los parámetros
                cmdUpdate.Parameters.AddWithValue("@param1", UserName1);
                cmdUpdate.Parameters.AddWithValue("@param2", Password1); // Usamos la contraseña tal como la ingresó el usuario, sin encriptación
                cmdUpdate.Parameters.AddWithValue("@param3", UserEmail1);
                cmdUpdate.Parameters.AddWithValue("@param4", Estado1);
                cmdUpdate.Parameters.AddWithValue("@param5", IdRoles1);
                cmdUpdate.Parameters.AddWithValue("@param6", IDUser1);

                // Ejecutamos la consulta
                return cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo actualizar la información del Usuario, verifique su conexión a internet o que los servicios estén activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                // Cerramos la conexión
                command.Connection.Close();
            }
        }

        public int DeleteUser()
        {
            try
            {
                //Establecemos una conexion
                command.Connection = getConnection();
                //Definir que accion se desea realizar   (un parametro para cada campo
                string queryInsert = "Delete Employees Where IDEmployees = @param1";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("param1", IDUser1);
                return cmdInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message} No se puede eliminar el Usuario, verifique su conexion a internet o que los servicios esten activos", "Error de insercción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataSet SearchUser(string valor)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM v_Users WHERE [Nombre de Usuario] Like '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteScalar();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "v_Users");
                return dataSet;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
