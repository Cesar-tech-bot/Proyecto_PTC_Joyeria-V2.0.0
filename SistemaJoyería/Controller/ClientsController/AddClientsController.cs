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
            viewAdd.tbClientsName.KeyPress += new KeyPressEventHandler(TbClientsName_KeyPress);
            viewAdd.tbClientsSurname.KeyPress += new KeyPressEventHandler(TbClientsSurname_KeyPress);
            viewAdd.tbCellphoneN.KeyPress += new KeyPressEventHandler(TbCellphoneN_KeyPress);
            viewAdd.tbDuiDoc.KeyPress += new KeyPressEventHandler(TbDuiDoc_KeyPress);
            viewAdd.tbEmail.KeyPress += new KeyPressEventHandler(TbEmail_KeyPress);
            viewAdd.tbAddress.KeyPress += new KeyPressEventHandler(TbAddress_KeyPress);

        }

        void SaveRegister(object sender, EventArgs e)
        {
            if (!(//Validamos si los campos de nombres y apellidos no están vacios
                  string.IsNullOrEmpty(ObjAddCView.tbClientsName.Text.Trim()) ||
                  string.IsNullOrEmpty(ObjAddCView.tbClientsSurname.Text.Trim()) ||
                  //Ejecutamos el método de validación respectivo
                  !IsValidName(ObjAddCView.tbClientsName.Text.Trim()) ||
                  !IsValidName(ObjAddCView.tbClientsSurname.Text.Trim()) ||
                  //Ejecutamos el método de validación respectivo
                  !IsValidAge(ObjAddCView.dtpClientsBirthday.Value) ||
                  //Validamos si el campo no está vacio
                  string.IsNullOrEmpty(ObjAddCView.tbCellphoneN.Text.Trim()) ||
                  //Ejecutamos el método de validación respectivo
                  !IsValidPhoneNumber(ObjAddCView.tbCellphoneN.Text.Trim()) ||
                  //Validamos si el campo no está vacio
                  string.IsNullOrEmpty(ObjAddCView.tbDuiDoc.Text.Trim()) ||
                  //Ejecutamos el método de validación respectivo
                  !IsValidDuiDoc(ObjAddCView.tbDuiDoc.Text.Trim()) ||
                  //Validamos si el campo no está vacio
                  string.IsNullOrEmpty(ObjAddCView.tbEmail.Text.Trim()) ||
                  //Validamos si el campo no está vacio
                  string.IsNullOrEmpty(ObjAddCView.tbAddress.Text.Trim()) ||
                  //Validamos que sobre pase los 100 digitos
                  ObjAddCView.tbAddress.Text.Length > 100 ||
                  //Ejecutamos el método de validación respectivo
                  IsNumeric(ObjAddCView.tbAddress.Text.Trim())))
            {
                //Se crea un objeto de tipo ClientsDAO
                AddClientsDAO daoClient = new AddClientsDAO();

                //se mandan valores de la vista hacia el DTO de clientes
                daoClient.FirstName = ObjAddCView.tbClientsName.Text.Trim();
                daoClient.LastName = ObjAddCView.tbClientsSurname.Text.Trim();
                daoClient.BirthDate = ObjAddCView.dtpClientsBirthday.Value;
                daoClient.Phone = ObjAddCView.tbCellphoneN.Text.Trim();
                daoClient.IdentityDocument = ObjAddCView.tbDuiDoc.Text.Trim();
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

        // Métodos de validación 
        private bool IsValidName(string text)
        {
            //Verificamos si el texto solo contiene letras y opcionalmente un espacio entre dos palabras
            return Regex.IsMatch(text, @"^[a-zA-Z]+( [a-zA-Z]+)?$");
        }

        private bool IsValidAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }
            //Verificamos si la edad es mayor o igual a 18 años 
            return age >= 18;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            //Verificamos si el número de teléfono contiene solo dígitos con un máximo de 18 caracteres
            return Regex.IsMatch(phoneNumber, @"^\d{1,18}$");
        }

        private bool IsValidDuiDoc(string duiDoc)
        {
            //Verificamos si el DUI está en el formato correcto: 8 dígitos, un guion y un dígito
            return Regex.IsMatch(duiDoc, @"^\d{8}-\d$");
        }

        private bool IsNumeric(string text)
        {
            //Verificamos si el texto contiene solo dígitos
            return text.All(char.IsDigit);
        }
        
        //Eventos del View
        public void CleanInformation(object sender, EventArgs e)
        {
            //Limpiamos todos los campos del formulario
            ObjAddCView.tbClientsName.Clear();
            ObjAddCView.tbClientsSurname.Clear();
            ObjAddCView.dtpClientsBirthday.Value = DateTime.Now;
            ObjAddCView.tbCellphoneN.Clear();
            ObjAddCView.tbDuiDoc.Clear();
            ObjAddCView.tbEmail.Clear();
            ObjAddCView.tbAddress.Clear();
        }

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

        private void TbCellphoneN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y sin espacios
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && (sender as TextBox).Text.Length >= 8)
            {
                e.Handled = true;
            }
        }

        private void TbDuiDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y un guion, sin espacios
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            string currentText = (sender as TextBox).Text;

            // Evitar más de 9 números y un guion
            if (char.IsDigit(e.KeyChar) && currentText.Replace("-", "").Length >= 9)
            {
                e.Handled = true;
            }

            // Evitar más de un guion
            if (e.KeyChar == '-' && currentText.Contains("-"))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ' ')
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

