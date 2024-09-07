using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaJoyería.Controller.Suppliers
{
    internal class ControllerFrmUpdateSuppliers
    {
        private FrmUpdateSuppliers vistaControlada;
        private string idBuena;
        private UpdateSuppliersDAO updater = new UpdateSuppliersDAO();

        // Constructor del controlador.
        public ControllerFrmUpdateSuppliers(string idPasada, FrmUpdateSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada;
            idBuena = idPasada;

            // Asigna el evento de clic al botón Guardar
            vistaPasada.btnGuardar.Click += (sender, e) => ActualizarSupplier();

            // Validaciones de los campos
            vistaPasada.txtNombreEmpresa.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreEmpresa, 100);
            vistaPasada.txtNombreContacto.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreContacto, 100);
            vistaPasada.txtTelefono.KeyPress += (sender, e) => ValidateNumericInput(sender, e);
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);
            vistaPasada.txtDireccion.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtDireccion, 200);

            // Agregar validación de copiar y pegar
            vistaControlada.KeyPreview = true;
            vistaControlada.KeyDown += Form_KeyDown;

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

        // Validar longitud de los campos de texto
        private void ValidateLength(TextBox textBox, int maxLength)
        {
            if (textBox.Text.Length > maxLength)
            {
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = textBox.Text.Length; // Coloca el cursor al final del texto
                MessageBox.Show($"El campo no puede exceder {maxLength} caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Validación de solo números
        private void ValidateNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validación del formato de correo electrónico
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

        // Validación de copiar y pegar
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