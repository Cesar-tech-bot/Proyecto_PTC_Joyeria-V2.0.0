using SistemaJoyería.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Controller.ProductsController;

namespace SistemaJoyería.Model.DAO
{
    internal class ProductsViewDAO : ProductsViewDTO
    {
         SqlCommand command = new SqlCommand();
        //Mostrar datos en el data grid view
        public DataSet ShowDGV()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT*FROM vw_Products";
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "vw_Products");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show($"Error al intentar mostrar datos, verifique su conexión a internet o acceso al servidor o base de datos estèn activos", "Error de ejecuciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }

        }

        //Registrar productos
        public int registrerproducts()
        {
            try
            {
                //Establecemos una conexion
                command.Connection = getConnection();
                //Definir que accion se desea realizar   (un parametro para cada campo
                string queryInsert = "INSERT INTO Products Values (@param1, @param2, @param3, @param4)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("Param1", NombreProducto1);
                cmdInsert.Parameters.AddWithValue("Param2", MaterialProducto1);
                cmdInsert.Parameters.AddWithValue("Param3", NombreProveedor1);
                cmdInsert.Parameters.AddWithValue("Param4", DescripcionProducto1);
                return cmdInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message} No se puede registrar la iformacion del producto, verifique su conexion a internet o que los servicios esten activos", "Error de insercción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        //Eliminar Productos
        public int DeleteRecord()
        {
            try
            {
                //Establecemos una conexion
                command.Connection = getConnection();
                //Definir que accion se desea realizar   (un parametro para cada campo
                string queryInsert = "Delete Products Where NombreProducto = @param1";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("Param1", NombreProducto1);
                return cmdInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message} No se puede eliminar la iformacion del producto, verifique su conexion a internet o que los servicios esten activos", "Error de insercción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
