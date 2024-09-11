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
    internal class ControllerFrmAddSuppliers
    {
        private AddSuppliersDAO suppliersDAO = new AddSuppliersDAO();
        private SupplierDTO supplier = new SupplierDTO();
        private FrmAddSuppliers vistaControlada;

        public ControllerFrmAddSuppliers(FrmAddSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada;

            vistaControlada.Load += (sender, e) => vistaControlada.txtNombreEmpresa.Focus();

            vistaPasada.btnGuardar.Click += (sender, e) => RegisterSupplier(supplier);
            vistaPasada.btnLimpiar.Click += (sender, e) => ClearFields();

            vistaPasada.txtNombreEmpresa.TextChanged += (sender, e) => ValidateLettersOnly(vistaPasada.txtNombreEmpresa, 20);
            vistaPasada.txtNombreContacto.TextChanged += (sender, e) => ValidateLettersOnly(vistaPasada.txtNombreContacto, 15);
            vistaPasada.dtpFechaRegistro.ValueChanged += (sender, e) => ValidateDate(vistaPasada.dtpFechaRegistro.Value);
            vistaPasada.txtTelefono.KeyPress += ValidatePhoneInput;
            vistaPasada.txtTelefono.TextChanged += ValidatePhoneLength;
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);
            vistaPasada.txtDireccion.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtDireccion, 150);

            vistaControlada.KeyPreview = true;
            vistaControlada.KeyDown += Form_KeyDown;
        }

        public void RegisterSupplier(SupplierDTO supplier)
        {
            if (ValidateAllFields())
            {
                CreateSupplierDTO();
                try
                {
                    int result = suppliersDAO.RegisterSupplier(supplier);
                    if (result > 0)
                    {
                        MessageBox.Show("Proveedor registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                catch (SqlException ex)
                {
                    HandleSqlException(ex);
                }
            }
        }

        private void HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation
            {
                if (ex.Message.Contains("CompanyName"))
                {
                    MessageBox.Show("El nombre de la empresa ya existe.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("ContactName"))
                {
                    MessageBox.Show("El nombre del contacto ya existe.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Phone"))
                {
                    MessageBox.Show("El número de teléfono ya existe.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Email"))
                {
                    MessageBox.Show("El correo electrónico ya existe.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al registrar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al registrar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SupplierDTO CreateSupplierDTO()
        {
            supplier.CompanyName = vistaControlada.txtNombreEmpresa.Text.Trim();
            supplier.ContactName = vistaControlada.txtNombreContacto.Text.Trim();
            supplier.DayAdded = vistaControlada.dtpFechaRegistro.Value;
            supplier.Phone = vistaControlada.txtTelefono.Text.Trim();
            supplier.Email = vistaControlada.txtEmail.Text.Trim();
            supplier.Direction = vistaControlada.txtDireccion.Text.Trim();
            return supplier;
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

            if (!ValidateDate(vistaControlada.dtpFechaRegistro.Value))
            {
                return false;
            }

            return true;
        }

        private bool ValidateDate(DateTime selectedDate)
        {
            DateTime currentDate = DateTime.Now;
            DateTime maxDate = currentDate.AddYears(1);

            if (selectedDate < currentDate.Date || selectedDate > maxDate.Date)
            {
                MessageBox.Show($"La fecha debe ser hoy o dentro de un año a partir de hoy.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"El campo no puede exceder {maxLength} caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidateLettersOnly(TextBox textBox, int maxLength)
        {
            string input = textBox.Text;
            string lettersOnly = Regex.Replace(input, @"[^a-zA-Z\s]", "");

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
            if (!Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("No se permite copiar o pegar en este formulario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}