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

        public ControllerFrmUpdateSuppliers(string idPasada, FrmUpdateSuppliersView vistaPasada)
        {
            vistaControlada = vistaPasada;
            idBuena = idPasada;

            vistaPasada.btnGuardar.Click += (sender, e) => ActualizarSupplier();

            // Validaciones en tiempo real para cada campo
            vistaPasada.txtNombreEmpresa.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreEmpresa, 100);
            vistaPasada.txtNombreContacto.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtNombreContacto, 100);
            vistaPasada.txtTelefono.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtTelefono, 15);
            vistaPasada.txtEmail.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtEmail, 100);
            vistaPasada.txtDireccion.TextChanged += (sender, e) => ValidateLength(vistaPasada.txtDireccion, 200);

            // Validaciones de tipo de carácter
            vistaPasada.txtNombreEmpresa.KeyPress += (sender, e) => ValidateAlphaNumericInput(sender, e);
            vistaPasada.txtNombreContacto.KeyPress += (sender, e) => ValidateAlphabeticInput(sender, e);
            vistaPasada.txtTelefono.KeyPress += (sender, e) => ValidateNumericInput(sender, e);
            vistaPasada.txtEmail.Leave += (sender, e) => ValidateEmail(vistaPasada.txtEmail);

            // Restricción de copiar, cortar y pegar
            vistaPasada.txtNombreEmpresa.KeyDown += (sender, e) => RestrictCopyPaste(e);
            vistaPasada.txtNombreContacto.KeyDown += (sender, e) => RestrictCopyPaste(e);
            vistaPasada.txtTelefono.KeyDown += (sender, e) => RestrictCopyPaste(e);
            vistaPasada.txtEmail.KeyDown += (sender, e) => RestrictCopyPaste(e);
            vistaPasada.txtDireccion.KeyDown += (sender, e) => RestrictCopyPaste(e);

            updater.Get(vistaPasada, idPasada);
        }

        public void ActualizarSupplier()
        {
            if (ValidateAllFields())
            {
                updater.Update(idBuena, vistaControlada);
                MessageBox.Show("Proveedor actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vistaControlada.Close();
            }
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

        // Validation 5: Length validation
        private void ValidateLength(TextBox textBox, int maxLength)
        {
            if (textBox.Text.Length > maxLength)
            {
                textBox.Text = textBox.Text.Substring(0, maxLength);
                textBox.SelectionStart = textBox.Text.Length;
                MessageBox.Show($"El campo no puede exceder {maxLength} caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Validation 6: Character type validation
        private void ValidateNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidateAlphabeticInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void ValidateAlphaNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
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

        // Validation 10: Copy, cut, paste restriction
        private void RestrictCopyPaste(KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.X || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("Las operaciones de copiar, cortar y pegar no están permitidas.", "Acción restringida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}