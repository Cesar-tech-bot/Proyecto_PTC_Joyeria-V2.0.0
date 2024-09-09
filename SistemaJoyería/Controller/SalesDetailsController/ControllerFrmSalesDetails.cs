using SistemaJoyería.Model.DAO;
using SistemaJoyería.View.SalesDetailsView;
using System;
using System.Data;
using System.Windows.Forms;

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
            //View.btnInsertSell.Click += new EventHandler(AddSalesDetail);
            View.btnRefresh.Click += new EventHandler(RefreshDGV);
            //View.btnSearch.Click += new EventHandler(SearchSalesDetails);
        }

        void CargaInicial(object sender, EventArgs e)
        {
            ShowDGVSalesDetails();
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
        //void AddSalesDetail(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(ObjSalesDetails.txtQuantity.Text.Trim()) &&
        //        !string.IsNullOrEmpty(ObjSalesDetails.cmbProduct.Text.Trim()) &&
        //        !string.IsNullOrEmpty(ObjSalesDetails.txtPrice.Text.Trim()))
        //    {
        //        SalesDetailsViewDAO daoInsert = new SalesDetailsViewDAO();
        //        daoInsert.IDSale1 = int.Parse(ObjSalesDetails.txtIDSale.Text.Trim());
        //        daoInsert.IDProduct1 = int.Parse(ObjSalesDetails.cmbProduct.SelectedValue.ToString());
        //        daoInsert.Quantity1 = int.Parse(ObjSalesDetails.txtQuantity.Text.Trim());
        //        daoInsert.Price1 = decimal.Parse(ObjSalesDetails.txtPrice.Text.Trim());

        //        int retorno = daoInsert.RegisterSaleDetails();
        //        if (retorno == 1)
        //        {
        //            MessageBox.Show("Los detalles de la venta fueron registrados exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            ShowDGVSalesDetails();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se pudo registrar los detalles de la venta", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Complete el formulario con la información requerida", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //// Buscar detalles de ventas
        //void SearchSalesDetails(object sender, EventArgs e)
        //{
        //    SalesDetailsViewDAO daoSearch = new SalesDetailsViewDAO();
        //    DataSet ds = daoSearch.SearchSalesDetails(ObjSalesDetails.txtSearchSell.Text.Trim());
        //    ObjSalesDetails.dgvSellInfo.DataSource = ds.Tables["SalesDetails"];
        //}
    }
}