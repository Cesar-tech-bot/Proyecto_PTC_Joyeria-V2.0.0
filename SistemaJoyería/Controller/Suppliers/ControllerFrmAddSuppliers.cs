using SistemaJoyería.Model.DAO;
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
    internal class ControllerFrmAddSuppliers
    {
        private AddSuppliersDAO suppliersDAO = new AddSuppliersDAO();
        private SupplierDTO supplier = new SupplierDTO();
        private FrmAddSuppliers vistaControlada;

        public ControllerFrmAddSuppliers(FrmAddSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada;
            // Código para que cuando se presione guardar se ejecute RegisterSupplier
            vistaPasada.btnGuardar.Click += (sender, e) => RegisterSupplier(supplier);
        }


        public void RegisterSupplier(SupplierDTO supplier)
        {
            CreateSupplierDTO();
            int result = suppliersDAO.RegisterSupplier(supplier);
            if (result > 0)
            {
                MessageBox.Show("Proveedor registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
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

        private void ClearFields()
        {
            vistaControlada.txtId.Clear();
            vistaControlada.txtNombreEmpresa.Clear();
            vistaControlada.txtNombreContacto.Clear();
            vistaControlada.txtTelefono.Clear();
            vistaControlada.txtEmail.Clear();
            vistaControlada.txtDireccion.Clear();
        }
    }
}
