using SistemaJoyería.DTO;
using SistemaJoyería.Model.DAO;
using SistemaJoyería.Model.DTO;
using System;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.SuppliersController
{
    public class FrmAddSuppliersController
    {
        private AddSuppliersDAO suppliersDAO = new AddSuppliersDAO();

        public void RegisterSupplier(SupplierDTO supplier)
        {
            int result = suppliersDAO.RegisterSupplier(supplier);
            if (result > 0)
            {
                MessageBox.Show("Proveedor registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdateSupplier(SupplierDTO supplier)
        {
            int result = suppliersDAO.UpdateSupplier(supplier);
            if (result > 0)
            {
                MessageBox.Show("Proveedor actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DeleteSupplier(int id)
        {
            int result = suppliersDAO.DeleteSupplier(id);
            if (result > 0)
            {
                MessageBox.Show("Proveedor eliminado exitosamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public SupplierDTO CreateSupplierDTO(string nombreEmpresa, string nombreContacto, string telefono, string email, string direccion)
        {
            SupplierDTO supplier = new SupplierDTO
            {
                NombreEmpresa = nombreEmpresa,
                NombreContacto = nombreContacto,
                Telefono = telefono,
                Email = email,
                Direccion = direccion
            };

            return supplier;
        }
    }
}
