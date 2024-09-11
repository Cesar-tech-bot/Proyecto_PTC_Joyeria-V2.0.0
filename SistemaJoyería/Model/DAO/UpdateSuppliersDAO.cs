using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    public class UpdateSuppliersDAO : SupplierDTO
    {
        private SqlCommand command = new SqlCommand();

        public void Get(FrmUpdateSuppliers vista, string companyName)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();
                string query = "SELECT * FROM Suppliers WHERE CompanyName = @CompanyName";
                command.CommandText = query;
                command.Parameters.AddWithValue("@CompanyName", companyName);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vista.txtNombreEmpresa.Text = reader["CompanyName"].ToString();
                        vista.txtNombreContacto.Text = reader["ContactName"].ToString();
                        vista.txtTelefono.Text = reader["Phone"].ToString();
                        vista.txtEmail.Text = reader["Email"].ToString();
                        vista.txtDireccion.Text = reader["Direction"].ToString();
                        vista.dtpFechaRegistro.Value = Convert.ToDateTime(reader["DayAdded"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos del proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int UpdateSupplier(SupplierDTO supplier)
        {
            try
            {
                command.Connection = getConnection();
                command.Connection.Open();
                string queryUpdate = @"UPDATE Suppliers 
                                       SET ContactName = @ContactName, 
                                           Phone = @Phone, 
                                           Email = @Email, 
                                           Direction = @Direction, 
                                           DayAdded = @DayAdded 
                                       WHERE CompanyName = @CompanyName";
                command.CommandText = queryUpdate;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                command.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                command.Parameters.AddWithValue("@Phone", supplier.Phone);
                command.Parameters.AddWithValue("@Email", supplier.Email);
                command.Parameters.AddWithValue("@Direction", supplier.Direction);
                command.Parameters.AddWithValue("@DayAdded", supplier.DayAdded);
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}