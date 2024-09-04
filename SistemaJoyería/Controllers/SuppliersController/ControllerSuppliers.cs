using SistemaJoyeria.DAO;
using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.Suppliers
{
    public class ControllerSuppliers
    {
        private SupplierDAO _supplierDAO = new SupplierDAO();
        private SupplierDTO supplier = new SupplierDTO();
        FrmSuppliersView vistaControlada;

        public ControllerSuppliers(FrmSuppliersView vistaPasada)
        {
            vistaControlada = vistaPasada;
            vistaPasada.btnAgregar.Click += (sender, e) => AddSupplier(supplier);
            vistaPasada.btnBuscar.Click += (sender, e) => _supplierDAO.SearchData(vistaPasada);
            vistaPasada.btnEliminar.Click += (sender, e) => EliminarSupplier();
            vistaPasada.btnActualizar.Click += (sender, e) => ActualizarSupplier();
            _supplierDAO.GetData(vistaPasada);
        }

        public void ActualizarSupplier()
        {
            if (vistaControlada.listSuppliers.SelectedItems.Count > 0)
            {
                string idBuena = vistaControlada.listSuppliers.SelectedItems[0].Text;
                MessageBox.Show(idBuena);
                FrmUpdateSuppliersView frmUpdate = new FrmUpdateSuppliersView(idBuena);
                frmUpdate.Show();
            }
            _supplierDAO.GetData(vistaControlada);
        } 

        public void AddSupplier(SupplierDTO supplier)
        {
            FrmAddSuppliersView frmAdd = new FrmAddSuppliersView();
            frmAdd.Show();
            _supplierDAO.GetData(vistaControlada);
        }

        public void EliminarSupplier()
        {
            if (vistaControlada.listSuppliers.SelectedItems.Count > 0)
            {
                string idMala = vistaControlada.listSuppliers.SelectedItems[0].Text;
                _supplierDAO.Delete(idMala);
            }
            _supplierDAO.GetData(vistaControlada);
        }
    }
}
