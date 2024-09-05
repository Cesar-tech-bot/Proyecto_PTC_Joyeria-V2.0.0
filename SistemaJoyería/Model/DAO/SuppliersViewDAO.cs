using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaJoyeria.DAO
{
    public class SupplierDAO : SupplierDTO
    {
        private SqlCommand command = new SqlCommand();
        public void GetData(FrmSuppliers vistaPasada)
        {
            try
            {
                command.Connection = getConnection();

                string query = "SELECT * FROM Suppliers";
                using (SqlCommand cmdGet = new SqlCommand(query, command.Connection))
                {
                    SqlDataReader reader = cmdGet.ExecuteReader();
                    vistaPasada.listSuppliers.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["IDSupplier"].ToString());
                        item.SubItems.Add(reader["CompanyName"].ToString());
                        item.SubItems.Add(reader["ContactName"].ToString());
                        item.SubItems.Add(reader["Phone"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["Direction"].ToString());
                        vistaPasada.listSuppliers.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SearchData(FrmSuppliers vistaPasada)
        {
            try
            {
                command.Connection = getConnection();

                string query = "SELECT * FROM Suppliers WHERE CompanyName LIKE @searchingFor";
                using (SqlCommand cmdGet = new SqlCommand(query, command.Connection))
                {
                    cmdGet.Parameters.AddWithValue("@searchingFor", "%" + vistaPasada.txtSearch.Text + "%");
                    SqlDataReader reader = cmdGet.ExecuteReader();
                    vistaPasada.listSuppliers.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["IDSupplier"].ToString());
                        item.SubItems.Add(reader["CompanyName"].ToString());
                        item.SubItems.Add(reader["ContactName"].ToString());
                        item.SubItems.Add(reader["Phone"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["Direction"].ToString());
                        vistaPasada.listSuppliers.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(string idMala)
        {
            try
            {
                command.Connection = getConnection();
                string query = "DELETE FROM Suppliers WHERE IDSupplier = @idMala";

                using (SqlCommand cmdDelete = new SqlCommand(query, command.Connection))
                {
                    cmdDelete.Parameters.AddWithValue("@idMala", idMala);
                    cmdDelete.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}