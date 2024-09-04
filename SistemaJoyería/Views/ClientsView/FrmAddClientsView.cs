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
    public partial class FrmAddClientsView : Form
    {
        public FrmAddClientsView()
        {
            InitializeComponent();
            AddClientsController addClientsController = new AddClientsController(this);
            
        }   
    }
}
