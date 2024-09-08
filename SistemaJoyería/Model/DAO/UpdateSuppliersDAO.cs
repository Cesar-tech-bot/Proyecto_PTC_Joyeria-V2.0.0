using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Model.DAO
{
    internal class UpdateSuppliersDAO : SupplierDTO
    {
        // Objeto SqlCommand para ejecutar comandos SQL
        private SqlCommand command = new SqlCommand();

        // Método para obtener los datos de un proveedor específico
        public void Get(FrmUpdateSuppliers vistaPasada, string idBuena)
        {
            try
            {
                // Establece la conexión
                command.Connection = getConnection();

                // Query SQL para seleccionar un proveedor específico
                string query = "SELECT * FROM Suppliers WHERE IDSupplier = @IDSupplier";

                using (SqlCommand cmdGet = new SqlCommand(query, command.Connection))
                {
                    // Agrega el parámetro del ID del proveedor
                    cmdGet.Parameters.AddWithValue("@IDSupplier", idBuena);

                    // Ejecuta la query y obtiene un SqlDataReader
                    SqlDataReader reader = cmdGet.ExecuteReader();

                    // Lee los datos del proveedor
                    while (reader.Read())
                    {
                        // Asigna los valores a los campos del formulario
                        vistaPasada.txtId.Text = (reader["IDSupplier"].ToString());
                        vistaPasada.txtNombreEmpresa.Text = (reader["CompanyName"].ToString());
                        vistaPasada.txtNombreContacto.Text = (reader["ContactName"].ToString());
                        vistaPasada.txtTelefono.Text = (reader["Phone"].ToString());
                        vistaPasada.txtEmail.Text = (reader["Email"].ToString());
                        vistaPasada.txtDireccion.Text = (reader["Direction"].ToString());
                    }
                    // Cierra el reader
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra el mensaje de error
                MessageBox.Show(ex.ToString());
            }
        }

        // Método para actualizar los datos de un proveedor
        public void Update(string idBuena, FrmUpdateSuppliers vistaControlada)
        {
            try
            {
                // Establece la conexión
                command.Connection = getConnection();

                // Muestra el ID del proveedor (para depuración)
                MessageBox.Show(idBuena);

                // Query SQL para actualizar un proveedor
                string queryUpdate = "UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, Phone = @Phone, Email = @Email, Direction = @Direction WHERE IDSupplier = @IDSupplier";

                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);

                // Agrega los parámetros al comando
                cmdUpdate.Parameters.AddWithValue("@IDSupplier", idBuena);
                MessageBox.Show(idBuena); // Muestra el ID nuevamente (para depuración)
                cmdUpdate.Parameters.AddWithValue("@CompanyName", vistaControlada.txtNombreEmpresa.Text);
                cmdUpdate.Parameters.AddWithValue("@ContactName", vistaControlada.txtNombreContacto.Text);
                cmdUpdate.Parameters.AddWithValue("@Phone", vistaControlada.txtTelefono.Text);
                cmdUpdate.Parameters.AddWithValue("@Email", vistaControlada.txtEmail.Text);
                cmdUpdate.Parameters.AddWithValue("@Direction", vistaControlada.txtDireccion.Text);

                // Ejecuta el comando de actualización
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje de error
                MessageBox.Show($"{ex.Message} No se pudo actualizar proveedor, verifique su conexión a internet o que los servicios estén activos", "Error de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}