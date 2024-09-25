﻿using SistemaJoyeria.DAO;
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
        // Declaración de variables miembro
        private SupplierDAO _supplierDAO = new SupplierDAO(); // Objeto para acceder a la capa de acceso a datos
        private SupplierDTO supplier = new SupplierDTO(); // Objeto para manejar los datos del proveedor
        FrmSuppliers vistaControlada; // Referencia al formulario principal de proveedores

        // Constructor de la clase
        public ControllerSuppliers(FrmSuppliers vistaPasada)
        {
            vistaControlada = vistaPasada; // Asigna el formulario pasado como parámetro

            // Asignación de manejadores de eventos a los botones del formulario
            vistaPasada.btnAgregar.Click += (sender, e) => AddSupplier(supplier);
            vistaPasada.btnBuscar.Click += (sender, e) => _supplierDAO.SearchData(vistaPasada);
            vistaPasada.btnEliminar.Click += (sender, e) => EliminarSupplier();
            vistaPasada.btnActualizar.Click += (sender, e) => ActualizarSupplier();
            vistaPasada.btnRefresacar.Click += (sender, e) => _supplierDAO.GetData(vistaPasada);

            _supplierDAO.GetData(vistaPasada); // Carga inicial de datos en el formulario

            // Implementación de validación para bloquear copiar y pegar
            vistaControlada.KeyPreview = true;
            vistaControlada.KeyDown += Form_KeyDown;

            // Deshabilitar el menú contextual en el formulario
            DisableContextMenu(vistaControlada);
        }

        // Método para actualizar un proveedor
        public void ActualizarSupplier()
        {
            // Verifica si hay un elemento seleccionado en la lista
            if (vistaControlada.listSuppliers.SelectedItems.Count > 0)
            {
                // Obtiene el ID del proveedor seleccionado
                string idBuena = vistaControlada.listSuppliers.SelectedItems[0].Text;
                MessageBox.Show(idBuena); // Muestra el ID seleccionado (para depuración)

                // Crea y muestra el formulario de actualización
                FrmUpdateSuppliers frmUpdate = new FrmUpdateSuppliers(idBuena);
                frmUpdate.Show();
            }
            _supplierDAO.GetData(vistaControlada); // Actualiza la lista de proveedores
        }

        // Método para agregar un nuevo proveedor
        public void AddSupplier(SupplierDTO supplier)
        {
            // Crea y muestra el formulario para agregar un nuevo proveedor
            FrmAddSuppliers frmAdd = new FrmAddSuppliers();
            frmAdd.Show();
            _supplierDAO.GetData(vistaControlada); // Actualiza la lista de proveedores
        }

        // Método para eliminar un proveedor
        public void EliminarSupplier()
        {
            // Verifica si hay un elemento seleccionado en la lista
            if (vistaControlada.listSuppliers.SelectedItems.Count > 0)
            {
                // Obtiene el ID del proveedor seleccionado
                string idMala = vistaControlada.listSuppliers.SelectedItems[0].Text;
                _supplierDAO.Delete(idMala); // Llama al método de eliminación en la capa DAO
            }
            _supplierDAO.GetData(vistaControlada); // Actualiza la lista de proveedores
        }

        // Método para bloquear copiar y pegar con Ctrl+C y Ctrl+V
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("No se permite copiar o pegar en este formulario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para deshabilitar el menú contextual (clic derecho)
        private void DisableContextMenu(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBoxBase || ctrl is ComboBox)
                {
                    ctrl.ContextMenu = new ContextMenu(); // Asigna un menú vacío
                }

                if (ctrl.HasChildren)
                {
                    DisableContextMenu(ctrl); // Llama recursivamente para deshabilitar en todos los controles hijos
                }
            }
        }
    }
}
