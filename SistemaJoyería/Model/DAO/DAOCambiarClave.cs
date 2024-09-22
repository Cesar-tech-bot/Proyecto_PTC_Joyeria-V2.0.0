using SistemaJoyería.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    internal class DAOCambiarClave : DTOLogin
    {
        SqlCommand SqlCommand = new SqlCommand();


        public bool ComprobarUsuario(string username)
        {
            SqlCommand.Connection = getConnection();
            string query = "SELECT * FROM Users  WHERE LoginName=@usuario";
            SqlCommand cmd = new SqlCommand(query, SqlCommand.Connection);
            cmd.Parameters.AddWithValue("usuario", username);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader.HasRows;



        }

        public bool ComprobarusuarioPorAdmin()
        {
            SqlCommand.Connection = getConnection();
            string query = "SELECT * FROM  Users WHERE LoginName = @usuario AND Estado = @status";
            SqlCommand cmd = new SqlCommand(query, SqlCommand.Connection);
            cmd.Parameters.AddWithValue("Usuario", LoginName1);
            cmd.Parameters.AddWithValue("status", true);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader.HasRows;
        }


        public bool DAOCambiarclave()
        {
            try
            {
                SqlCommand.Connection = getConnection();
                string query = "UPDATE Users SET Password = @contraseñaNueva WHERE  LoginName =@usuario";
                SqlCommand cmd = new SqlCommand(query, SqlCommand.Connection);
                cmd.Parameters.AddWithValue("usuario", LoginName1);
                cmd.Parameters.AddWithValue("contraseñaNueva", Password1);

                int lineasAfectadas = cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("status", true);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;




            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return false;


            }
            catch (Exception ex)
            {

                {
                    MessageBox.Show(ex.Message);
                    return false;


                }

            }
            finally
            {
                getConnection().Close();
            }
        }
    }
}
