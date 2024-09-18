using SistemaJoyería.Model.DAO;
using SistemaJoyería.Model.DTO;
using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.Suppliers
{
    internal class ControllerFrmUpdateSuppliers
    {
        private UpdateSuppliersDAO suppliersDAO = new UpdateSuppliersDAO();
        private SupplierDTO supplier = new SupplierDTO();
        private FrmUpdateSuppliers vistaControlada;
        private int supplierID;

        public ControllerFrmUpdateSuppliers(int idProveedor, FrmUpdateSuppliers vistaPasada)
        {
            supplierID = idProveedor;
            vistaControlada = vistaPasada;

            LoadSupplierData(idProveedor);

            vistaPasada.btnActualizar.Click += (sender, e) => UpdateSupplier(CreateSupplierDTO());

            vistaPasada.txtNombreEmpresa.TextChanged += (sender, e) => ValidateLettersOnly(vistaPasada.txtNombreEmpresa, 25);
            vistaPasada.txtNombreContacto.TextChanged += (sender, e) => ValidateLettersOnly(vistaPasada.txtNombreContacto, 20);
            vistaPasada.txtTelefono.KeyPress += ValidatePhoneInput;
            vistaPasada.txtTelefono.TextChanged += ValidatePhoneLength;
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);
            vistaPasada.txtDireccion.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtDireccion, 150);
        }

        public ControllerFrmUpdateSuppliers(string idBuena, FrmUpdateSuppliers frmUpdateSuppliers)
        {
        }

        private void LoadSupplierData(int idProveedor)
        {
            supplier = suppliersDAO.GetSupplierByID(idProveedor);

            if (supplier != null)
            {
                vistaControlada.txtNombreEmpresa.Text = supplier.CompanyName;
                vistaControlada.txtNombreContacto.Text = supplier.ContactName;
                vistaControlada.dtpFechaRegistro.Value = supplier.DayAdded;
                vistaControlada.txtTelefono.Text = supplier.Phone;
                vistaControlada.txtEmail.Text = supplier.Email;
                vistaControlada.txtDireccion.Text = supplier.Direction;
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vistaControlada.Close();
            }
        }

        public void UpdateSupplier(SupplierDTO supplier)
        {
            if (ValidateAllFields())
            {
                try
                {
                    int result = suppliersDAO.UpdateSupplier(supplier);

                    if (result > 0)
                    {
                        MessageBox.Show($"Proveedor con ID {supplierID} actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                catch (SqlException ex)
                {
                    HandleSqlException(ex);
                }
            }
        }

        private SupplierDTO CreateSupplierDTO()
        {
            supplier.IDSupplier = supplierID;
            supplier.CompanyName = vistaControlada.txtNombreEmpresa.Text.Trim();
            supplier.ContactName = vistaControlada.txtNombreContacto.Text.Trim();
            supplier.DayAdded = vistaControlada.dtpFechaRegistro.Value;
            supplier.Phone = vistaControlada.txtTelefono.Text.Trim();
            supplier.Email = vistaControlada.txtEmail.Text.Trim();
            supplier.Direction = vistaControlada.txtDireccion.Text.Trim();
            return supplier;
        }

        private void HandleSqlException(SqlException ex)
        {
            MessageBox.Show($"Error al actualizar proveedor: {ex.Message}", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearFields()
        {
            vistaControlada.txtNombreEmpresa.Clear();
            vistaControlada.txtNombreContacto.Clear();
            vistaControlada.txtTelefono.Clear();
            vistaControlada.txtEmail.Clear();
            vistaControlada.txtDireccion.Clear();
            vistaControlada.dtpFechaRegistro.Value = DateTime.Now;
        }

        private bool ValidateAllFields()
        {
            if (string.IsNullOrWhiteSpace(vistaControlada.txtNombreEmpresa.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtNombreContacto.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtEmail.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateEmail(vistaControlada.txtEmail))
            {
                return false;
            }

            return true;
        }

        private void ValidateLength(TextBox textBox, int maxLength)
        {
            if (textBox.Text.Length > maxLength)
            {
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = textBox.Text.Length;
                MessageBox.Show($"La longitud máxima es de {maxLength} caracteres.", "Validación de longitud", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidateLettersOnly(TextBox textBox, int maxLength)
        {
            if (!Regex.IsMatch(textBox.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("Solo se permiten letras.", "Validación de caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
            ValidateLength(textBox, maxLength);
        }

        private void ValidatePhoneInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Validación de caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidatePhoneLength(object sender, EventArgs e)
        {
            if (vistaControlada.txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener 8 dígitos.", "Validación de longitud", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateEmail(TextBox textBox)
        {
            if (!Regex.IsMatch(textBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Formato de correo no válido.", "Validación de correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            return true;
        }
    }
}
