using SistemaJoyería.Model.DAO;
using SistemaJoyeria.DAO;
using SistemaJoyeria.DAO;
using SistemaJoyería.View.LoginView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaJoyería.Controller.LoginController
{
    internal class ControllerRegisterNewUser
    {
        FrmRegisterNewUser objRegister;

        public ControllerRegisterNewUser(FrmRegisterNewUser vista)
        {
            objRegister = vista;
            objRegister.Load += new EventHandler(CargarCombos);
            objRegister.btnRegisterNewUser.Click += new EventHandler(RegistrarUsuario);
            objRegister.btnComeBack.Click += new EventHandler(ComeBack);
        }

        public void ComeBack(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            objRegister.Hide();
            frmLogin.Show();
        }

        public void CargarCombos(object sender, EventArgs e)
        {
            DAOLogin ObjRegister = new DAOLogin();
            DataSet dsRoleRegistro = ObjRegister.LlenarCombo("Roles");
            objRegister.cmbRol.DataSource = dsRoleRegistro.Tables["Roles"];
            objRegister.cmbRol.ValueMember = "idRol";
            objRegister.cmbRol.DisplayMember = "NombreRol";
        }

        public void RegistrarUsuario(object sender, EventArgs e)
        {
            DAOLogin DAORegistrar = new DAOLogin();
            CommonClassesController commonClasses = new CommonClassesController();
            DAORegistrar.LoginName1 = objRegister.txtUsuario.Text.Trim();
            string contra = objRegister.txtContra.Text.Trim();
            string confirmCOntra = objRegister.txtConfirmContra.Text.Trim();
            DAORegistrar.UserEmail1 = objRegister.txtCorreo.Text.Trim();
            if (contra == confirmCOntra)
            {
                DAORegistrar.Password1 = commonClasses.ComputeSha256Hash(objRegister.txtContra.Text.Trim());
                DAORegistrar.IdRol = (int)objRegister.cmbRol.SelectedValue;

                int ValorRetornadio = DAORegistrar.RegistrarUsuario();
                if (ValorRetornadio == 1)
                {
                    MessageBox.Show("Usuario Registrado Exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objRegister.Hide();
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
