using SistemaJoyería.DTO;
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
    internal class ControllerFrmAddSuppliers
    {
        private AddSuppliersDAO suppliersDAO = new AddSuppliersDAO();
        private SupplierDTO supplier = new SupplierDTO();
        private FrmAddSuppliers vistaControlada;

        public ControllerFrmAddSuppliers(FrmAddSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada;
            //Codigo para que cuando se presione guardar se ejecute registersupplier
            vistaPasada.btnGuardar.Click += (sender, e) => RegisterSupplier(supplier);
        }


        public void RegisterSupplier(SupplierDTO supplier)
        {
            CreateSupplierDTO();
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

        public SupplierDTO CreateSupplierDTO()
        {
            supplier.NombreEmpresa = vistaControlada.txtNombreEmpresa.Text;
            supplier.NombreContacto = vistaControlada.txtNombreContacto.Text;
            supplier.Telefono = vistaControlada.txtTelefono.Text;
            supplier.Email = vistaControlada.txtEmail.Text;
            supplier.Direccion = vistaControlada.txtDireccion.Text;

            return supplier;
        }
    }
}
