using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.ProductsView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.Controller.ProductsController
{
    internal class ProductsController
    {
        FrmProductsView ObjProducts;

        public ProductsController(FrmProductsView View)
        {
            ObjProducts = View;
            //Crear evento para cuando se inicie el Formulario
            View.Load += new EventHandler(CargaInicial);
            ////Eventos que se ejecutan con click
            ///
            View.cmsDeleteProduct.Click += new EventHandler(DeleteProduct);
            View.cmsUpdateProduct.Click += new EventHandler(UpdateProduct);
            View.btnKeep.Click += new EventHandler(KeepRegistrer);
            View.btnRestart.Click += new EventHandler(RestartRegister);
            View.dgvProduct.CellClick += new DataGridViewCellEventHandler(SelectProduct);
            View.txtProductName.KeyPress += new KeyPressEventHandler(txtLetters_KeyPress);
            View.txtProductMaterial.KeyPress += new KeyPressEventHandler(txtLetters_KeyPress);
            View.txtProductDescription.KeyPress += new KeyPressEventHandler(txtLetters_KeyPress);
            View.txtStock.KeyPress += new KeyPressEventHandler(txtNumbers_KeyPress);
            View.btnUpdate.Click += new EventHandler(UpdateProduct);
            View.btnRefresh.Click += new EventHandler(ResfreshDGV);
            View.btnSearchProduct.Click += new EventHandler(SearchProductsEvent);
            View.txtProductName.TextChanged += new EventHandler(Limitede15);
            View.txtProductMaterial.TextChanged += new EventHandler(Limitede15);
            View.txtProductMaterial.TextChanged += new EventHandler(Limitede30);
        }

        void CargaInicial(object sender, EventArgs e)
        {
            ShowDGVProducts();
            FillComboSuppliers();
        }

        //Refrescar tabla
        void ResfreshDGV(object sender, EventArgs e)
        {
            ShowDGVProducts();
        }

        void ShowDGVProducts()
        {
            ProductsViewDAO daoPD = new ProductsViewDAO();
            DataSet ds = daoPD.ShowDGV();
            ObjProducts.dgvProduct.DataSource = ds.Tables["vw_Products"];
        }

        void FillComboSuppliers()
        {
            //Creando un objeto de la clase ProductsViewDAO
            ProductsViewDAO daoSupplier = new ProductsViewDAO();
            DataSet ds = daoSupplier.GetSuppliers();
            ObjProducts.cmbSuppliers.DataSource = ds.Tables["Suppliers"];
            ObjProducts.cmbSuppliers.DisplayMember = "ContactName";
            ObjProducts.cmbSuppliers.ValueMember = "IDSupplier";
        }

        //Limitar a 15 Caracteres
        private void Limitar15Caracteres(TextBox textBox)
        {
            textBox.MaxLength = 15;
        }

        private void Limitede15(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Limitar15Caracteres(textBox);
        }

        //Limitar a 30 Caracteres
        private void Limitar30Caracteres(TextBox textBox)
        {
            textBox.MaxLength = 15;
        }

        private void Limitede30(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Limitar30Caracteres(textBox);
        }

        //solo permite letras
        private void txtLetters_KeyPress(object sender, KeyPressEventArgs e)
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

        //solo permite numeros
        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //solo permite 4 numeros y coma
        private bool MskValidation(string text)
        {
            // Definimos un patrón para validar el formato del texto
            // La expresión regular verifica lo siguiente:
            // ^ : Asegura que la cadena comience en el inicio
            // \d{2} : Debe tener exactamente 2 dígitos
            // , : Debe haber una coma
            // \d{2} : Debe tener exactamente 2 dígitos después de la coma
            // $ : Asegura que la cadena termine al final
            string pattern = @"^\d{2},\d{2}$";
            return Regex.IsMatch(text, pattern);
        }

        //Borrar producto
        void DeleteProduct(object sender, EventArgs e)
        {
            //capturando el indice de la fila

            int pos = ObjProducts.dgvProduct.CurrentRow.Index;
            ProductsViewDAO daoDelete = new ProductsViewDAO();
            daoDelete.IDProducto1 = int.Parse(ObjProducts.dgvProduct[0, pos].Value.ToString());
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

        //Seleccionar producto
        void SelectProduct(object sender, DataGridViewCellEventArgs e)
        {
            int pos = ObjProducts.dgvProduct.CurrentRow.Index;
            ObjProducts.txtIDProducts.Text = ObjProducts.dgvProduct[0, pos].Value.ToString();
            ObjProducts.txtProductName.Text = ObjProducts.dgvProduct[1, pos].Value.ToString();
            ObjProducts.txtProductMaterial.Text = ObjProducts.dgvProduct[2, pos].Value.ToString();
            ObjProducts.cmbSuppliers.Text = ObjProducts.dgvProduct[3, pos].Value.ToString();
            ObjProducts.mktPriceProduct.Text = ObjProducts.dgvProduct[4, pos].Value.ToString();
            ObjProducts.txtStock.Text = ObjProducts.dgvProduct[5, pos].Value.ToString();
            ObjProducts.dtpDate.Text = ObjProducts.dgvProduct[6, pos].Value.ToString();
            ObjProducts.txtProductDescription.Text = ObjProducts.dgvProduct[7, pos].Value.ToString();
        }

        //Actualizar producto
        void UpdateProduct(object sender, EventArgs e)
        {
            ProductsViewDAO daoUpdate = new ProductsViewDAO();
            daoUpdate.IDProducto1 = int.Parse(ObjProducts.txtIDProducts.Text.Trim());
            daoUpdate.NombreProducto1 = ObjProducts.txtProductName.Text.Trim();
            daoUpdate.MaterialProducto1 = ObjProducts.txtProductMaterial.Text.Trim();
            daoUpdate.IDProveedor1 = int.Parse(ObjProducts.cmbSuppliers.Text.Trim());
            daoUpdate.Stock1 = int.Parse(ObjProducts.txtStock.Text.Trim());
            daoUpdate.Price1 = int.Parse(ObjProducts.mktPriceProduct.Text.Trim());
            daoUpdate.Fecha1 = ObjProducts.dtpDate.Value;
            daoUpdate.DescripcionProducto1 = ObjProducts.txtProductDescription.Text.Trim();
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

        //Guardar producto
        void KeepRegistrer(object sender, EventArgs e)
        {
            //Verificar que los campos esten lleno
            if (!string.IsNullOrEmpty(ObjProducts.txtProductName.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjProducts.cmbSuppliers.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjProducts.txtProductMaterial.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjProducts.txtStock.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjProducts.mktPriceProduct.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjProducts.dtpDate.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjProducts.txtProductDescription.Text.Trim()))
            {
                //Crear un objeto de tipo dao
                ProductsViewDAO daoInsert = new ProductsViewDAO();
                daoInsert.NombreProducto1 = ObjProducts.txtProductName.Text.Trim();
                daoInsert.MaterialProducto1 = ObjProducts.txtProductMaterial.Text.Trim();
                daoInsert.IDProveedor1 = int.Parse(ObjProducts.cmbSuppliers.Text.Trim());
                daoInsert.DescripcionProducto1 = ObjProducts.txtProductDescription.Text.Trim();
                daoInsert.Stock1 = int.Parse(ObjProducts.txtStock.Text.Trim());
                daoInsert.Price1 = int.Parse(ObjProducts.mktPriceProduct.Text.Trim());
                daoInsert.Fecha1 = ObjProducts.dtpDate.Value;
                daoInsert.DescripcionProducto1 = ObjProducts.txtProductDescription.Text.Trim();
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
                MessageBox.Show("Complete el formulario con la informacion requerida", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Reiniciar campos
        private void RestartRegister(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            ObjProducts.txtProductName.Text = string.Empty;
            ObjProducts.txtProductMaterial.Text = string.Empty;
            ObjProducts.cmbSuppliers.Text = string.Empty;
            ObjProducts.txtStock.Text = string.Empty;
            ObjProducts.mktPriceProduct.Text = string.Empty;
            ObjProducts.dtpDate.Value = DateTime.Now;
            ObjProducts.txtProductDescription.Text = string.Empty;
        }

        //Buscar productos
        public void SearchProductsEvent(object sender, EventArgs e) { SearchProductsController() ; }
        void SearchProductsController()
        {
            ProductsViewDAO DAOProducts = new ProductsViewDAO();
            DataSet ds = DAOProducts.BuscarProducts(ObjProducts.txtSearchProductos.Text.Trim());
            ObjProducts.dgvProduct.DataSource = ds.Tables["Products"];
        }
    }
}
