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
        private readonly SupplierDAO _supplierDAO = new SupplierDAO();
        private SupplierDTO supplier = new SupplierDTO();
        FrmSuppliers vistaControlada;

        public ControllerSuppliers(FrmSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada;
            vistaPasada.btnAgregar.Click += (sender, e) => AddSupplier(supplier);
            vistaPasada.btnBuscar.Click += (sender, e) => _supplierDAO.SearchData(vistaPasada);
            vistaPasada.btnEliminar.Click += (sender, e) => EliminarSupplier();
            _supplierDAO.GetData(vistaPasada);
        }

        public void AddSupplier(SupplierDTO supplier)
        {
            FrmAddSuppliers frmAdd = new FrmAddSuppliers();
            frmAdd.Show();  
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
