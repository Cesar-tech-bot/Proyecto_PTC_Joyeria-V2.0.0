using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.SalesDetailsView;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SistemaJoyería.Controller.SalesDetailsController
{
    internal class SalesDetailsController
    {
        FrmSalesDetailView ObjSalesDetails;

        public SalesDetailsController(FrmSalesDetailView View)
        {
            ObjSalesDetails = View;
            // Crear evento para cuando se inicie el Formulario
            View.Load += new EventHandler(CargaInicial);
            // Eventos que se ejecutan con click
            View.btnInsertSell.Click += new EventHandler(AddSalesDetail);
            View.btnRefresh.Click += new EventHandler(RefreshDGV);
            //View.btnSearch.Click += new EventHandler(SearchSalesDetails);
            View.txtQuantity.KeyPress += new KeyPressEventHandler(OnlyNumber);
            View.btnClear.Click += new EventHandler(ClearZone);
            //Otro tipo de método
            // Establece la fecha mínima y máxima en el DateTimePicker para que solo permita la fecha de hoy
            View.dtpDateSell.MinDate = DateTime.Today;
            View.dtpDateSell.MaxDate = DateTime.Today;
            // Establece la fecha por defecto en el DateTimePicker a la fecha de hoy
            View.dtpDateSell.Value = DateTime.Today;
        }

        void CargaInicial(object sender, EventArgs e)
        {
            ShowDGVSalesDetails();
            FillProducts();
        }

        //LLenarTB
        void FillProducts()
        {
            //Creando un objeto de la clase DAOBooks
            SalesDetailsViewDAO daoProducts = new SalesDetailsViewDAO();
            DataSet ds = daoProducts.GetProducts();
            ObjSalesDetails.cmbProduct.DataSource = ds.Tables["Products"];
            ObjSalesDetails.cmbProduct.DisplayMember = "ProductName";
            ObjSalesDetails.cmbProduct.ValueMember = "IDProduct";
        }

        // Refrescar tabla
        void RefreshDGV(object sender, EventArgs e)
        {
            ShowDGVSalesDetails();
        }

        // Mostrar detalles de ventas en el DataGridView
        void ShowDGVSalesDetails()
        {
            SalesDetailsViewDAO daoSD = new SalesDetailsViewDAO();
            DataSet ds = daoSD.ShowDGV();
            ObjSalesDetails.dgvSellInfo.DataSource = ds.Tables["vw_Details"];
        }

        //// Añadir detalles de venta
        void AddSalesDetail(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ObjSalesDetails.txtQuantity.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjSalesDetails.cmbProduct.Text.Trim()) &&
                !string.IsNullOrEmpty(ObjSalesDetails.mskPrice.Text.Trim()))
            {
                SalesDetailsViewDAO daoInsert = new SalesDetailsViewDAO();
                daoInsert.IDProduct1 = int.Parse(ObjSalesDetails.cmbProduct.SelectedValue.ToString());
                daoInsert.DayToSale1 = ObjSalesDetails.dtpDateSell.Value;
                daoInsert.Quantity1 = int.Parse(ObjSalesDetails.txtQuantity.Text.Trim());
                daoInsert.Price1 = decimal.Parse(ObjSalesDetails.mskPrice.Text.Trim());

                int retorno = daoInsert.RegisterSaleDetails();
                if (retorno == 1)
                {
                    MessageBox.Show("Los detalles de la venta fueron registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDGVSalesDetails();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar los detalles de la venta", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Complete el formulario con la información requerida", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Buscar detalles de ventas
        //void SearchSalesDetails(object sender, EventArgs e)
        //{
        //    SalesDetailsViewDAO daoSearch = new SalesDetailsViewDAO();
        //    DataSet ds = daoSearch.SearchSalesDetails(ObjSalesDetails.txtSearchSell.Text.Trim());
        //    ObjSalesDetails.dgvSellInfo.DataSource = ds.Tables["SalesDetails"];
        //}

        void ClearZone(object sender, EventArgs e)
        {
            ObjSalesDetails.cmbProduct.SelectedIndex = -1;
            ObjSalesDetails.txtQuantity.Clear();
            ObjSalesDetails.mskPrice.Clear();

        }

        //Validaciones

        //Método para validar que sólo sean números
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}