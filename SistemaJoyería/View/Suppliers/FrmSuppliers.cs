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

            // Hacemos que el ListView se ajuste de forma responsiva
            this.listSuppliers.Dock = DockStyle.Fill; // Se extiende y ocupa todo el espacio disponible

            // Alternativamente, si quieres usar Anchor, puedes descomentar la siguiente línea:
            // this.listSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        // Método para bloquear copiar y pegar
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void listSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
