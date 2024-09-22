using SistemaJoyería.Model.DAO;
using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.Suppliers
{
    public class ControllerFrmUpdateSuppliers
    {
        private FrmUpdateSuppliers vistaControlada;
        private UpdateSuppliersDAO suppliersDAO = new UpdateSuppliersDAO();
        private SupplierDTO supplier = new SupplierDTO();
        private int supplierID;

        public ControllerFrmUpdateSuppliers(string idBuena, FrmUpdateSuppliers vistaPasada)
        {
            this.vistaControlada = vistaPasada;

            // Convertir idBuena (string) a int y manejar la lógica de actualización
            if (int.TryParse(idBuena, out int idProveedor))
            {
                // Cargar datos y vincular botones
                LoadSupplierData(idProveedor);
                vistaPasada.btnActualizar.Click += (sender, e) => UpdateSupplier(idProveedor);
            }
            else
            {
                MessageBox.Show("ID de proveedor no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vistaPasada.Close();
            }

            // Vincular validaciones de campos a los eventos KeyPress y TextChanged
            vistaPasada.txtNombreEmpresa.KeyPress += ValidateLettersAndSpaces;
            vistaPasada.txtNombreContacto.KeyPress += ValidateLettersAndSpaces;
            vistaPasada.txtTelefono.KeyPress += ValidateNumbersOnly;
            vistaPasada.txtTelefono.TextChanged += (sender, e) => LimitPhoneLength(vistaPasada.txtTelefono);
        }

        // Validar que solo se ingresen letras y espacios
        private void ValidateLettersAndSpaces(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Bloquear la tecla si no es una letra o espacio
            }
        }

        // Validar que solo se ingresen números
        private void ValidateNumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Bloquear si no es un número o tecla de control (como backspace)
            }
        }

        // Limitar el campo de teléfono a 8 caracteres
        private void LimitPhoneLength(TextBox txtTelefono)
        {
            if (txtTelefono.Text.Length > 8)
            {
                txtTelefono.Text = txtTelefono.Text.Substring(0, 8);  // Limitar a los primeros 8 caracteres
                txtTelefono.SelectionStart = txtTelefono.Text.Length;  // Colocar el cursor al final del texto
            }
        }
        // Método para cargar los datos del proveedor en el formulario
        private void LoadSupplierData(int idProveedor)
        {
            // Obtener el proveedor utilizando el DAO
            SupplierDTO supplier = suppliersDAO.GetSupplierByID(idProveedor);

            // Verificar si el proveedor fue encontrado
            if (supplier != null)
            {
                // Asignar los valores obtenidos a los controles del formulario
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
                vistaControlada.Close();  // Cerrar el formulario si no se encuentra el proveedor
            }
        }

        // Método para actualizar el proveedor
        private void UpdateSupplier(int idProveedor)
        {
            // Validar los campos antes de proceder
            if (ValidateAllFields())
            {
                // Crear un objeto SupplierDTO con los datos actualizados
                SupplierDTO supplier = new SupplierDTO
                {
                    IDSupplier = idProveedor,
                    CompanyName = vistaControlada.txtNombreEmpresa.Text.Trim(),
                    ContactName = vistaControlada.txtNombreContacto.Text.Trim(),
                    DayAdded = vistaControlada.dtpFechaRegistro.Value,
                    Phone = vistaControlada.txtTelefono.Text.Trim(),
                    Email = vistaControlada.txtEmail.Text.Trim(),
                    Direction = vistaControlada.txtDireccion.Text.Trim()
                };

                // Llamar al DAO para actualizar el proveedor en la base de datos
                int result = suppliersDAO.UpdateSupplier(supplier);

                // Verificar si la actualización fue exitosa
                if (result > 0)
                {
                    MessageBox.Show("Proveedor actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vistaControlada.Close();  // Cerrar el formulario si la actualización fue exitosa
                }
                else
                {
                    MessageBox.Show("Error al actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método que valida que todos los campos estén correctamente llenos
        private bool ValidateAllFields()
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(vistaControlada.txtNombreEmpresa.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtNombreContacto.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtEmail.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato de correo electrónico
            if (!ValidateEmail(vistaControlada.txtEmail.Text))
            {
                MessageBox.Show("Formato de correo electrónico no válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;  // Si todo está correcto, devolver true
        }

        // Método para validar el correo electrónico
        private bool ValidateEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }
    }
}