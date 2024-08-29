using SistemaJoyeria.DAO;
using SistemaJoyeria.Model.DTO;
using SistemaJoyería.View.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Controller.Suppliers
{
    public class ControllerSuppliers
    {
        private readonly SupplierDAO _supplierDAO = new SupplierDAO();
        private SupplierDTO supplier = new SupplierDTO();

        public ControllerSuppliers(FrmSuppliers vistaPasada)
        {
            vistaPasada.btnAgregar.Click += (sender, e) => AddSupplier(supplier);
            vistaPasada.btnBuscar.Click += (sender, e) => _supplierDAO.SearchData(vistaPasada);
            _supplierDAO.GetData(vistaPasada);
        }

        public void AddSupplier(SupplierDTO supplier)
        {
            FrmAddSuppliers frmAdd = new FrmAddSuppliers();
            frmAdd.Show();  
        }
    }
}
