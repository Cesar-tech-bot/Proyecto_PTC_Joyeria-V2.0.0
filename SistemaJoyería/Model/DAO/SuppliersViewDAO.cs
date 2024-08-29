using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SistemaJoyeria.DTO;

namespace SistemaJoyeria.DAO
{
    public class SupplierDAO
    {
        private string connectionString = "DB_CRUD";

        public void Add(SupplierDTO supplier)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Suppliers (NombreEmpresa, NombreContacto, Telefono, Email, Direccion) VALUES (@NombreEmpresa, @NombreContacto, @Telefono, @Email, @Direccion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreEmpresa", supplier.NombreEmpresa);
                command.Parameters.AddWithValue("@NombreContacto", supplier.NombreContacto);
                command.Parameters.AddWithValue("@Telefono", supplier.Telefono);
                command.Parameters.AddWithValue("@Email", supplier.Email);
                command.Parameters.AddWithValue("@Direccion", supplier.Direccion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<SupplierDTO> Search(string searchTerm)
        {
            List<SupplierDTO> results = new List<SupplierDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Suppliers WHERE NombreEmpresa LIKE @SearchTerm OR ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                command.Parameters.AddWithValue("@ID", int.TryParse(searchTerm, out int id) ? id : (object)DBNull.Value);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    results.Add(new SupplierDTO
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        NombreEmpresa = reader["NombreEmpresa"].ToString(),
                        NombreContacto = reader["NombreContacto"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Email = reader["Email"].ToString(),
                        Direccion = reader["Direccion"].ToString()
                    });
                }
            }
            return results;
        }
    }
}