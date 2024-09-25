using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaJoyería.Model.DAO;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using SistemaJoyería.View.LoginView;
using SistemaJoyería.View.ClientsView;
using SistemaJoyería.View.DashboardView;
using System.Text.RegularExpressions;
using System.ComponentModel;
using TextBox = System.Windows.Forms.TextBox;

namespace SistemaJoyería.Controller.LoginController
{
    public class LoginController
    {
        private FrmLogin objLogin;
        private int intentos = 0;
        private const int MAX_INTENTOS = 3;
        private List<string> commonPasswords = new List<string> { "123456", "password", "qwerty" }; // Agrega más contraseñas comunes
        private Timer passwordValidationTimer;

        public LoginController(FrmLogin Vista)
        {
            objLogin = Vista;
            objLogin.btnIngresar.Click += new EventHandler(DatosAcceso);
            objLogin.LinklblRecuperar.Click += new EventHandler(ShowMetods);
            objLogin.LinklblRegister.Click += new EventHandler(NewUser);

            // Deshabilitar copiar/pegar para campos de usuario y contraseña
            objLogin.txtUsuario.KeyDown += new KeyEventHandler(DisableCopyPaste);
            objLogin.txtContraseña.KeyDown += new KeyEventHandler(DisableCopyPaste);

            // Deshabilitar menú contextual del clic derecho
            objLogin.txtUsuario.ContextMenu = new ContextMenu();
            objLogin.txtContraseña.ContextMenu = new ContextMenu();

            // Cambiar TextChanged por Validating para el nombre de usuario
            objLogin.txtUsuario.Validating += new CancelEventHandler(ValidateUsername);

            // Configurar el temporizador para la validación de la contraseña
            passwordValidationTimer = new Timer();
            passwordValidationTimer.Interval = 1000; // 1 segundo
            passwordValidationTimer.Tick += new EventHandler(ValidatePassword);

            objLogin.txtContraseña.TextChanged += new EventHandler(StartPasswordValidationTimer);
        }

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

        private void StartPasswordValidationTimer(object sender, EventArgs e)
        {
            passwordValidationTimer.Stop();
            passwordValidationTimer.Start();
        }

        private void ValidateUsername(object sender, CancelEventArgs e)
        {
            string username = objLogin.txtUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            if (username.Length < 4 || username.Length > 20)
            {
                MessageBox.Show("El nombre de usuario debe tener entre 4 y 20 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("El nombre de usuario solo puede contener letras, números y guiones bajos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
        }

        private void ValidatePassword(object sender, EventArgs e)
        {
            passwordValidationTimer.Stop();

            string password = objLogin.txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("La contraseña no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra minúscula, una mayúscula, un número y un carácter especial.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (commonPasswords.Contains(password.ToLower()))
            {
                MessageBox.Show("Esta contraseña es demasiado común. Por favor, elija una más segura.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void NewUser(object sender, EventArgs e)
        {
            objLogin.Hide();
            FrmRegisterNewUser openForm = new FrmRegisterNewUser();
            openForm.Show();
        }

        private void DatosAcceso(object sender, EventArgs e)
        {
            DAOLogin DAOData = new DAOLogin();
            CommonClassesController common = new CommonClassesController();

            string username = objLogin.txtUsuario.Text.Trim();
            string password = objLogin.txtContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DAOData.LoginName1 = username;
            DAOData.Password1 = common.ComputeSha256Hash(password);

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
                intentos++;
                MessageBox.Show($"Los datos son incorrectos. Intento {intentos} de {MAX_INTENTOS}", "Error al iniciar sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (intentos >= MAX_INTENTOS)
                {
                    MessageBox.Show("Ha excedido el número máximo de intentos. Su cuenta ha sido bloqueada temporalmente.",
                        "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    // Implementar lógica de bloqueo de cuenta aquí
                    objLogin.Close();
                }
            }
        }

        void ShowMetods(object sender, EventArgs e)
        {
            FrmRecoverPassword frmRecoverPassword = new FrmRecoverPassword();
            objLogin.Hide();
            frmRecoverPassword.Show();
        }
    }
}
