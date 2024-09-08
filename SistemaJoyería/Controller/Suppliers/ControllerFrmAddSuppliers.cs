using SistemaJoyería.Model.DAO;
using SistemaJoyería.Model.DTO;
using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.Suppliers
{
    internal class ControllerFrmAddSuppliers
    {
        // Declaración de variables miembro
        private AddSuppliersDAO suppliersDAO = new AddSuppliersDAO(); // Objeto para acceder a la base de datos
        private SupplierDTO supplier = new SupplierDTO(); // Objeto para manejar los datos del proveedor
        private FrmAddSuppliers vistaControlada; // Referencia al formulario de agregar proveedores

        // Constructor del controlador
        public ControllerFrmAddSuppliers(FrmAddSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada;

            // Asignar manejadores de eventos a los controles del formulario
            vistaPasada.btnGuardar.Click += (sender, e) => RegisterSupplier(supplier);

            // Agregar validaciones para los campos de entrada
            vistaPasada.txtNombreEmpresa.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreEmpresa, 100);
            vistaPasada.txtNombreContacto.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreContacto, 100);
            vistaPasada.txtTelefono.KeyPress += (sender, e) => ValidateNumericInput(sender, e);
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);
            vistaPasada.txtDireccion.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtDireccion, 200);

            // Validar la fecha al cambiar su valor
            vistaPasada.dtpFechaRegistro.ValueChanged += (sender, e) => ValidateDate(vistaPasada.dtpFechaRegistro.Value);

            // Configurar el formulario para manejar eventos de teclado
            vistaControlada.KeyPreview = true;
            vistaControlada.KeyDown += Form_KeyDown;
        }

        // Método para registrar un nuevo proveedor
        public void RegisterSupplier(SupplierDTO supplier)
        {
            if (ValidateAllFields())
            {
                CreateSupplierDTO();
                int result = suppliersDAO.RegisterSupplier(supplier);
                if (result > 0)
                {
                    MessageBox.Show("Proveedor registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
        }

        // Método para crear un objeto SupplierDTO con los datos del formulario
        public SupplierDTO CreateSupplierDTO()
        {
            supplier.CompanyName = vistaControlada.txtNombreEmpresa.Text.Trim();
            supplier.ContactName = vistaControlada.txtNombreContacto.Text.Trim();
            supplier.Phone = vistaControlada.txtTelefono.Text.Trim();
            supplier.Email = vistaControlada.txtEmail.Text.Trim();
            supplier.Direction = vistaControlada.txtDireccion.Text.Trim();
            supplier.RegistrationDate = vistaControlada.dtpFechaRegistro.Value;
            return supplier;
        }

        // Método para limpiar todos los campos del formulario
        private void ClearFields()
        {
            vistaControlada.txtId.Clear();
            vistaControlada.txtNombreEmpresa.Clear();
            vistaControlada.txtNombreContacto.Clear();
            vistaControlada.txtTelefono.Clear();
            vistaControlada.txtEmail.Clear();
            vistaControlada.txtDireccion.Clear();
        }

        // Método para validar todos los campos antes de registrar
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

        // Método para validar la fecha de registro
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

        // Método para validar la longitud de los campos de texto
        private void ValidateLength(TextBox textBox, int maxLength)
        {
            if (textBox.Text.Length > maxLength)
            {
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = textBox.Text.Length;
                MessageBox.Show($"El campo no puede exceder {maxLength} caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para validar que solo se ingresen números en el campo de teléfono
        private void ValidateNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Método para validar el formato del correo electrónico
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

        // Método para prevenir copiar y pegar en el formulario
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