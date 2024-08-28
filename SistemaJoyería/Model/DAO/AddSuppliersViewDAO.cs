using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaJoyería.DTO;
using SistemaJoyería.Model.DTO;

namespace SistemaJoyería.Model.DAO
{
    public class AddSuppliersDAO : SupplierDTO
    {
        private SqlCommand command = new SqlCommand();

        public int RegisterSupplier(SupplierDTO supplier)
        {
            try
            {
                command.Connection = getConnection();

                string queryInsert = "INSERT INTO Proveedores (NombreEmpresa, NombreContacto, Telefono, Email, Direccion) VALUES (@NombreEmpresa, @NombreContacto, @Telefono, @Email, @Direccion)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, command.Connection);
                MessageBox.Show(supplier.Telefono);
                cmdInsert.Parameters.AddWithValue("@NombreEmpresa", supplier.NombreEmpresa);
                cmdInsert.Parameters.AddWithValue("@NombreContacto", supplier.NombreContacto);
                cmdInsert.Parameters.AddWithValue("@Telefono", supplier.Telefono);
                cmdInsert.Parameters.AddWithValue("@Email", supplier.Email);
                cmdInsert.Parameters.AddWithValue("@Direccion", supplier.Direccion);


                int respuesta = cmdInsert.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo registrar proveedor, verifique su conexión a internet o que los servicios estén activos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public int UpdateSupplier(SupplierDTO supplier)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();

                string queryUpdate = "UPDATE Proveedores SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, Telefono = @Telefono, Email = @Email, Direccion = @Direccion WHERE Id = @Id";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);

                cmdUpdate.Parameters.AddWithValue("@Id", supplier.Id);
                cmdUpdate.Parameters.AddWithValue("@NombreEmpresa", supplier.NombreEmpresa);
                cmdUpdate.Parameters.AddWithValue("@NombreContacto", supplier.NombreContacto);
                cmdUpdate.Parameters.AddWithValue("@Telefono", supplier.Telefono);
                cmdUpdate.Parameters.AddWithValue("@Email", supplier.Email);
                cmdUpdate.Parameters.AddWithValue("@Direccion", supplier.Direccion);

                return cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo actualizar proveedor", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int DeleteSupplier(int id)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();

                string queryDelete = "DELETE FROM Proveedores WHERE Id = @Id";
                SqlCommand cmdDelete = new SqlCommand(queryDelete, command.Connection);
                cmdDelete.Parameters.AddWithValue("@Id", id);

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
