using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.ProductsView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.ProductsController
{
    internal class ProductsController
    {
        FrmProductsView ObjView;

        public ProductsController(FrmProductsView View)
        {
            ObjView = View;
            //Crear evento para cuando se inicie el Formulario
            View.Load += new EventHandler(CargaInicial);
            ////Eventos que se ejecutan con click
            ///
            View.cmsDeleteProduct.Click += new EventHandler(DeleteProduct);
            View.cmsUpdateProduct.Click += new EventHandler(UpdateProduct);
            View.btnKeep.Click += new EventHandler(KeepRegistrer);
            View.btnRestart.Click += new EventHandler(RestartRegister);
            View.dgvProduct.CellClick += new DataGridViewCellEventHandler(SelectProduct);
            View.txtProductName.KeyPress += new KeyPressEventHandler(txtRegister_KeyPress);
            View.txtProductMaterial.KeyPress += new KeyPressEventHandler(txtRegister_KeyPress);
            View.txtSupplierName.KeyPress += new KeyPressEventHandler(txtRegister_KeyPress);
            View.txtProductDescription.KeyPress += new KeyPressEventHandler(txtRegister_KeyPress);
        }

        void CargaInicial(object sender, EventArgs e)
        {
            ShowDGVProducts();
        }

        void ShowDGVProducts()
        {
            ProductsViewDAO daoPD = new ProductsViewDAO();
            DataSet ds = daoPD.ShowDGV();
            ObjView.dgvProduct.DataSource = ds.Tables["vw_Products"];
        }
        
        private void txtRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y un único espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            // Evitar más de un espacio consecutivo
            if (e.KeyChar == ' ' && (sender as TextBox).Text.EndsWith(" "))
            {
                e.Handled = true;
            }
        }
        void DeleteProduct(object sender, EventArgs e)
        {
            //capturando el indice de la fila

            int pos = ObjView.dgvProduct.CurrentRow.Index;
            ProductsViewDAO daoDelete = new ProductsViewDAO();
            daoDelete.IDProducto1 = int.Parse(ObjView.dgvProduct[0, pos].Value.ToString());
            int retorno = daoDelete.DeleteRecord();
            if (retorno == 1)
            {
                MessageBox.Show("El producto seleccionado fue eliminado", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El producto seleccionado no pudo ser eliminado", "proceso incompletado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowDGVProducts();
            }
        }
        void SelectProduct(object sender, DataGridViewCellEventArgs e)
        {
            int pos = ObjView.dgvProduct.CurrentRow.Index;
            ObjView.txtIDProducts.Text = ObjView.dgvProduct[0, pos].Value.ToString();
            ObjView.txtProductName.Text = ObjView.dgvProduct[1, pos].Value.ToString();
            ObjView.txtProductMaterial.Text = ObjView.dgvProduct[2, pos].Value.ToString();
            ObjView.txtSupplierName.Text = ObjView.dgvProduct[3, pos].Value.ToString();
            ObjView.txtProductDescription.Text = ObjView.dgvProduct[4, pos].Value.ToString();
        }
        void UpdateProduct(object sender, EventArgs e)
        {
            ProductsViewDAO daoUpdate = new ProductsViewDAO();
            daoUpdate.IDProducto1 = int.Parse(ObjView.txtIDProducts.Text.Trim());
            daoUpdate.NombreProducto1 = ObjView.txtProductName.Text.Trim();
            daoUpdate.MaterialProducto1 = ObjView.txtProductMaterial.Text.Trim();
            daoUpdate.NombreProveedor1 = ObjView.txtSupplierName.Text.Trim();
            daoUpdate.DescripcionProducto1 = ObjView.txtProductDescription.Text.Trim();
            int retorno = daoUpdate.UpdateProduct();
            if (retorno == 1)
            {
                MessageBox.Show("El producto seleccionado fue actualizado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDGVProducts();
            }
            else
            {
                MessageBox.Show("El producto seleccionado no pudo ser actualizado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        void KeepRegistrer(object sender, EventArgs e)
        {
            //Verificar que los campos esten lleno
            if (!string.IsNullOrEmpty(ObjView.txtProductName.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjView.txtSupplierName.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjView.txtProductMaterial.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjView.txtProductDescription.Text.Trim()))
            {
                //Crear un objeto de tipo dao
                ProductsViewDAO daoInsert = new ProductsViewDAO();
                daoInsert.NombreProducto1 = ObjView.txtProductName.Text.Trim();
                daoInsert.MaterialProducto1 = ObjView.txtProductMaterial.Text.Trim();
                daoInsert.NombreProveedor1 = ObjView.txtSupplierName.Text.Trim();
                daoInsert.DescripcionProducto1 = ObjView.txtProductDescription.Text.Trim();
                int retorno = daoInsert.registrerproducts();
                if (retorno == 1)
                {
                    MessageBox.Show("El Producto fue registrado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (retorno == 0)
                {
                    MessageBox.Show("El Producto no pudo ser registrado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //segmento false
                MessageBox.Show("Datos faltantes, complete el formulario con la informacion requerida", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RestartRegister(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            ObjView.txtProductName.Text = string.Empty;
            ObjView.txtProductMaterial.Text = string.Empty;
            ObjView.txtSupplierName.Text = string.Empty;
            ObjView.txtProductDescription.Text = string.Empty;
        }
    }
}
