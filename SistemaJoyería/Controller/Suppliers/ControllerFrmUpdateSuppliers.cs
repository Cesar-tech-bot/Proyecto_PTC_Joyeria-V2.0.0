using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.Suppliers
{
    internal class ControllerFrmUpdateSuppliers
    {
        FrmUpdateSuppliers vistaControlada;
        string idBuena;
        UpdateSuppliersDAO updater = new UpdateSuppliersDAO();

        public ControllerFrmUpdateSuppliers(string idPasada, FrmUpdateSuppliers vistaPasada) 
        {
            vistaControlada = vistaPasada;
            idBuena = idPasada;
            vistaPasada.btnGuardar.Click += (sender, e) => ActualizarSupplier();
            updater.Get(vistaPasada, idPasada);
        }

        public void ActualizarSupplier() 
        {
            updater.Update(idBuena, vistaControlada);
        }
    }
}
