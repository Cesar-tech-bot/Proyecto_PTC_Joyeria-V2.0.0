using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaJoyería.Controller.Suppliers
{
    internal class ControllerFrmUpdateSuppliers
    {
        FrmUpdateSuppliersView vistaControlada;
        string idBuena;
        UpdateSuppliersDAO updater = new UpdateSuppliersDAO();

        // Constructor del controlador
        public ControllerFrmUpdateSuppliers(string idPasada, FrmUpdateSuppliersView vistaPasada)
        {
            vistaControlada = vistaPasada;
            idBuena = idPasada;

            // Asigna el evento de clic al botón guardar
            vistaPasada.btnGuardar.Click += (sender, e) => ActualizarSupplier();

            // Agrega validaciones en tiempo real para cada campo
            vistaPasada.txtNombreEmpresa.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreEmpresa, 100);
            vistaPasada.txtNombreContacto.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreContacto, 100);
            vistaPasada.txtTelefono.KeyPress += (sender, e) => ValidateNumericInput(sender, e);
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);
            vistaPasada.txtDireccion.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtDireccion, 200);

            // Carga los datos del proveedor seleccionado
            updater.Get(vistaPasada, idPasada);
        }

        // Método para actualizar el proveedor
        public void ActualizarSupplier()
        {
            // Valida todos los campos antes de actualizar
            if (ValidateAllFields())
            {
                updater.Update(idBuena, vistaControlada);
                MessageBox.Show("Proveedor actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vistaControlada.Close();
            }
        }

        // Método para validar todos los campos
        private bool ValidateAllFields()
        {
            // Verifica que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(vistaControlada.txtNombreEmpresa.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtNombreContacto.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtEmail.Text) ||
                string.IsNullOrWhiteSpace(vistaControlada.txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Valida el formato del email
            if (!ValidateEmail(vistaControlada.txtEmail))
            {
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
                textBox.SelectionStart = textBox.Text.Length; // Coloca el cursor al final del texto
                MessageBox.Show($"El campo no puede exceder {maxLength} caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para validar que solo se ingresen números en el campo de teléfono
        private void ValidateNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número
            }
        }

        // Método para validar el formato del email
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
    }
}