using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.ClientsView;
using SistemaJoyería.View.UsersView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.UserController
{
    public class UserViewController
    {
        FrmUserView ObjView;

        public UserViewController(FrmUserView view)
        {
            ObjView = view;
            view.Load += new EventHandler(InitialCharge);
            //Eventos del CRUD (Read, Delete, Update)
            view.btnUpdate.Click += new EventHandler(UpdateRegister);
            ////Eventos
            view.btnRefresh.Click += new EventHandler(RefreshPage);
            view.btnClear.Click += new EventHandler(ClearUpdateZone);
            view.btnSearchUser.Click += new EventHandler(SearcUsersEvent);
            ////Sección de Validaciones
            view.dgvUser.CellClick += new DataGridViewCellEventHandler(SelectUser);
            //view.txtUpdateUserEmail.KeyPress += new KeyPressEventHandler(TbUEmail_KeyPress);
            DisableCopyCutPaste(view.txtUpdateUserName);
            DisableCopyCutPaste(view.txtUpdateUserPassword);
            DisableCopyCutPaste(view.txtUpdateUserEmail);
            DisableCopyCutPaste(view.txtSearchUser);
        }

        void InitialCharge(object sender, EventArgs e)
        {
            ShowDGVUsers();
            ReadOnly(sender, e);
        }

        void ReadOnly(object sender, EventArgs e)
        {
            ObjView.txtUpdateUserName.ReadOnly = true;
            ObjView.txtUpdateUserEmail.ReadOnly = true;
            ObjView.txtUpdateUserPassword.ReadOnly = true;
            ObjView.cmbRolUser.Enabled = false;
            ObjView.txtUpdateEstado.ReadOnly = true;
            ObjView.txtIdUser.ReadOnly = true;

        }

        void NotReadOnly(object sender, EventArgs e)
        {
            ObjView.txtUpdateUserName.ReadOnly = false;
            ObjView.txtUpdateUserEmail.ReadOnly = false;
            ObjView.txtUpdateUserPassword.ReadOnly = false;
            ObjView.cmbRolUser.Enabled = true;
        }


        //CRUD
        public void ShowDGVUsers()
        {
            //Creamos un objeto de tipo DAO
            UserViewDAO daoVC = new UserViewDAO();
            //Ejecutamos el método para obtener los datos y los almacenamos en un DataSet
            DataSet ds = daoVC.ShowDGV();
            //Asignamos la tabla del DataSet como la fuente de datos para el DataGridView
            ObjView.dgvUser.DataSource = ds.Tables["v_Users"];
        }

        

        //Validar el patrón del correo
        private bool Emailverifaction(string email)

        {
            // Definimos el patrón para validar el formato de correo electrónico.
            // - El correo comience con uno o más caracteres que no sean @ ni espacios.
            // - Siga con el símbolo @.
            // - Continúe con uno o más caracteres que no sean @ ni espacios, representando el dominio.
            // - Contenga un punto (.) separando el dominio de la extensión.
            // - Termine con uno o más caracteres que no sean @ ni espacios, representando la extensión del dominio (por ejemplo, com, org).
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Utilizamos Regex.IsMatch para verificar si el correo electrónico coincide con el patrón definido.
            // Si el correo electrónico tiene el formato correcto, IsMatch devuelve true.
            // Si el correo electrónico no coincide con el patrón, devuelve false.
            return Regex.IsMatch(email, emailPattern);
        }
        void UpdateRegister(object sender, EventArgs e)
        {
            // Se crea variable para cada TB y CMB
            string ID = ObjView.txtIdUser.Text.Trim();
            string UserName = ObjView.txtUpdateUserName.Text.Trim();
            string PassWord = ObjView.txtUpdateUserPassword.Text.Trim();
            string Email = ObjView.txtUpdateUserEmail.Text.Trim();
            string Estado = ObjView.txtUpdateEstado.Text.Trim();
            string Rol = ObjView.cmbRolUser.Text.Trim();

            // Validamos si los campos requeridos no están vacíos
            if (!(string.IsNullOrEmpty(UserName) ||
                  string.IsNullOrEmpty(PassWord) ||
                  string.IsNullOrEmpty(Email) || !Emailverifaction(Email)))
            {
                // Validamos que Rol sea un número válido antes de actualizar
                if (int.TryParse(Rol, out int rolId))
                {
                    // Si todas las validaciones pasan, actualizamos el registro
                    UserViewDAO daoUpdate = new UserViewDAO();
                    daoUpdate.IDUser1 = int.Parse(ID);
                    daoUpdate.UserName1 = UserName;
                    daoUpdate.Password1 = PassWord;
                    daoUpdate.UserEmail1 = Email;
                    daoUpdate.Estado1 = Estado;
                    daoUpdate.IdRoles1 = rolId;

                    int retorno = daoUpdate.UpdateUser();
                    if (retorno == 1)
                    {
                        MessageBox.Show("El Usuario seleccionado fue actualizado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDGVUsers();
                        ClearUpdateZone(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("El Usuario seleccionado no pudo ser actualizado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El rol seleccionado es inválido", "Revisa la información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario no seleccionado o datos faltantes o incorrectos, favor verificar datos ingresados", "Revisa la información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        void ClearUpdateZone(object sender, EventArgs e)
        {
            ObjView.txtUpdateUserName.Clear();
            ObjView.txtUpdateUserPassword.Clear();
            ObjView.txtUpdateUserEmail.Clear();
            ObjView.cmbRolUser.Items.Clear();
            ObjView.txtIdUser.Clear();
            ReadOnly(sender, e);
        }
        void SelectUser(object sender, DataGridViewCellEventArgs e)
        {
            int pos = ObjView.dgvUser.CurrentRow.Index;

            ObjView.txtIdUser.Text = ObjView.dgvUser[0, pos].Value.ToString();
            NotReadOnly(sender, e);
            ObjView.txtUpdateUserName.Text = ObjView.dgvUser[1, pos].Value.ToString();
            ObjView.txtUpdateUserPassword.Text = (ObjView.dgvUser[2, pos].Value.ToString());
            ObjView.txtUpdateUserEmail.Text = ObjView.dgvUser[3, pos].Value.ToString();
            ObjView.txtUpdateEstado.Text = ObjView.dgvUser[4, pos].Value.ToString();
            ObjView.cmbRolUser.Text = ObjView.dgvUser[5, pos].Value.ToString();
        }
        void RefreshPage(object sender, EventArgs e)
        {
            ShowDGVUsers();
        }

        public void SearchUsers(object sender, KeyPressEventArgs e)
        {
            SearchUsersController();
        }
        //Buscar productos
        public void SearcUsersEvent(object sender, EventArgs e) { SearchUsersController(); }
        void SearchUsersController()
        {
            UserViewDAO userViewDAO = new UserViewDAO();
            DataSet ds = userViewDAO.SearchUser(ObjView.txtSearchUser.Text.Trim());
            ObjView.dgvUser.DataSource = ds.Tables["v_Users"];
        }
        private void DisableCopyCutPaste(TextBox textBox)
        {
            // Deshabilitamos el menú contextual del TextBox
            textBox.ContextMenu = new ContextMenu();

            // Capturamos el evento KeyDown para detectar si se intenta copiar, cortar o pegar con atajos de teclado
            textBox.KeyDown += (sender, e) =>
            {
                // Verificamos si se está intentando copiar (Ctrl + C), cortar (Ctrl + X), o pegar (Ctrl + V)
                if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
                {
                    e.SuppressKeyPress = true; // Suprimimos la tecla para evitar la acción
                }
            };
        }
    }
}







