namespace SistemaJoyería.View.SalesDetailsView
{
    partial class FrmSalesDetailView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateSell = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtProductsSell = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsertSell = new System.Windows.Forms.Button();
            this.btnImprent = new System.Windows.Forms.Button();
            this.dgvSellInfo = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchSell = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE VENTAS";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(15, 114);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(155, 16);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "Fecha Actual: 03/09/2024";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateSell);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtProductsSell);
            this.groupBox1.Location = new System.Drawing.Point(58, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(996, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area de Ventas";
            // 
            // dtpDateSell
            // 
            this.dtpDateSell.Location = new System.Drawing.Point(18, 145);
            this.dtpDateSell.Name = "dtpDateSell";
            this.dtpDateSell.Size = new System.Drawing.Size(252, 22);
            this.dtpDateSell.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio del producto:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(732, 108);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 22);
            this.txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(255, 72);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(99, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(252, 52);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(64, 16);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "Cantidad:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(17, 70);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(180, 24);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.Text = "Seleccione producto";
            // 
            // txtProductsSell
            // 
            this.txtProductsSell.AutoSize = true;
            this.txtProductsSell.Location = new System.Drawing.Point(15, 52);
            this.txtProductsSell.Name = "txtProductsSell";
            this.txtProductsSell.Size = new System.Drawing.Size(134, 16);
            this.txtProductsSell.TabIndex = 0;
            this.txtProductsSell.Text = "Seleccione producto:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClear.ForeColor = System.Drawing.Color.Snow;
            this.btnClear.Location = new System.Drawing.Point(86, 386);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 37);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnInsertSell
            // 
            this.btnInsertSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnInsertSell.ForeColor = System.Drawing.Color.White;
            this.btnInsertSell.Location = new System.Drawing.Point(200, 386);
            this.btnInsertSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertSell.Name = "btnInsertSell";
            this.btnInsertSell.Size = new System.Drawing.Size(111, 37);
            this.btnInsertSell.TabIndex = 4;
            this.btnInsertSell.Text = "Registrar";
            this.btnInsertSell.UseVisualStyleBackColor = false;
            // 
            // btnImprent
            // 
            this.btnImprent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnImprent.ForeColor = System.Drawing.Color.White;
            this.btnImprent.Location = new System.Drawing.Point(919, 386);
            this.btnImprent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprent.Name = "btnImprent";
            this.btnImprent.Size = new System.Drawing.Size(133, 37);
            this.btnImprent.TabIndex = 6;
            this.btnImprent.Text = "Imprimir Factura";
            this.btnImprent.UseVisualStyleBackColor = false;
            // 
            // dgvSellInfo
            // 
            this.dgvSellInfo.AllowUserToDeleteRows = false;
            this.dgvSellInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellInfo.Location = new System.Drawing.Point(58, 437);
            this.dgvSellInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSellInfo.Name = "dgvSellInfo";
            this.dgvSellInfo.ReadOnly = true;
            this.dgvSellInfo.RowHeadersWidth = 51;
            this.dgvSellInfo.RowTemplate.Height = 24;
            this.dgvSellInfo.Size = new System.Drawing.Size(996, 250);
            this.dgvSellInfo.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(790, 386);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 37);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchSell);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(58, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 71);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area de Buscar";
            // 
            // txtSearchSell
            // 
            this.txtSearchSell.Location = new System.Drawing.Point(0, 27);
            this.txtSearchSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchSell.Name = "txtSearchSell";
            this.txtSearchSell.Size = new System.Drawing.Size(637, 22);
            this.txtSearchSell.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(670, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 37);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // FrmSalesDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvSellInfo);
            this.Controls.Add(this.btnImprent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsertSell);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSalesDetailView";
            this.Text = "FrmSalesDetailView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label txtProductsSell;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpDateSell;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnInsertSell;
        public System.Windows.Forms.Button btnImprent;
        public System.Windows.Forms.DataGridView dgvSellInfo;
        private System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearchSell;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.GroupBox groupBox2;
    }
}