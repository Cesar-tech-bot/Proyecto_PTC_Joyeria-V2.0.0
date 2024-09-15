using SistemaJoyería.View;
using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Controller.LoginController
{
    internal class RecoverPasswordController
    {
        FrmRecoverPassword objLogin;

        //el constructor agarra los eventos de la vista
        public RecoverPasswordController(FrmRecoverPassword Vista)
        {
            objLogin = Vista;
            objLogin.btnPreguntas.Click += new EventHandler(AbrirPreguntas);
        }

        void ComeBack(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Hide();
            frmLogin.Show();
        }

        public void AbrirPreguntas(object sender, EventArgs e)
        {
            FrmQuestionsLogin opneFrom = new FrmQuestionsLogin();
            opneFrom.Show();
            objLogin.Hide();
        }

    }
}
