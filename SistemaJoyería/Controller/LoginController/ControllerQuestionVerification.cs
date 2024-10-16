using SistemaJoyería.View.LoginView;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaJoyería.Model.DAO;

namespace SistemaJoyería.Controller.LoginController
{
    internal class ControllerQuestionVerification
    {
        private FrmQuestionsLogin objVerifications;
        private string username;

        public ControllerQuestionVerification(FrmQuestionsLogin vista)
        {
            objVerifications = vista;
            objVerifications.btnVerificarRespuestas.Click += new EventHandler(VerificarRespuestasDS);
            objVerifications.btnComeBack.Click += new EventHandler(ShowRecover);
        }

        public void VerificarRespuestasDS(object sender, EventArgs e)
        {
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