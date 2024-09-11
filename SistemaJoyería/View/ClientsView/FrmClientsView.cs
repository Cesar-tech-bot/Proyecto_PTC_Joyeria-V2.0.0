using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Controller.ClientsController;

namespace SistemaJoyería.View.ClientsView
{
    public partial class FrmClientsView : Form
    {
        public FrmClientsView()
        {
            InitializeComponent();
            ViewClientsController viewClientsController = new ViewClientsController(this);
        }

        private void txtUClientsName_Click(object sender, EventArgs e)
        {

        }

        private void txtUClientsSurname_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClients_Click(object sender, EventArgs e)
        {

        }
    }
}
