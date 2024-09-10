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
            
        }
    }
}
