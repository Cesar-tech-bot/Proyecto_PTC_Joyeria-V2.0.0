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
            view.btnUpdate.Click += new EventHandler(UpdateRegister);
            //Eventos de otro tipo
            view.btnRefresh.Click += new EventHandler(RefreshPage);
            view.btnClearUpdate.Click += new EventHandler(ClearUpdateZone);
            view.dgvClientsTable.CellClick += new DataGridViewCellEventHandler(SelectClient);
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
                  // Validamos si el campo de DUI no está vacío
                  string.IsNullOrEmpty(ObjView.mskUDuiDoc.Text.Trim()) ||        
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

        //Validaciones 

        //Métodos para eventos
        void ShowAddClients(object sender, EventArgs e)
        {
            FrmAddClients frmAddClients = new FrmAddClients();
            frmAddClients.Show();
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
