using System;
using System.Windows.Forms;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.LoginView;
using SistemaJoyería.View.ClientsView;
using SistemaJoyería.View.DashboardView;

namespace SistemaJoyería.Controller.LoginController
{
    public class LoginController
    {
        FrmLogin objLogin;
        int intentos = 0;

        // El constructor agarra los eventos de la vista
        public LoginController(FrmLogin Vista)
        {
            objLogin = Vista;

            objLogin.btnIngresar.Click += new EventHandler(DatosAcceso);
            objLogin.LinklblRecuperar.Click += new EventHandler(ShowMetods);
            objLogin.LinklblRegister.Click += new EventHandler(NewUser);

            // Deshabilitar copiar/pegar en los campos de usuario y contraseña
            objLogin.txtUsuario.KeyDown += new KeyEventHandler(DisableCopyPaste);
            objLogin.txtContraseña.KeyDown += new KeyEventHandler(DisableCopyPaste);

            // Validar que no se ingresen espacios en usuario y contraseña
            objLogin.txtUsuario.KeyPress += new KeyPressEventHandler(ValidateNoSpaces);
            objLogin.txtContraseña.KeyPress += new KeyPressEventHandler(ValidateNoSpaces);

            // Eliminar el menú contextual del clic derecho
            objLogin.txtUsuario.ContextMenu = new ContextMenu();
            objLogin.txtContraseña.ContextMenu = new ContextMenu();
        }

        // Método para validar que no se ingresen espacios
        private void ValidateNoSpaces(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Evitar que se ingrese el espacio
                MessageBox.Show("No se permiten espacios en el nombre de usuario o la contraseña.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpiar el campo si contiene un espacio
                if (sender is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        // Método para deshabilitar la funcionalidad de copiar/pegar
        private void DisableCopyPaste(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.V || e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                MessageBox.Show("Copiar y pegar no está permitido por razones de seguridad.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (sender is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        // Redireccionar al formulario de registro de nuevos usuarios
        public void NewUser(object sender, EventArgs e)
        {
            objLogin.Hide();
            FrmRegisterNewUser openForm = new FrmRegisterNewUser();
            openForm.Show();
        }

        // Método para manejar el acceso al sistema
        private void DatosAcceso(object sender, EventArgs e)
        {
            // Validar que los campos de usuario y contraseña no estén vacíos
            if (string.IsNullOrWhiteSpace(objLogin.txtUsuario.Text) || string.IsNullOrWhiteSpace(objLogin.txtContraseña.Text))
            {
                MessageBox.Show("Usuario y Contraseña no pueden estar vacíos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creando objeto de la clase DAOLogin
            DAOLogin DAOData = new DAOLogin();

            // Utilizar objeto DAO para invocar getter y setter del DTO
            DAOData.LoginName1 = objLogin.txtUsuario.Text.Trim();
            DAOData.Password1 = objLogin.txtContraseña.Text.Trim();

            // Invocar el método de validación de inicio de sesión en el DAO
            bool answer = DAOData.LoginValidation();

            if (answer)
            {
                MessageBox.Show("Inicio de sesión correcto", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDashboardView frmDashboardView = new FrmDashboardView();
                objLogin.Hide();
                frmDashboardView.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                intentos++;

                if (intentos == 3)
                {
                    MessageBox.Show("Lamento decirle que ha sido bloqueado, intente de nuevo más tarde.", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    objLogin.Close();
                }
            }
        }

        // Redirigir al formulario de recuperación de contraseña
        void ShowMetods(object sender, EventArgs e)
        {
            FrmRecoverPassword frmRecoverPassword = new FrmRecoverPassword();
            objLogin.Hide();
            frmRecoverPassword.Show();
        }
    }
}
