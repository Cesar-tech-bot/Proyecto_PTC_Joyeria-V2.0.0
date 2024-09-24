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
            this.label2 = new System.Windows.Forms.Label();
            this.mskPrice = new System.Windows.Forms.MaskedTextBox();
            this.dtpDateSell = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtProductsSell = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsertSell = new System.Windows.Forms.Button();
            this.btnImprent = new System.Windows.Forms.Button();
            this.dgvSellInfo = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label1.Location = new System.Drawing.Point(193, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE VENTAS";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(14, 155);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(78, 25);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "Fecha ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskPrice);
            this.groupBox1.Controls.Add(this.dtpDateSell);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtProductsSell);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.groupBox1.Location = new System.Drawing.Point(197, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(996, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area de Ventas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // mskPrice
            // 
            this.mskPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskPrice.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.mskPrice.Location = new System.Drawing.Point(746, 126);
            this.mskPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskPrice.Mask = "00.00";
            this.mskPrice.Name = "mskPrice";
            this.mskPrice.Size = new System.Drawing.Size(63, 31);
            this.mskPrice.TabIndex = 4;
            // 
            // dtpDateSell
            // 
            this.dtpDateSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDateSell.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.dtpDateSell.Location = new System.Drawing.Point(20, 182);
            this.dtpDateSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateSell.Name = "dtpDateSell";
            this.dtpDateSell.Size = new System.Drawing.Size(371, 31);
            this.dtpDateSell.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.label6.Location = new System.Drawing.Point(639, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio del producto:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(281, 97);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(108, 31);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(276, 70);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(106, 25);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "Cantidad:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(19, 100);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(180, 31);
            this.cmbProduct.TabIndex = 1;
            // 
            // txtProductsSell
            // 
            this.txtProductsSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductsSell.AutoSize = true;
            this.txtProductsSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductsSell.Location = new System.Drawing.Point(15, 70);
            this.txtProductsSell.Name = "txtProductsSell";
            this.txtProductsSell.Size = new System.Drawing.Size(216, 25);
            this.txtProductsSell.TabIndex = 0;
            this.txtProductsSell.Text = "Seleccione producto:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.Snow;
            this.btnClear.Location = new System.Drawing.Point(197, 405);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnInsertSell
            // 
            this.btnInsertSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnInsertSell.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnInsertSell.ForeColor = System.Drawing.Color.White;
            this.btnInsertSell.Location = new System.Drawing.Point(359, 405);
            this.btnInsertSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertSell.Name = "btnInsertSell";
            this.btnInsertSell.Size = new System.Drawing.Size(140, 50);
            this.btnInsertSell.TabIndex = 6;
            this.btnInsertSell.Text = "Registrar";
            this.btnInsertSell.UseVisualStyleBackColor = false;
            // 
            // btnImprent
            // 
            this.btnImprent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnImprent.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnImprent.ForeColor = System.Drawing.Color.White;
            this.btnImprent.Location = new System.Drawing.Point(992, 405);
            this.btnImprent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprent.Name = "btnImprent";
            this.btnImprent.Size = new System.Drawing.Size(201, 50);
            this.btnImprent.TabIndex = 10;
            this.btnImprent.Text = "Imprimir Factura";
            this.btnImprent.UseVisualStyleBackColor = false;
            // 
            // dgvSellInfo
            // 
            this.dgvSellInfo.AllowUserToDeleteRows = false;
            this.dgvSellInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSellInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSellInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellInfo.Location = new System.Drawing.Point(197, 460);
            this.dgvSellInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSellInfo.Name = "dgvSellInfo";
            this.dgvSellInfo.ReadOnly = true;
            this.dgvSellInfo.RowHeadersWidth = 51;
            this.dgvSellInfo.RowTemplate.Height = 24;
            this.dgvSellInfo.Size = new System.Drawing.Size(996, 290);
            this.dgvSellInfo.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(831, 404);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 52);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // FrmSalesDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 790);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label txtDate;
        public System.Windows.Forms.ComboBox cmbProduct;
        public System.Windows.Forms.Label txtProductsSell;
        public System.Windows.Forms.Label txtTotal;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.DateTimePicker dtpDateSell;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnInsertSell;
        public System.Windows.Forms.Button btnImprent;
        public System.Windows.Forms.DataGridView dgvSellInfo;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.MaskedTextBox mskPrice;
        private System.Windows.Forms.Label label2;
    }
}