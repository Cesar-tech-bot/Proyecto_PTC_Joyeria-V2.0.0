using SistemaJoyería.Model.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    internal class SalesDetailsViewDAO : SalesDetailsDTO
    {
        SqlCommand command = new SqlCommand();

        // Mostrar detalles de ventas en DataGridView
        public DataSet ShowDGV()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM vw_Details";
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "vw_Details");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Error al intentar mostrar los detalles de venta.", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        // Registrar detalles de venta
        public int RegisterSaleDetails()
        {
            try
            {
                command.Connection = getConnection();
                string queryInsert = "INSERT INTO SalesDetails (IDProduct, DayToSale, Quantity, Price) VALUES (@param1, @param2, @param3, @param4)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("param1", IDProduct1);
                cmdInsert.Parameters.AddWithValue("Param2", DayToSale1);
                cmdInsert.Parameters.AddWithValue("param3", Quantity1);
                cmdInsert.Parameters.AddWithValue("param4", Price1);

                return cmdInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo registrar los detalles de la venta.", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        // Buscar detalles de venta
        public DataSet SearchSalesDetails(string valor)
        {
            try
            {
                command.Connection = getConnection();
                string query = $"SELECT * FROM vw_Details WHERE IDProduct LIKE '%{valor}%'";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("@Valor", $"%{valor}%");
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "SalesDetails");
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo realizar la búsqueda.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataSet GetProducts()
        {
            try
            {
                command.Connection = getConnection();
                //Definir instrucción de lo que se quiere hacer
                string query = "SELECT IDProduct,  ProductName FROM Products";
                //Creando un objeto de tipo comando donde recibe la instrucción y la conexión
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                //Se ejecuta el comando cmdSelect con la instrucción y la conexión
                cmdSelect.ExecuteNonQuery();
                //Se crea un objeto de tipo SqlDataAdapter para facilitar el llenado del dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                //Se crea un dataset que contendrá los datos encontrados
                DataSet ds = new DataSet();
                //rellenamos el dataset con el objeto SqlDataAdapter
                adp.Fill(ds, "Products");
                //Se retorna el dataset
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Error al obtener los autores, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}