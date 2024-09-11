using SistemaJoyeria.Model.DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    public class UpdateSuppliersDAO : SupplierDTO
    {
        private SqlCommand command = new SqlCommand();

        // Método para actualizar un proveedor
        public int UpdateSupplier(SupplierDTO supplier)
        {
            try
            {
                // Conexión a la base de datos
                command.Connection = getConnection();
                command.Connection.Open();

                // Consulta SQL para actualizar un proveedor
                string queryUpdate = @"UPDATE Suppliers 
                                       SET ContactName = @ContactName, 
                                           Phone = @Phone, 
                                           Email = @Email, 
                                           Direction = @Direction, 
                                           DayAdded = @DayAdded 
                                       WHERE CompanyName = @CompanyName";

                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);

                // Asignación de parámetros
                cmdUpdate.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                cmdUpdate.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                cmdUpdate.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmdUpdate.Parameters.AddWithValue("@Email", supplier.Email);
                cmdUpdate.Parameters.AddWithValue("@Direction", supplier.Direction);
                cmdUpdate.Parameters.AddWithValue("@DayAdded", supplier.DayAdded);

                // Ejecuta la actualización y retorna el número de filas afectadas
                int result = cmdUpdate.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
