using SistemaJoyeria.Model.DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    public class UpdateSuppliersDAO : SupplierDTO
    {
        private SqlCommand command = new SqlCommand();

        // Método para obtener un proveedor por su ID
        public SupplierDTO GetSupplierByID(int idProveedor)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();
                string query = "SELECT * FROM Suppliers WHERE IDSupplier = @IDSupplier";
                SqlCommand sqlCommand = new SqlCommand(query, command.Connection);
                sqlCommand.Parameters.AddWithValue("@IDSupplier", idProveedor);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                SupplierDTO supplier = null;
                if (reader.Read())
                {
                    supplier = new SupplierDTO
                    {
                        IDSupplier = Convert.ToInt32(reader["IDSupplier"]),
                        CompanyName = reader["CompanyName"].ToString(),
                        ContactName = reader["ContactName"].ToString(),
                        DayAdded = Convert.ToDateTime(reader["DayAdded"]),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Direction = reader["Direction"].ToString()
                    };
                }
                return supplier;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al obtener proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        // Método para actualizar un proveedor
        public int UpdateSupplier(SupplierDTO supplier)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();
                string query = @"
                    UPDATE Suppliers
                    SET CompanyName = @CompanyName,
                        ContactName = @ContactName,
                        DayAdded = @DayAdded,
                        Phone = @Phone,
                        Email = @Email,
                        Direction = @Direction
                    WHERE IDSupplier = @IDSupplier";
                SqlCommand sqlCommand = new SqlCommand(query, command.Connection);
                sqlCommand.Parameters.AddWithValue("@IDSupplier", supplier.IDSupplier);
                sqlCommand.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                sqlCommand.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                sqlCommand.Parameters.AddWithValue("@DayAdded", supplier.DayAdded);
                sqlCommand.Parameters.AddWithValue("@Phone", supplier.Phone);
                sqlCommand.Parameters.AddWithValue("@Email", supplier.Email);
                sqlCommand.Parameters.AddWithValue("@Direction", supplier.Direction);
                return sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al actualizar proveedor: {ex.Message}", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        // Método para registrar un nuevo proveedor
        public int RegisterSupplier(SupplierDTO supplier)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();
                string queryInsert = "INSERT INTO Suppliers (CompanyName, ContactName, Phone, Email, Direction, DayAdded) VALUES (@CompanyName, @ContactName, @Phone, @Email, @Direction, @DayAdded)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                cmdInsert.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                cmdInsert.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                cmdInsert.Parameters.AddWithValue("@DayAdded", supplier.DayAdded);
                cmdInsert.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmdInsert.Parameters.AddWithValue("@Email", supplier.Email);
                cmdInsert.Parameters.AddWithValue("@Direction", supplier.Direction);
                int respuesta = cmdInsert.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo registrar proveedor, verifique su conexión a internet o que los servicios estén activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        // Método para eliminar un proveedor
        public int DeleteSupplier(int id)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();
                string queryDelete = "DELETE FROM Suppliers WHERE IDSupplier = @IDSupplier";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                cmdDelete.Parameters.AddWithValue("@IDSupplier", id);
                return cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo eliminar proveedor", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}