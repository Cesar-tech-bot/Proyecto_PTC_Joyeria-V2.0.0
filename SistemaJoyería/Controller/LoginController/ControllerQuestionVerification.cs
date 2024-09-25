using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaJoyería.Model.DAO;

namespace SistemaJoyería.Controller.LoginController
{
    internal class ControllerQuestionVerification
    {
        private FrmQuestionsLogin objVerifications;
        private string username;
        private List<string> validJewels;
        private List<string> validColors;

        public ControllerQuestionVerification(FrmQuestionsLogin vista)
        {
            objVerifications = vista;
            objVerifications.btnVerificarRespuestas.Click += new EventHandler(VerificarRespuestasDS);
            objVerifications.btnComeBack.Click += new EventHandler(ShowRecover);

            // Deshabilitar copiar y pegar en todos los TextBox
            DisableCopyPaste(objVerifications.txtUsuario);
            DisableCopyPaste(objVerifications.txtRespuesta1);
            DisableCopyPaste(objVerifications.txtRespuesta2);
            DisableCopyPaste(objVerifications.txtRespuesta3);

            // Configurar validación para el campo de visitas
            objVerifications.txtRespuesta3.KeyPress += new KeyPressEventHandler(ValidateNumericInput);

            // Configurar validación para el campo de joyas
            validJewels = new List<string> { "diamante", "esmeralda", "rubí", "zafiro", "perla", "ópalo", "topacio", "amatista", "aguamarina", "diamante de 1 quilate", "esmeralda de 2 quilates", "rubí de 3 quilates" };
            objVerifications.txtRespuesta1.Leave += new EventHandler(ValidateJewel);

            // Configurar validación para el campo de colores
            validColors = new List<string> { "blanco", "negro", "rojo", "azul", "verde", "amarillo", "rosa", "púrpura", "plateado", "dorado" };
            objVerifications.txtRespuesta2.Leave += new EventHandler(ValidateColor);

            // Quitar el menú
            objVerifications.Menu = null;
        }

        private void DisableCopyPaste(TextBox textBox)
        {
            textBox.ShortcutsEnabled = false;
            textBox.ContextMenu = new ContextMenu();
        }

        private void ValidateNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidateJewel(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!validJewels.Contains(textBox.Text.ToLower()))
            {
                MessageBox.Show("Por favor, ingrese una joya válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidateColor(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!validColors.Contains(textBox.Text.ToLower()))
            {
                MessageBox.Show("Por favor, ingrese un color válido para joyas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        public void VerificarRespuestasDS(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(objVerifications.txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(objVerifications.txtRespuesta1.Text) ||
                string.IsNullOrWhiteSpace(objVerifications.txtRespuesta2.Text) ||
                string.IsNullOrWhiteSpace(objVerifications.txtRespuesta3.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand command = new SqlCommand();
            DAOSecurityQuestions SecurityResults = new DAOSecurityQuestions();
            SecurityResults.Usuario = objVerifications.txtUsuario.Text.Trim();
            SecurityResults.Pregunta1 = objVerifications.txtRespuesta1.Text.Trim();
            SecurityResults.Pregunta2 = objVerifications.txtRespuesta2.Text.Trim();
            SecurityResults.Pregunta3 = objVerifications.txtRespuesta3.Text.Trim();
            username = objVerifications.txtUsuario.Text.Trim();

            bool respuesta = SecurityResults.LeerRespuestas();
            if (respuesta)
            {
                MessageBox.Show("Las respuestas son correctas", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objVerifications.Hide();
                FrmChangePassword CambiarContra = new FrmChangePassword(username);
                CambiarContra.Show();
            }
            else
            {
                MessageBox.Show("Las respuestas son incorrectas, revise las respuestas que está ingresando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ShowRecover(object sender, EventArgs e)
        {
            FrmRecoverPassword frmRecoverPassword = new FrmRecoverPassword();
            objVerifications.Hide();
            frmRecoverPassword.Show();
        }
    }
}