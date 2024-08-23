using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.View.ClientsView;

namespace SistemaJoyería.Controller.ClientsController
{
    internal class ViewClientsController
    {
        FrmClientsView ObjVista;

        public ViewClientsController(FrmClientsView vista)
        {
            ObjVista = vista;

            vista.Load += new EventHandler(InitialCharge);
        }

        void InitialCharge(object sender, EventArgs e)
        {
        
        }
    }
}
