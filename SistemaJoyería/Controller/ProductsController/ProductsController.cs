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
            View.btnUpdate.Click += new EventHandler(UpdateProduct);
            View.btnRefresh.Click += new EventHandler(ResfreshDGV);
            View.btnSearchProduct.Click += new EventHandler(SearchProductsEvent);
            //Evento para seleccionar fila de producto
            View.dgvProduct.CellClick += new DataGridViewCellEventHandler(SelectProduct);
            //Evento para solo permitir letras
            View.txtProductName.KeyPress += new KeyPressEventHandler(txtLetters_KeyPress);
            View.txtProductMaterial.KeyPress += new KeyPressEventHandler(txtLetters_KeyPress);
            View.txtProductDescription.KeyPress += new KeyPressEventHandler(txtLetters_KeyPress);
            View.txtSearchProductos.KeyPress += new KeyPressEventHandler(SearchProduct);
            //Evento para solo permitir numeros
            View.txtStock.KeyPress += new KeyPressEventHandler(txtNumbers_KeyPress);
            View.mktPriceProduct.KeyPress += new KeyPressEventHandler(txtNumbers_KeyPress);
            //Limite de caracteres
            View.txtProductName.TextChanged += new EventHandler(Limitede15);
            View.txtProductMaterial.TextChanged += new EventHandler(Limitede15);
            View.txtProductMaterial.TextChanged += new EventHandler(Limitede100);
            //Evento de solo fecha actual
            View.dtpDate.ValueChanged += new EventHandler(ValidateDateEvent);

        }
        void CargaInicial(object sender, EventArgs e)
        {
            ShowDGVProducts();
            FillComboSuppliers();
            //Colocar fecha actual
            ObjProducts.dtpDate.Value = DateTime.Now;
            //Deshabilitar el cambio manual de fecha
            ObjProducts.dtpDate.ValueChanged += new EventHandler(ValidateDateEvent);
            // Deshabilitar copiar y pegar en TextBox y MaskedTextBox
            DisableCopyPaste(ObjProducts.txtProductName);
            DisableCopyPaste(ObjProducts.txtProductMaterial);
            DisableCopyPaste(ObjProducts.txtProductDescription);
            DisableCopyPaste(ObjProducts.cmbSuppliers);
            DisableCopyPaste(ObjProducts.txtStock);
            DisableCopyPaste(ObjProducts.txtSearchProductos);
            DisableCopyPaste(ObjProducts.txtIDProducts);
            DisableCopyPaste(ObjProducts.mktPriceProduct);
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
            DataSet copyDs = ds.Copy();
            ObjProducts.dgvProduct.DataSource = ds.Tables["vw_Products"];
        }
        private void DisableCopyPaste(Control control)
        {
            // Deshabilitar el menú contextual y los atajos de teclado para TextBox
            if (control is TextBox)
            {
                var textBox = control as TextBox;

                textBox.ContextMenuStrip = new ContextMenuStrip();
                textBox.ContextMenuStrip.Opening += (s, e) => e.Cancel = true;

                // Deshabilitar los atajos de teclado Ctrl+C y Ctrl+V
                textBox.KeyDown += (s, e) =>
                {
                    if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
                    {
                        e.SuppressKeyPress = true; // Evitar que se procese el atajo de teclado
                    }
                };
            }
            // Deshabilitar el menú contextual y los atajos de teclado para MaskedTextBox
            else if (control is MaskedTextBox)
            {
                var maskedTextBox = control as MaskedTextBox;

                maskedTextBox.ContextMenuStrip = new ContextMenuStrip();
                maskedTextBox.ContextMenuStrip.Opening += (s, e) => e.Cancel = true;

                // Deshabilitar los atajos de teclado Ctrl+C y Ctrl+V
                maskedTextBox.KeyDown += (s, e) =>
                {
                    if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
                    {
                        e.SuppressKeyPress = true; // Evitar que se procese el atajo de teclado
                    }
                };
            }
            // Deshabilitar el menú contextual y los atajos de teclado para ComboBox
            else if (control is ComboBox)
            {
                var comboBox = control as ComboBox;

                comboBox.ContextMenuStrip = new ContextMenuStrip();
                comboBox.ContextMenuStrip.Opening += (s, e) => e.Cancel = true;

                // Deshabilitar los atajos de teclado Ctrl+C y Ctrl+V
                comboBox.KeyDown += (s, e) =>
                {
                    if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
                    {
                        e.SuppressKeyPress = true; // Evitar que se procese el atajo de teclado
                    }
                };
            }
        }


        //Solo fecha actual
        private void ValidateDateEvent(object sender, EventArgs e)
        {
            // Verificar si la fecha seleccionada es diferente de la fecha actual
            if (ObjProducts.dtpDate.Value.Date != DateTime.Now.Date)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Solo se permite la fecha actual. La fecha ha sido restablecida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Establecer siempre la fecha actual en el DateTimePicker
                ObjProducts.dtpDate.Value = DateTime.Now;
            }
        }

        //Llenar combobox
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

        //Limitar a 100 Caracteres
        private void Limitar100Caracteres(TextBox textBox)
        {
            textBox.MaxLength = 15;
        }

        private void Limitede100(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Limitar100Caracteres(textBox);
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



        private void ValidateDate(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now.Date; // Fecha actual sin la hora

            // Verifica si la fecha es exactamente la fecha actual
            if (fecha.Date != fechaActual)
            {
                // Muestra un mensaje de error si la fecha no es la actual
                MessageBox.Show("Solo se permite seleccionar la fecha actual.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si la fecha es correcta, puedes continuar con la lógica que necesites
                // Por ejemplo, continuar con la ejecución o alguna otra operación
            }
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
            ObjProducts.mktPriceProduct.Text = ObjProducts.dgvProduct[6, pos].Value.ToString();
            ObjProducts.dtpDate.Text = ObjProducts.dgvProduct[5, pos].Value.ToString();
            ObjProducts.txtStock.Text = ObjProducts.dgvProduct[4, pos].Value.ToString();
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
            daoUpdate.Price1 = float.Parse(ObjProducts.mktPriceProduct.Text.Trim());
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
                daoInsert.IDProveedor1 = int.Parse(ObjProducts.cmbSuppliers.SelectedValue.ToString());
                daoInsert.DescripcionProducto1 = ObjProducts.txtProductDescription.Text.Trim();
                daoInsert.Stock1 = int.Parse(ObjProducts.txtStock.Text.Trim());
                daoInsert.Price1 = float.Parse(ObjProducts.mktPriceProduct.Text.Trim());
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

        //Mando a llamar el DAO
        public void SearchProduct(object sender, KeyPressEventArgs e)
        {
            SearchProductsController();
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
