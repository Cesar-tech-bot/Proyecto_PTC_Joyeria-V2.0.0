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

            // Cargar los datos del proveedor
            LoadSupplierData(idProveedor);

            // Asignar eventos de los botones y campos
            vistaPasada.btnActualizar.Click += (sender, e) => UpdateSupplier(CreateSupplierDTO());

            vistaPasada.txtNombreEmpresa.KeyPress += (sender, e) => ValidateLettersAndSpace(e);
            vistaPasada.txtTelefono.KeyPress += (sender, e) => ValidatePhoneInput(e);
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);
            vistaPasada.txtTelefono.Leave += (sender, e) => ValidatePhoneLength(vistaPasada.txtTelefono);
        }

        // Método para cargar los datos de un proveedor existente
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

        // Método para actualizar el proveedor
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
                        vistaControlada.Close();
                    }
                }
                catch (SqlException ex)
                {
                    HandleSqlException(ex);
                }
            }
        }

        // Crear SupplierDTO con datos actualizados
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

        // Manejo de excepciones SQL
        private void HandleSqlException(SqlException ex)
        {
            MessageBox.Show($"Error al actualizar proveedor: {ex.Message}", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Validar todos los campos
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

            if (vistaControlada.txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 8 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validar solo letras y espacios para nombres de empresa y contacto
        private void ValidateLettersAndSpace(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear cualquier tecla que no sea letra o espacio
                MessageBox.Show("Este campo solo permite letras y espacios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Validar entrada del teléfono: solo números
        private void ValidatePhoneInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo permite números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Validar que el teléfono tenga exactamente 8 dígitos
        private void ValidatePhoneLength(TextBox txtTelefono)
        {
            if (txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener 8 dígitos.", "Validación de longitud", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Validar correo electrónico
        private bool ValidateEmail(TextBox emailTextBox)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}