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
            //Eventos de Click
            view.btnAddClients.Click += new EventHandler(ShowAddClients);
            view.cmsEliminarClient.Click += new EventHandler(EliminarCliente);
            //view.btnRefresh.Click += new EventHandler(RefreshDGV);
            //Eventos de otro tipo
            view.dgvClientsTable.MouseDown += new MouseEventHandler(OpenCms);
        }

        void InitialCharge(object sender, EventArgs e)
        {
            ShowDGVlients();
        }

        //void RefreshDGV(object sender, EventArgs e) { }
        void ShowAddClients(object sender, EventArgs e)
        {
            FrmAddClients frmAddClients = new FrmAddClients();
            frmAddClients.Show();
        }
        void ShowDGVlients()
       {
            ClientsViewDAO daoVC= new ClientsViewDAO();
            DataSet ds = daoVC.ShowDGV();
            ObjView.dgvClientsTable.DataSource = ds.Tables["vw_ClientesInfo"];
       }
        void OpenCms(object sender, MouseEventArgs e)
        {
            // Verifica si el botón del mouse presionado es el derecho
            if (e.Button == MouseButtons.Right)
            {
                // Obtiene la información del punto donde se hizo clic
                DataGridView.HitTestInfo hit = ObjView.dgvClientsTable.HitTest(e.X, e.Y);

                // Verifica si el clic fue en una celda o en el encabezado
                if (hit.Type == DataGridViewHitTestType.Cell || hit.Type == DataGridViewHitTestType.RowHeader)
                {
                    // Selecciona la fila donde se hizo clic derecho (opcional)
                    if (hit.RowIndex >= 0)
                    {
                        ObjView.dgvClientsTable.ClearSelection();
                        ObjView.dgvClientsTable.Rows[hit.RowIndex].Selected = true;
                    }

                    // Muestra el ContextMenuStrip en la posición del clic
                    ObjView.cmsMenuClient.Show(ObjView.dgvClientsTable, e.Location);
                }
            }
        }

        void EliminarCliente(object sender, EventArgs e)
        {
            //Capturando el indice de la fila
            int pos = ObjView.dgvClientsTable.CurrentRow.Index;
            ClientsViewDAO daoDelete = new ClientsViewDAO();
            daoDelete.IdClient = int.Parse(ObjView.dgvClientsTable[0, pos].Value.ToString());
            int retorno = daoDelete.EliminarClient();
            if (retorno == 1)
            {
                MessageBox.Show("El libro seleccionado fue eliminado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDGVlients();
            }
            else
            {
                MessageBox.Show("El libro seleccionado no pudo ser eliminado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
