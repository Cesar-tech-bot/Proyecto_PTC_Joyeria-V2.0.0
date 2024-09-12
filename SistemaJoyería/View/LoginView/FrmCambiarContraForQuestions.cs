using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Controller.LoginController;

namespace SistemaJoyería.View
{
    public partial class FrmCambiarContraForQuestions : Form
    {
        public FrmCambiarContraForQuestions(string username)
        {
            InitializeComponent();
            ControllerCambiarContraFromQuestions control = new ControllerCambiarContraFromQuestions(this, username); 
        }

        private void LBPDS_Click(object sender, EventArgs e)
        {

        }

        private void FrmCambiarContraForQuestions_Load(object sender, EventArgs e)
        {

        }
    }
}
