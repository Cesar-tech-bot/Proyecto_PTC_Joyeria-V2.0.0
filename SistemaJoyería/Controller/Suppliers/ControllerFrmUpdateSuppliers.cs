using SistemaJoyería.Model.DAO;
using SistemaJoyería.Model.DTO;
using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.Suppliers
{
    internal class ControllerFrmUpdateSuppliers
    {
        private UpdateSuppliersDAO suppliersDAO = new UpdateSuppliersDAO();
        private SupplierDTO supplier = new SupplierDTO();
        private FrmUpdateSuppliers vistaControlada;

        public ControllerFrmUpdateSuppliers(FrmUpdateSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada;

            // Eventos asociados a botones y controles del formulario de actualización
            vistaPasada.btnActualizar.Click += (sender, e) => UpdateSupplier(supplier);

            vistaPasada.txtNombreEmpresa.TextChanged += (sender, e) => ValidateLettersOnly(vistaPasada.txtNombreEmpresa, 20);
            vistaPasada.txtNombreContacto.TextChanged += (sender, e) => ValidateLettersOnly(vistaPasada.txtNombreContacto, 15);
            vistaPasada.txtTelefono.KeyPress += ValidatePhoneInput;
            vistaPasada.txtTelefono.TextChanged += ValidatePhoneLength;
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);
            vistaPasada.txtDireccion.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtDireccion, 150);
        }

        public ControllerFrmUpdateSuppliers(string idBuena, FrmUpdateSuppliers frmUpdateSuppliers)
        {
        }

        public void UpdateSupplier(SupplierDTO supplier)
        {
            if (ValidateAllFields())
            {
                // Crea el objeto SupplierDTO con los datos del formulario
                CreateSupplierDTO();

                try
                {
                    int result = suppliersDAO.UpdateSupplier(supplier);

                    if (result > 0)
                    {
                        MessageBox.Show("Proveedor actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                catch (SqlException ex)
                {
                    HandleSqlException(ex);
                }
            }
        }

        // Crea el objeto SupplierDTO a partir de los datos del formulario
        private SupplierDTO CreateSupplierDTO()
        {
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

        // Limpiar campos del formulario
        private void ClearFields()
        {
            vistaControlada.txtNombreEmpresa.Clear();
            vistaControlada.txtNombreContacto.Clear();
            vistaControlada.txtTelefono.Clear();
            vistaControlada.txtEmail.Clear();
            vistaControlada.txtDireccion.Clear();
            vistaControlada.dtpFechaRegistro.Value = DateTime.Now;
        }

        // Validaciones para los campos del formulario
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

        // Otras validaciones (similares a las del controlador de añadir)
        private void ValidateLength(TextBox textBox, int maxLength)
        {
            if (textBox.Text.Length > maxLength)
            {
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = textBox.Text.Length;
                MessageBox.Show($"El campo no puede exceder {maxLength} caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidateLettersOnly(TextBox textBox, int maxLength)
        {
            string input = textBox.Text;
            string lettersOnly = System.Text.RegularExpressions.Regex.Replace(input, @"[^a-zA-Z\s]", "");

            if (input != lettersOnly)
            {
                MessageBox.Show("Este campo solo permite letras.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = lettersOnly;
                textBox.SelectionStart = lettersOnly.Length;
            }

            ValidateLength(textBox, maxLength);
        }

        private void ValidatePhoneInput(object sender, KeyPressEventArgs e)
        {
            TextBox txtTelefono = (TextBox)sender;

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' || txtTelefono.Text.Length >= 12)
            {
                e.Handled = true;
            }
        }

        private void ValidatePhoneLength(object sender, EventArgs e)
        {
            TextBox txtTelefono = (TextBox)sender;
            if (txtTelefono.Text.Length > 12)
            {
                txtTelefono.Text = txtTelefono.Text.Substring(0, 12);
                txtTelefono.SelectionStart = 12;
            }
        }

        private bool ValidateEmail(TextBox emailTextBox)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
