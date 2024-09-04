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
        private SqlCommand command = new SqlCommand();

        public void Get(FrmUpdateSuppliersView vistaPasada, string idBuena) 
        {
            try
            {
                command.Connection = getConnection();

                string query = "SELECT * FROM Proveedores WHERE Id = @Id";
                using (SqlCommand cmdGet = new SqlCommand(query, command.Connection))
                {
                    cmdGet.Parameters.AddWithValue("@Id", idBuena);
                    SqlDataReader reader = cmdGet.ExecuteReader();

                    while (reader.Read())
                    {
                        vistaPasada.txtId.Text = (reader["Id"].ToString());
                        vistaPasada.txtNombreEmpresa.Text = (reader["NombreEmpresa"].ToString());
                        vistaPasada.txtNombreContacto.Text = (reader["NombreContacto"].ToString());
                        vistaPasada.txtTelefono.Text = (reader["Telefono"].ToString());
                        vistaPasada.txtEmail.Text = (reader["Email"].ToString());
                        vistaPasada.txtDireccion.Text = (reader["Direccion"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(string idBuena, FrmUpdateSuppliersView vistaControlada) 
        {
            try
            {
                command.Connection = getConnection();
                MessageBox.Show(idBuena);
                string queryUpdate = "UPDATE Proveedores SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, Telefono = @Telefono, Email = @Email, Direccion = @Direccion WHERE Id = @Id";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, command.Connection);
                cmdUpdate.Parameters.AddWithValue("@Id", idBuena);
                MessageBox.Show(idBuena);
                cmdUpdate.Parameters.AddWithValue("@NombreEmpresa", vistaControlada.txtNombreEmpresa.Text);
                cmdUpdate.Parameters.AddWithValue("@NombreContacto", vistaControlada.txtNombreContacto.Text);
                cmdUpdate.Parameters.AddWithValue("@Telefono", vistaControlada.txtTelefono.Text);
                cmdUpdate.Parameters.AddWithValue("@Email", vistaControlada.txtEmail.Text);
                cmdUpdate.Parameters.AddWithValue("@Direccion", vistaControlada.txtDireccion.Text);


                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} No se pudo actualizar proveedor, verifique su conexión a internet o que los servicios estén activos", "Error de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
