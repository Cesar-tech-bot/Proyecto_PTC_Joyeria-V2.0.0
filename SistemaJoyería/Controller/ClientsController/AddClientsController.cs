using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.View.ClientsView;
using SistemaJoyería.Model.DAO;
using System.Text.RegularExpressions;
using System.Data;

namespace SistemaJoyería.Controller.ClientsController
{
    public class AddClientsController
    {
        FrmAddClients ObjAddCView;

        public AddClientsController(FrmAddClients viewAdd)
        {
            ObjAddCView = viewAdd;

            //Evento del CRUD (Create)
            viewAdd.btnOK.Click += new EventHandler(SaveRegister);
            //Eventos de Click
            viewAdd.btnDelete.Click += new EventHandler(CleanInformation);
            //Sección de validaciones de View
            viewAdd.dtpClientsBirthday.MinDate = DateTime.Now.AddYears(-60);
            viewAdd.tbClientsName.KeyPress += new KeyPressEventHandler(TbClientsName_KeyPress);
            viewAdd.tbClientsSurname.KeyPress += new KeyPressEventHandler(TbClientsSurname_KeyPress);
            //viewAdd.tbCellphoneN.KeyPress += new KeyPressEventHandler(TbCellphoneN_KeyPress);
            viewAdd.tbEmail.KeyPress += new KeyPressEventHandler(TbEmail_KeyPress);
            viewAdd.tbAddress.KeyPress += new KeyPressEventHandler(TbAddress_KeyPress);
        }

        void SaveRegister(object sender, EventArgs e)
        {
            if (!(// Validamos si los campos de nombres y apellidos no están vacíos
                  string.IsNullOrEmpty(ObjAddCView.tbClientsName.Text.Trim()) ||
                  string.IsNullOrEmpty(ObjAddCView.tbClientsSurname.Text.Trim()) ||
                  // Validamos si el campo de número de teléfono no está vacío
                  string.IsNullOrEmpty(ObjAddCView.mskCellphoneN.Text.Trim()) ||
                  // Validamos si el campo de DUI no está vacío
                  string.IsNullOrEmpty(ObjAddCView.mskDuiDoc.Text.Trim()) ||
                  // Validamos si el campo de correo electrónico no está vacío
                  string.IsNullOrEmpty(ObjAddCView.tbEmail.Text.Trim()) ||
                  // Validamos si el campo de dirección no está vacío
                  string.IsNullOrEmpty(ObjAddCView.tbAddress.Text.Trim()) ||
                  // Validamos que la dirección no sobrepase los 100 dígitos
                  ObjAddCView.tbAddress.Text.Length > 100))
            {
                // Se crea un objeto de tipo ClientsDAO
                AddClientsDAO daoClient = new AddClientsDAO();

                // Se mandan valores de la vista hacia el DTO de clientes
                daoClient.FirstName = ObjAddCView.tbClientsName.Text.Trim();
                daoClient.LastName = ObjAddCView.tbClientsSurname.Text.Trim();
                daoClient.BirthDate = ObjAddCView.dtpClientsBirthday.Value;
                daoClient.Phone = ObjAddCView.mskCellphoneN.Text.Trim();
                daoClient.IdentityDocument = ObjAddCView.mskDuiDoc.Text.Trim();
                daoClient.Email = ObjAddCView.tbEmail.Text.Trim();
                daoClient.AddressClient = ObjAddCView.tbAddress.Text.Trim();

                // Registrar cliente en la base de datos
                int resultado = daoClient.RegisterClients();
                if (resultado == 1)
                {
                    MessageBox.Show("El cliente fue registrado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjAddCView.Close();
                }
                else
                {
                    MessageBox.Show("El cliente no pudo ser registrado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos faltantes o incorrectos, complete el formulario con la información requerida", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Eventos del View
        public void CleanInformation(object sender, EventArgs e)
        {
            //Limpiamos todos los campos del formulario
            ObjAddCView.tbClientsName.Clear();
            ObjAddCView.tbClientsSurname.Clear();
            ObjAddCView.mskCellphoneN.Clear();
            ObjAddCView.mskDuiDoc.Clear();
            ObjAddCView.tbEmail.Clear();
            ObjAddCView.tbAddress.Clear();
            ObjAddCView.dtpClientsBirthday.Value = DateTime.Now;
        }

        //Validaciones
     
        //Restricciones del View
        private void TbClientsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y un único espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            // Evitar más de un espacio consecutivo
            if (e.KeyChar == ' ' && (sender as TextBox).Text.EndsWith(" "))
            {
                e.Handled = true;
            }
        }

        private void TbClientsSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y un único espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            // Evitar más de un espacio consecutivo
            if (e.KeyChar == ' ' && (sender as TextBox).Text.EndsWith(" "))
            {
                e.Handled = true;
            }
        }

        private void TbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Evitar cualquier espacio
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void TbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números y los caracteres básicos de dirección
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }

}

