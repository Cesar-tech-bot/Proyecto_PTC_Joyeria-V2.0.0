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

        public void UpdateSupplier(SupplierDTO supplier)
        {
            if (string.IsNullOrEmpty(vistaControlada.txtId.Text))
            {
                MessageBox.Show("Seleccione un proveedor para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateSupplierDTO();
            supplier.ID = int.Parse(vistaControlada.txtId.Text);
            int result = suppliersDAO.UpdateSupplier(supplier);
            if (result > 0)
            {
                MessageBox.Show("Proveedor actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        public void DeleteSupplier()
        {
            if (string.IsNullOrEmpty(vistaControlada.txtId.Text))
            {
                MessageBox.Show("Seleccione un proveedor para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(vistaControlada.txtId.Text);
                int result = suppliersDAO.DeleteSupplier(id);
                if (result > 0)
                {
                    MessageBox.Show("Proveedor eliminado exitosamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
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
