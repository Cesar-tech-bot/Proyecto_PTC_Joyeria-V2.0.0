using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJoyería.Controller.SalesDetailsController; // Importa el namespace del controller

namespace SistemaJoyería.View.SalesDetailsView
{
    public partial class FrmSalesDetailView : Form
    {
        private SalesDetailsController salesDetailsController; // Instancia del controlador

        public FrmSalesDetailView()
        {
            InitializeComponent();

            // Crear instancia del controlador
            salesDetailsController = new SalesDetailsController(this);
        }

    }
}
