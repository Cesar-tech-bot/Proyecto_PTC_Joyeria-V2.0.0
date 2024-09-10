using SistemaJoyeria.Model.DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    public class AddSuppliersDAO : SupplierDTO
    {
        // Objeto SqlCommand para ejecutar comandos SQL
        private SqlCommand command = new SqlCommand();

        // Método para registrar un nuevo proveedor
        public int RegisterSupplier(SupplierDTO supplier)
        {
            try
            {
                // Establece la conexión
                command.Connection = getConnection();

                // Query SQL para insertar un nuevo proveedor
                string queryInsert = "INSERT INTO Suppliers (CompanyName, ContactName, Phone, Email, Direction) VALUES (@CompanyName, @ContactName, @Phone, @Email, @Direction)";

                // Crea un nuevo comando SQL con la query y la conexión
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);

                // Agrega los parámetros al comando
                cmdInsert.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                cmdInsert.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                cmdInsert.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmdInsert.Parameters.AddWithValue("@Email", supplier.Email);
                cmdInsert.Parameters.AddWithValue("@Direction", supplier.Direction);

                // Ejecuta el comando y devuelve el número de filas afectadas
                int respuesta = cmdInsert.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje de error
                MessageBox.Show($"{ex.Message} No se pudo registrar proveedor, verifique su conexión a internet o que los servicios estén activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Método para actualizar un proveedor existente
        public int UpdateSupplier(SupplierDTO supplier)
        {
            try
            {
                // Establece y abre la conexión
                command.Connection = getConnection();
                command.Connection.Open();

                // Query SQL para actualizar un proveedor
                string queryUpdate = "UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, Phone = @Phone, Email = @Email, Direction = @Direction WHERE IDSupplier = @IDSupplier";

                // Crea un nuevo comando SQL con la query y la conexión
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);

                // Agrega los parámetros al comando
                cmdUpdate.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                cmdUpdate.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                cmdUpdate.Parameters.AddWithValue("@Phone", supplier.Phone);
                cmdUpdate.Parameters.AddWithValue("@Email", supplier.Email);
                cmdUpdate.Parameters.AddWithValue("@Direction", supplier.Direction);

                // Ejecuta el comando y devuelve el número de filas afectadas
                return cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje de error
                MessageBox.Show($"{ex.Message} No se pudo actualizar proveedor", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                // Cierra la conexión
                command.Connection.Close();
            }
        }

        // Método para eliminar un proveedor
        public int DeleteSupplier(int id)
        {
            try
            {
                // Establece y abre la conexión
                command.Connection = getConnection();
                command.Connection.Open();

                // Query SQL para eliminar un proveedor
                string queryDelete = "DELETE FROM Proveedores WHERE IDSupplier = @IDSupplier";

                // Crea un nuevo comando SQL con la query y la conexión
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);

                // Agrega el parámetro al comando
                cmdDelete.Parameters.AddWithValue("@IDSupplier", id);

                // Ejecuta el comando y devuelve el número de filas afectadas
                return cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje de error
                MessageBox.Show($"{ex.Message} No se pudo eliminar proveedor", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                // Cierra la conexión
                command.Connection.Close();
            }
        }
    }
}