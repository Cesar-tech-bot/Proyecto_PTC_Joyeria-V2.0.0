using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.ClientsView;

namespace SistemaJoyería.Controller.ClientsController
{
    public class ViewClientsController
    {
        FrmClientsView ObjView;

        public ViewClientsController(FrmClientsView view)
        {
            ObjView = view;
            view.Load += new EventHandler(InitialCharge);
            view.btnAddClients.Click += new EventHandler(ShowAddClients);
        }

        void InitialCharge(object sender, EventArgs e)
        {
            ShowDGVlients();
        }

        void ShowDGVlients() 
        {
            ClientsViewDAO daoVC= new ClientsViewDAO();
            DataSet ds = daoVC.ShowDGV();
            ObjView.dgvClientsTable.DataSource = ds.Tables["vw_ClientesInfo"];
        }

        void ShowAddClients(object sender, EventArgs e)
        {
          FrmAddClients frmAddClients = new FrmAddClients();
            frmAddClients.Show();
        }
    }
}
