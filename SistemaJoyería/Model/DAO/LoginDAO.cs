using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaJoyería.Model.DTO;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    internal class DAOLogin : DTOLogin
    {
        SqlCommand Command = new SqlCommand();
        //metodo para validar que el inicio de seccion es correcto
        public bool LoginValidation()
        {
            try
            {
                Command.Connection = getConnection();
                //busca en la tabla "Users" los datos de los usuarios cuyo nombre de login y contraseña coincidan con los valores proporcionados en los parámetros "@user" y "@pass".
                string query = "SELECT * FROM Users WHERE nombreLogin = @user and Password = @pass";
                //mandando la consulta a la base
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                //admitiendo parametros a la base
                cmd.Parameters.AddWithValue("user", LoginName1);
                cmd.Parameters.AddWithValue("pass", Password1);
                SqlDataReader reader = cmd.ExecuteReader();
                //si las credenciales son correctas retornara un 1
                return reader.HasRows;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                getConnection().Close();
            }
        }
    }

}
