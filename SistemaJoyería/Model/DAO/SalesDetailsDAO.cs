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
                string queryInsert = "INSERT INTO SalesDetails (IDSale, IDProduct, Quantity, Price) VALUES (@param1, @param2, @param3, @param4)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("param1", IDSale1);
                cmdInsert.Parameters.AddWithValue("param2", IDProduct1);
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

        // Eliminar detalles de venta
        public int DeleteRecord()
        {
            try
            {
                command.Connection = getConnection();
                string queryDelete = "DELETE FROM SalesDetails WHERE IDSaleDetail = @param1";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                cmdDelete.Parameters.AddWithValue("param1", IDSaleDetail1);
                return cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo eliminar el detalle de venta.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        // Actualizar detalles de venta
        public int UpdateSaleDetails()
        {
            try
            {
                command.Connection = getConnection();
                string queryUpdate = "UPDATE SalesDetails SET IDSale = @param1, IDProduct = @param2, Quantity = @param3, Price = @param4 WHERE IDSaleDetail = @param5";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);
                cmdUpdate.Parameters.AddWithValue("param1", IDSale1);
                cmdUpdate.Parameters.AddWithValue("param2", IDProduct1);
                cmdUpdate.Parameters.AddWithValue("param3", Quantity1);
                cmdUpdate.Parameters.AddWithValue("param4", Price1);
                cmdUpdate.Parameters.AddWithValue("param5", IDSaleDetail1);

                return cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo actualizar el detalle de venta.", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}