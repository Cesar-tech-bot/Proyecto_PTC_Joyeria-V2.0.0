


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




namespace SistemaJoyería.Controller.LoginController
{
    public class LoginController
    {


        FrmLogin objLogin;

        //el constructor agarra los eventos de la vista
        public LoginController(FrmLogin Vista)
        {
            objLogin = Vista;

            objLogin.btnIngresar.Click += new EventHandler(DatosAcceso);
            objLogin.LinklblRecuperar.Click += new EventHandler(ShowMetods);
        }

        int intentos = 0;
        private void DatosAcceso(object sender, EventArgs e)
        {
            //Creando objeto de clase daologin
            DAOLogin DAOData = new DAOLogin();
            CommonClassesController common = new CommonClassesController();
            //utilizar objeto dao para invocar getter y setter del dto
            DAOData.LoginName1 = objLogin.txtUsuario.Text.Trim();
            //string cadenaencriptada = common.ComputeSha256Hash
            DAOData.Password1 = (objLogin.txtContraseña.Text.Trim());
            //invocar metodo login el contenido en el dao
            bool answer = DAOData.LoginValidation();

            if (answer == true)
            {               
                //FrmHomePage frmHomePage = new FrmHomePage();
                //frmHomePage.Show();
                MessageBox.Show("Inicio de sesión correcto", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDashboardView frmDashboardView = new FrmDashboardView();
                objLogin.Hide();
                frmDashboardView.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos", "Error al iniciar sesion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                intentos++;

                if (intentos == 3)
                {
                    MessageBox.Show("Lamento decirle que ha sido bloqueado, intente de nuevo mas tarde",
                        "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
