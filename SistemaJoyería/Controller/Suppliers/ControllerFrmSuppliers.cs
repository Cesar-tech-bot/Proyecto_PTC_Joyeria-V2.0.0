using System;
using System.Collections.Generic;
using SistemaJoyeria.DTO;
using SistemaJoyeria.DAO;

namespace SistemaJoyeria.Controller
{
    public class SupplierController
    {
        private readonly SupplierDAO _supplierDAO;

        public SupplierController()
        {
            _supplierDAO = new SupplierDAO();
        }

        public void AddSupplier(SupplierDTO supplier)
        {
            try
            {
                _supplierDAO.Add(supplier);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<SupplierDTO> SearchSuppliers(string searchTerm)
        {
            try
            {
                return _supplierDAO.Search(searchTerm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}