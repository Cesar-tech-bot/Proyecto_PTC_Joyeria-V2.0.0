using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.Model.DTO;
using SistemaJoyería.View.ClientsView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaJoyería.Controller.ClientsController
{
    public class ViewClientsController
    {
        FrmClientsView ObjView;

        public ViewClientsController(FrmClientsView view)
        {
            ObjView = view;
            view.Load += new EventHandler(InitialCharge);
            //Eventos del CRUD (Read, Delete, Update)
            view.btnAddClients.Click += new EventHandler(ShowAddClients);
            view.cmsEliminarClient.Click += new EventHandler(EliminarCliente);
            view.btnUpdate.Click += new EventHandler(UpdateRegister);
            //Eventos de otro tipo
            view.btnRefresh.Click += new EventHandler(RefreshPage);
            view.btnClearUpdate.Click += new EventHandler(ClearUpdateZone);
            view.dgvClientsTable.CellClick += new DataGridViewCellEventHandler(SelectClient);
            view.dgvClientsTable.MouseDown += new MouseEventHandler(OpenCms);
        }

        void InitialCharge(object sender, EventArgs e)
        {
            ShowDGVlients();
        }

        //CRUD
        void ShowDGVlients()
        {
            //Creamos un objeto de tipo DAO
            ClientsViewDAO daoVC = new ClientsViewDAO();
            //Ejecutamos el método para obtener los datos y los almacenamos en un DataSet
            DataSet ds = daoVC.ShowDGV();
            //Asignamos la tabla del DataSet como la fuente de datos para el DataGridView
            ObjView.dgvClientsTable.DataSource = ds.Tables["vw_ClientesInfo"];
        }
        void UpdateRegister(object sender, EventArgs e)
        {
            if (!(// Validamos si los campos de nombres y apellidos no están vacíos
                  string.IsNullOrEmpty(ObjView.tbUClientsName.Text.Trim()) ||
                  string.IsNullOrEmpty(ObjView.tbUClientsSurname.Text.Trim()) ||
                  // Validamos si el campo de número de teléfono no está vacío
                  string.IsNullOrEmpty(ObjView.mskUCellphoneN.Text.Trim()) ||
                   //Validamos que esté completos todos los cam´pos de número de teléfono  
                   !MskPhoneValidation(ObjView.mskUDuiDoc.Text.Trim()) ||
                  // Validamos si el campo de DUI no está vacío
                  string.IsNullOrEmpty(ObjView.mskUDuiDoc.Text.Trim()) ||
                  //Validamos que esté completos todos los cam´pos del DUI
                  !MskValidation(ObjView.mskUDuiDoc.Text.Trim()) ||
                  // Validamos si el campo de correo electrónico no está vacío
                  string.IsNullOrEmpty(ObjView.tbUEmail.Text.Trim()) ||
                  // Validamos si el campo de dirección no está vacío
                  string.IsNullOrEmpty(ObjView.tbUAddress.Text.Trim()) ||
                  // Validamos que la dirección no sobrepase los 100 dígitos
                  ObjView.tbUAddress.Text.Length > 100))
            {

                ClientsViewDAO daoUpdate = new ClientsViewDAO();
                daoUpdate.IdClient = int.Parse(ObjView.tbID.Text.Trim());
                daoUpdate.FirstName = ObjView.tbUClientsName.Text.Trim();
                daoUpdate.LastName = ObjView.tbUClientsSurname.Text.Trim();
                daoUpdate.Phone = ObjView.mskUCellphoneN.Text.Trim();
                daoUpdate.Email = ObjView.tbUEmail.Text.Trim();
                daoUpdate.BirthDate = ObjView.dtpUClientsBirthday.Value;
                daoUpdate.IdentityDocument = ObjView.mskUDuiDoc.Text.Trim();
                daoUpdate.AddressClient = ObjView.tbUAddress.Text.Trim();
                int retorno = daoUpdate.UpdateClients();
                if (retorno == 1)
                {
                    MessageBox.Show("El cliente seleccionado fue actualizado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDGVlients();
                }
                else
                {
                    MessageBox.Show("El cliente seleccionado no pudo ser actualizado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos faltantes o incorrectos, revise", "Revisa la información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool HaveChanges(ClientsViewDTO oldData, ClientsViewDTO newData)
        {
            return oldData.FirstName != newData.FirstName ||
                   oldData.LastName != newData.LastName ||
                   oldData.Phone != newData.Phone ||
                   oldData.BirthDate != newData.BirthDate ||
                   oldData.IdentityDocument != newData.IdentityDocument ||
                   oldData.Email != newData.Email ||
                   oldData.AddressClient != newData.AddressClient;
        }

        void EliminarCliente(object sender, EventArgs e)
        {
            //Capturamos el índice de la fila seleccionada en el DataGridView
            int pos = ObjView.dgvClientsTable.CurrentRow.Index;
            //Creamos una instancia del DAO para eliminar el cliente
            ClientsViewDAO daoDelete = new ClientsViewDAO();
            //Establecemos el ID del cliente a eliminar basado en el valor en la primera columna de la fila seleccionada
            daoDelete.IdClient = int.Parse(ObjView.dgvClientsTable[0, pos].Value.ToString());
            //Ejecutamos el método para eliminar el cliente y capturamos el resultado
            int retorno = daoDelete.EliminarClient();

            if (retorno == 1)
            {
                MessageBox.Show("El cliente seleccionado fue eliminado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refrescamos el DataGridView para mostrar los cambios
                ShowDGVlients();
            }
            else
            {
                MessageBox.Show("El cliente seleccionado no pudo ser eliminado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Validaciones 

        private bool MskValidation(string text)
        {
            // Definimos un patrón para validar el formato del texto
            // La expresión regular verifica lo siguiente:
            // ^ : Asegura que la cadena comience en el inicio
            // \d{8} : Debe tener exactamente 8 dígitos
            // - : Debe haber un guion después de los 8 dígitos
            // \d : Debe tener un digito después del "-"
            // $ : Asegura que la cadena termine al final
            string pattern = @"^\d{8}-\d$";
            return Regex.IsMatch(text, pattern);
        }

        private bool MskPhoneValidation(string text)
        {
            // Definimos un patrón para validar el formato del texto
            // La expresión regular verifica lo siguiente:
            // ^ : Asegura que la cadena comience en el inicio
            // \d{8} : Debe tener exactamente 8 dígitos
            // - : Debe haber un guion después de los 8 dígitos
            // \d{4} : Debe tener exactamente 4 dígitos después del guion
            // $ : Asegura que la cadena termine al final
            string pattern = @"^\d{8}-\d{4}$";
            return Regex.IsMatch(text, pattern);
        }

        //Métodos para eventos
        void ShowAddClients(object sender, EventArgs e)
        {
            FrmAddClients frmAddClients = new FrmAddClients();
            frmAddClients.Show();
        }
        void OpenCms(object sender, MouseEventArgs e)
        {
            //Verifica si el botón del mouse presionado es el derecho
            if (e.Button == MouseButtons.Right)
            {
                //Obtiene la información del punto donde se hizo clic
                DataGridView.HitTestInfo hit = ObjView.dgvClientsTable.HitTest(e.X, e.Y);

                //Verifica si el clic fue en una celda o en el encabezado
                if (hit.Type == DataGridViewHitTestType.Cell || hit.Type == DataGridViewHitTestType.RowHeader)
                {
                    //Selecciona la fila donde se hizo clic derecho (opcional)
                    if (hit.RowIndex >= 0)
                    {
                        ObjView.dgvClientsTable.ClearSelection();
                        ObjView.dgvClientsTable.Rows[hit.RowIndex].Selected = true;
                    }

                    //Muestra el ContextMenuStrip en la posición del clic
                    ObjView.cmsMenuClient.Show(ObjView.dgvClientsTable, e.Location);
                }
            }
        }
        void SelectClient(object sender, DataGridViewCellEventArgs e)
        {
            int pos = ObjView.dgvClientsTable.CurrentRow.Index;
            ObjView.tbID.Text = ObjView.dgvClientsTable[0, pos].Value.ToString();
            ObjView.tbUClientsName.Text = ObjView.dgvClientsTable[1, pos].Value.ToString();
            ObjView.tbUClientsSurname.Text = (ObjView.dgvClientsTable[2, pos].Value.ToString());
            ObjView.mskUCellphoneN.Text = ObjView.dgvClientsTable[3, pos].Value.ToString();
            ObjView.tbUEmail.Text = ObjView.dgvClientsTable[4, pos].Value.ToString();
            ObjView.dtpUClientsBirthday.Text = ObjView.dgvClientsTable[5, pos].Value.ToString();
            ObjView.mskUDuiDoc.Text = ObjView.dgvClientsTable[6, pos].Value.ToString();
            ObjView.tbUAddress.Text = ObjView.dgvClientsTable[7, pos].Value.ToString();
        }
        void RefreshPage(object sender, EventArgs e)
        {
            ShowDGVlients();
        }

        void ClearUpdateZone(object sender, EventArgs e)
        {
            ObjView.tbUClientsName.Clear();
            ObjView.tbUClientsSurname.Clear();
            ObjView.dtpUClientsBirthday.Value = DateTime.Now;
            ObjView.mskUCellphoneN.Clear();
            ObjView.mskUDuiDoc.Clear();
            ObjView.tbUEmail.Clear();
            ObjView.tbUAddress.Clear();
            ObjView.tbID.Clear();
        }

    }
}
