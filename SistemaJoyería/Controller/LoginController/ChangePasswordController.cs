using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Controller.LoginController
{
    internal class ChangePasswordController
    {
        FrmChangePassword objChangePS;

        //el constructor agarra los eventos de la vista
        public ChangePasswordController(FrmChangePassword Vista)
        {
            objChangePS = Vista;

        }
    }
}
