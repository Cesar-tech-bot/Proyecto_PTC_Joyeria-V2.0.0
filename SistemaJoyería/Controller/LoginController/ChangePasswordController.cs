using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.LoginController
{
    internal class ChangePasswordController
    {
        FrmChangePassword objCambiarContra;

        //el constructor agarra los eventos de la vista
        public ChangePasswordController(FrmChangePassword Vista, string user)
        {
            objCambiarContra = Vista;
            objCambiarContra.txtconfirmarusuario.Text = user;
            objCambiarContra.BtnCambiarContra.Click += new EventHandler(CambiarContra);
        }
        private void CambiarContra(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string ConfirRamdomCode = objCambiarContra.txtPin.Text;
            string NuevaContra = objCambiarContra.txtNuevaContra.Text;
            string ConfirmarContra = objCambiarContra.txtConfirmarContra.Text;

            DAOCambiarClave DAOdatacambiarClave = new DAOCambiarClave();
            CommonClassesController commonClasses = new CommonClassesController();
            DAOdatacambiarClave.Password1 = objCambiarContra.txtNuevaContra.Text;
            DAOdatacambiarClave.LoginName1 = objCambiarContra.txtconfirmarusuario.Text;
            string cadenaencriptada = commonClasses.ComputeSha256Hash(objCambiarContra.txtNuevaContra.Text);
            string cadenaencriptada2 = commonClasses.ComputeSha256Hash(objCambiarContra.txtConfirmarContra.Text);

            DAOdatacambiarClave.Password1 = commonClasses.ComputeSha256Hash(objCambiarContra.txtNuevaContra.Text);

            if (ControllerRecuperarPorCorreo.codigoAleatorio == ConfirRamdomCode && cadenaencriptada == cadenaencriptada2)
            {
                DAOdatacambiarClave.DAOCambiarclave();


                MessageBox.Show("La clave se ha cambiado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objCambiarContra.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
            else
            {

                MessageBox.Show("La clave no se ha podido cambiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objCambiarContra.Close();
            }

        }
    }
}
