using SistemaJoyería.Controller.FirstUserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.View.FirstUse
{
    public partial class FrmFirstUser : Form
    {
        public FrmFirstUser()
        {
            InitializeComponent();
            ControllerFirsUser control = new ControllerFirsUser(this);
        }

        private void FrmFirstUser_Load(object sender, EventArgs e)
        {

        }
    }
}
