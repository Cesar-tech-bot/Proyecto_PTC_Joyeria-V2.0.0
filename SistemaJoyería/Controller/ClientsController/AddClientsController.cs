using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaJoyería.View.ClientsView;

namespace SistemaJoyería.Controller.ClientsController
{
    public class AddClientsController
    {
      FrmAddClients ObjAddCView;

        public AddClientsController(FrmAddClients viewAdd)
        {
            ObjAddCView = viewAdd;                    
        }
    }
}
