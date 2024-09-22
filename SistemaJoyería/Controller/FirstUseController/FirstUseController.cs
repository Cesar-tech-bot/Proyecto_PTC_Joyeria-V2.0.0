using SistemaJoyería.Controller.LoginController;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.FirstUseView;
using SistemaJoyería.View.FirstUseView;
using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.FirstUserController
{
    internal class ControllerFirstUser
    {
        FrmFirstUse objFirstUser;

        public ControllerFirstUser(FrmFirstUse vista)
        {
            objFirstUser = vista;
        }

        public void NewUser()
        {
            // Cambié la validación a != null para que se pueda ejecutar cuando el formulario no es null
            if (objFirstUser != null)
            {
                DAOLogin DAORegistrar = new DAOLogin();
                CommonClassesController commonClasses = new CommonClassesController();

                DAORegistrar.LoginName1 = objFirstUser.txtUsuario.Text.Trim();
                string contra = objFirstUser.txtContra.Text.Trim();
                string confirmContra = objFirstUser.txtConfirmContra.Text.Trim();
                DAORegistrar.UserEmail1 = objFirstUser.txtCorreo.Text.Trim();

                if (contra == confirmContra)
                {
                    DAORegistrar.Password1 = commonClasses.ComputeSha256Hash(objFirstUser.txtContra.Text.Trim());

                    int ValorRetornado = DAORegistrar.RegistrarPrimerUsuario();
                    if (ValorRetornado == 1)
                    {
                        MessageBox.Show("Usuario Registrado Exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objFirstUser.Hide();
                        FrmRegisterQuestions openForm = new FrmRegisterQuestions();
                        openForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario NO Registrado", "Proceso Interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Formulario no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
