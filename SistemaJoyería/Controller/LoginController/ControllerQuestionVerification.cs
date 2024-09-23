using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.View;

namespace SistemaJoyería.Controller.LoginController
{
    internal class ControllerQuestionVerification
    {
        FrmQuestionsLogin objVerifications;
        string username;


        public ControllerQuestionVerification(FrmQuestionsLogin vista)
        {
            objVerifications = vista;
            objVerifications.btnVerificarRespuestas.Click += new EventHandler(VerificarRespuestasDS);
            objVerifications.btnComeBack.Click += new EventHandler(ShowRecover);
            objVerifications.btnVerificarRespuestas.Click += new EventHandler(VerificarRespuestasDS);
        }

        public void VerificarRespuestasDS(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            DAOSecurityQuestions SecurityResults = new DAOSecurityQuestions();
            SecurityResults.Usuario = objVerifications.txtUsuario.Text.Trim();
            SecurityResults.Pregunta1 = objVerifications.txtRespuesta1.Text.Trim();
            SecurityResults.Pregunta2 = objVerifications.txtRespuesta1.Text.Trim();
            SecurityResults.Pregunta3 = objVerifications.txtRespuesta3.Text.Trim();
            username = objVerifications.txtUsuario.Text.Trim();

            bool respuesta = SecurityResults.LeerRespuestas();


            if (!(string.IsNullOrEmpty(objVerifications.txtUsuario.Text.Trim()) ||
             string.IsNullOrEmpty(objVerifications.txtRespuesta3.Text.Trim()) || string.IsNullOrEmpty(objVerifications.txtRespuesta1.Text.Trim()) || string.IsNullOrEmpty(objVerifications.txtRespuesta3.Text.Trim())))
            {
                if (respuesta == true)
                {
                    MessageBox.Show("Las respuestas son correctas", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objVerifications.Hide();
                    FrmChangePassword CambiarContra = new FrmChangePassword(username);
                    CambiarContra.Show();
                }
                else
                {
                    MessageBox.Show("Las respuestas son incorrectas, revise las respuestas que esta ingresando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Necesita llenar los campos para cambiar su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
