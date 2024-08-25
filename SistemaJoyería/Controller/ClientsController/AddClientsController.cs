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

            //Evento de Registrar (CRUD)
            viewAdd.btnOK.Click += new EventHandler(SaveRegister);
            //Sección Eventos del View
            viewAdd.btnDelete.Click += new EventHandler(ClearInformation);
            //Restricciones
            viewAdd.tbClientsName.KeyPress += new KeyPressEventHandler(TbClientsName_KeyPress);
            viewAdd.tbClientsSurname.KeyPress += new KeyPressEventHandler(TbClientsSurname_KeyPress);
            viewAdd.tbCellphoneN.KeyPress += new KeyPressEventHandler(TbCellphoneN_KeyPress);
            viewAdd.tbDuiDoc.KeyPress += new KeyPressEventHandler(TbDuiDoc_KeyPress);
            viewAdd.tbEmail.KeyPress += new KeyPressEventHandler(TbEmail_KeyPress);
            viewAdd.tbAddress.KeyPress += new KeyPressEventHandler(TbAddress_KeyPress);

        }

        //Método de Agregar Cliente (CRUD)
        void SaveRegister(object sender, EventArgs e)
        {//Creamos todas las validaciones

            if(!( //Validamos si están vacios los espacios (ClientsName y ClientsSurname)
                  string.IsNullOrEmpty(ObjAddCView.tbClientsName.Text.Trim()) ||
                  string.IsNullOrEmpty(ObjAddCView.tbClientsSurname.Text.Trim()) ||

                  //Usamos los métodos de validaciones para qué tipo de caracteres  permitirán, etc...
                  !IsValidName(ObjAddCView.tbClientsName.Text.Trim()) ||
                  !IsValidName(ObjAddCView.tbClientsSurname.Text.Trim()) ||

                  //Usamos el método de validación respectivo para ClientsBirhtday
                  !IsValidAge(ObjAddCView.dtpClientsBirthday.Value) ||

                  //Validamos si no está vacio el campo
                  string.IsNullOrEmpty(ObjAddCView.tbCellphoneN.Text.Trim()) ||
                  //Usamos el método de CellPhoneN
                  !IsValidPhoneNumber(ObjAddCView.tbCellphoneN.Text.Trim()) ||

                  //Validamos si no está vacio el campo
                  string.IsNullOrEmpty(ObjAddCView.tbDuiDoc.Text.Trim()) ||
                  //Usamos el método de DuiDoc
                  !IsValidDuiDoc(ObjAddCView.tbDuiDoc.Text.Trim()) ||
                  //Validamos si no está vacio el campo

                  string.IsNullOrEmpty(ObjAddCView.tbEmail.Text.Trim()) ||
                  //Validamos que no esté vacio el campo
                  //ObjAddCView.tbEmail.Text.Contains(" ") ||

                  string.IsNullOrEmpty(ObjAddCView.tbAddress.Text.Trim()) ||
                  //Ponemos un límiete de 100 carácteres
                  ObjAddCView.tbAddress.Text.Length > 100 ||
                  //Usamos el método respectivo parta Adress
                  IsNumeric(ObjAddCView.tbAddress.Text.Trim())))    
            {
                // Creamos un objeto de tipo ClientsDAO
                AddClientsDAO daoClient = new AddClientsDAO();

                // Enviamos los valores de la vista hacia el DTO de clientes
                daoClient.FirstName = ObjAddCView.tbClientsName.Text.Trim();
                daoClient.LastName = ObjAddCView.tbClientsSurname.Text.Trim();
                daoClient.BirthDate = ObjAddCView.dtpClientsBirthday.Value;
                daoClient.Phone = ObjAddCView.tbCellphoneN.Text.Trim();
                daoClient.IdentityDocument = ObjAddCView.tbDuiDoc.Text.Trim();
                daoClient.Email = ObjAddCView.tbEmail.Text.Trim();
                daoClient.AddressClient = ObjAddCView.tbAddress.Text.Trim();

                // Registramos el cliente en la base de datos
                int resultado = daoClient.InsertClients();
                if (resultado == 1)
                {
                    MessageBox.Show("El cliente fue registrado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   //Se refrezca el DGV
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

        //Métodos de validación 

        //Método que valida si un nombre o apellido es válido.
        private bool IsValidName(string text)
        {
          //Se asegura de que los nombres y apellidos solo contengan letras y opcionalmente un solo espacio entre dos palabras.
          return Regex.IsMatch(text, @"^[a-zA-Z]+( [a-zA-Z]+)?$");
        }

        //Método que valida si la fecha de nacimiento corresponde a una persona mayor de 18 años.
        private bool IsValidAge(DateTime birthDate)
        {
            //Calcula la edad restando el año actual del año de nacimiento y ajusta si el cumpleaños aún no ha ocurrido este año.
            int age = DateTime.Now.Year - birthDate.Year;

            //Aquí se verifica si el cumpleaños ya ocurrió este año.
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--; //Se ajusta la edad si el cumpleaños aún no ha ocurrido.
            }

            return age >= 18; //Se asegura de que la edad sea de al menos 18 años.
        }

        //Método que valida si un número de teléfono es válido.
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            //Verifica que el número de teléfono solo contenga dígitos y tenga una longitud de hasta 18 caracteres.
            return Regex.IsMatch(phoneNumber, @"^\d{1,18}$");
        }

        //Método que valida si un documento DUI es válido.
        private bool IsValidDuiDoc(string duiDoc)
        {
            //Verifica que el DUI tenga el formato correcto de 8 dígitos, un guion, seguido de un dígito.
            return Regex.IsMatch(duiDoc, @"^\d{8}-\d$");
        }

        //Método que verifica si son solo números.
        private bool IsNumeric(string text)
        {
            //Se asegura de que todos los caracteres en el texto sean dígitos.
            return text.All(char.IsDigit);
        }


        //Eventos del View
        public void ClearInformation(object sender, EventArgs e)
        {
            ObjAddCView.tbClientsName.Clear();
            ObjAddCView.tbClientsSurname.Clear();
            ObjAddCView.dtpClientsBirthday.Value = DateTime.Now;
            ObjAddCView.tbCellphoneN.Clear();
            ObjAddCView.tbDuiDoc.Clear();
            ObjAddCView.tbEmail.Clear();
            ObjAddCView.tbAddress.Clear();

        }

        //Restricciones 
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

