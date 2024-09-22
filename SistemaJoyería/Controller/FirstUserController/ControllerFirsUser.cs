using SistemaJoyería.Controller.LoginController;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.FirstUse;
using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaJoyería.Controller.FirstUserController
{
    internal class ControllerFirsUser
    {
        FrmFirstUser objFirstUSer;

        public ControllerFirsUser(FrmFirstUser vista)
        {
            objFirstUSer = vista;
        }

        public void NewUser()
        {
            if (objFirstUSer == null)
            {
                DAOLogin DAORegistrar = new DAOLogin();
                CommonClassesController commonClasses = new CommonClassesController();
                DAORegistrar.LoginName1 = objFirstUSer.txtUsuario.Text.Trim();
                string contra = objFirstUSer.txtContra.Text.Trim();
                string confirmCOntra = objFirstUSer.txtConfirmContra.Text.Trim();
                DAORegistrar.UserEmail1 = objFirstUSer.txtCorreo.Text.Trim();
                if (contra == confirmCOntra)
                {
                    DAORegistrar.Password1 = commonClasses.ComputeSha256Hash(objFirstUSer.txtContra.Text.Trim());
                    

                    int ValorRetornadio = DAORegistrar.RegistrarPrimerUsuario();
                    if (ValorRetornadio == 1)
                    {
                        MessageBox.Show("Usuario Registrado Exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objFirstUSer.Hide();
                        FrmRegisterQuestions openForm = new FrmRegisterQuestions();
                        openForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario NO Registrado ", "Proceso Interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        }
        
    }
}
