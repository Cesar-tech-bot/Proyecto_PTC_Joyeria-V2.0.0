using SistemaJoyería.Controller.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.View.Suppliers
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
            new ControllerSuppliers(this);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        //Para copiar y pegar
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
