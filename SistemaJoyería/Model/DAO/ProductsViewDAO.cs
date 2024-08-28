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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Sockets;

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
                //cmdInsert.Parameters.AddWithValue("Param5", IDProducto1);
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
                string queryInsert = "Delete Products Where IDProducto = @param1";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("param1", IDProducto1);
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

        //Acutalizar Productos
        public int UpdateProduct()
        {
            try
            {
                command.Connection = getConnection();
                string queryUpdate = "UPDATE Clientes SET NombreProducto = @param1, MaterialProduct = @param2, NombreProveedor = @param3, DescripcionProducto = @param4 WHERE IDProducto = @param5";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);
                cmdUpdate.Parameters.AddWithValue("param1", NombreProducto1);
                cmdUpdate.Parameters.AddWithValue("param2", MaterialProducto1);
                cmdUpdate.Parameters.AddWithValue("param3", NombreProveedor1);
                cmdUpdate.Parameters.AddWithValue("param4", DescripcionProducto1);
                cmdUpdate.Parameters.AddWithValue("param5", IDProducto1);

                return cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se logro actualizar la informacion del producto, verefique su conexión a internet o que los servicios estes activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
