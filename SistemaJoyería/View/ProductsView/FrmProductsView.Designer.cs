namespace SistemaJoyería.View.ProductsView
{
    partial class FrmProductsView
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
            this.components = new System.ComponentModel.Container();
            this.lbIDProduct = new System.Windows.Forms.Label();
            this.txtIDProducts = new System.Windows.Forms.TextBox();
            this.lbDescriptionProduct = new System.Windows.Forms.Label();
            this.lbNameSupplier = new System.Windows.Forms.Label();
            this.lbMaterialProduct = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.MenuProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProductos = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbPriceProduct = new System.Windows.Forms.Label();
            this.btnKeep = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mktPriceProduct = new System.Windows.Forms.MaskedTextBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.txtProductMaterial = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.MenuProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIDProduct
            // 
            this.lbIDProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIDProduct.AutoSize = true;
            this.lbIDProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDProduct.ForeColor = System.Drawing.Color.Black;
            this.lbIDProduct.Location = new System.Drawing.Point(19, 527);
            this.lbIDProduct.Name = "lbIDProduct";
            this.lbIDProduct.Size = new System.Drawing.Size(82, 15);
            this.lbIDProduct.TabIndex = 9;
            this.lbIDProduct.Text = "ID Producto";
            // 
            // txtIDProducts
            // 
            this.txtIDProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDProducts.Location = new System.Drawing.Point(104, 526);
            this.txtIDProducts.Name = "txtIDProducts";
            this.txtIDProducts.Size = new System.Drawing.Size(100, 20);
            this.txtIDProducts.TabIndex = 8;
            // 
            // lbDescriptionProduct
            // 
            this.lbDescriptionProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescriptionProduct.AutoSize = true;
            this.lbDescriptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionProduct.ForeColor = System.Drawing.Color.Black;
            this.lbDescriptionProduct.Location = new System.Drawing.Point(25, 371);
            this.lbDescriptionProduct.Name = "lbDescriptionProduct";
            this.lbDescriptionProduct.Size = new System.Drawing.Size(181, 16);
            this.lbDescriptionProduct.TabIndex = 5;
            this.lbDescriptionProduct.Text = "Descripción del producto";
            // 
            // lbNameSupplier
            // 
            this.lbNameSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameSupplier.AutoSize = true;
            this.lbNameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSupplier.ForeColor = System.Drawing.Color.Black;
            this.lbNameSupplier.Location = new System.Drawing.Point(24, 147);
            this.lbNameSupplier.Name = "lbNameSupplier";
            this.lbNameSupplier.Size = new System.Drawing.Size(164, 16);
            this.lbNameSupplier.TabIndex = 3;
            this.lbNameSupplier.Text = "Nombre del proveedor";
            // 
            // lbMaterialProduct
            // 
            this.lbMaterialProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaterialProduct.AutoSize = true;
            this.lbMaterialProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterialProduct.ForeColor = System.Drawing.Color.Black;
            this.lbMaterialProduct.Location = new System.Drawing.Point(25, 81);
            this.lbMaterialProduct.Name = "lbMaterialProduct";
            this.lbMaterialProduct.Size = new System.Drawing.Size(154, 16);
            this.lbMaterialProduct.TabIndex = 2;
            this.lbMaterialProduct.Text = "Material del producto";
            // 
            // lbProducts
            // 
            this.lbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.ForeColor = System.Drawing.Color.Black;
            this.lbProducts.Location = new System.Drawing.Point(25, 13);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(153, 16);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.Text = "Nombre del producto";
            // 
            // MenuProductos
            // 
            this.MenuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeleteProduct,
            this.cmsUpdateProduct});
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(179, 48);
            // 
            // cmsDeleteProduct
            // 
            this.cmsDeleteProduct.Name = "cmsDeleteProduct";
            this.cmsDeleteProduct.Size = new System.Drawing.Size(178, 22);
            this.cmsDeleteProduct.Text = "Eliminar producto";
            // 
            // cmsUpdateProduct
            // 
            this.cmsUpdateProduct.Name = "cmsUpdateProduct";
            this.cmsUpdateProduct.Size = new System.Drawing.Size(178, 22);
            this.cmsUpdateProduct.Text = "Actualizar producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Controls.Add(this.txtSearchProductos);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 83);
            this.panel1.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(934, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 31);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchProduct.BackColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(714, 24);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(91, 31);
            this.btnSearchProduct.TabIndex = 11;
            this.btnSearchProduct.Text = "Buscar";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // txtSearchProductos
            // 
            this.txtSearchProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchProductos.Location = new System.Drawing.Point(233, 24);
            this.txtSearchProductos.Multiline = true;
            this.txtSearchProductos.Name = "txtSearchProductos";
            this.txtSearchProductos.Size = new System.Drawing.Size(438, 31);
            this.txtSearchProductos.TabIndex = 10;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.BackColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(824, 24);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(91, 31);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.lbCantidad);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.lbPriceProduct);
            this.panel2.Controls.Add(this.lbProducts);
            this.panel2.Controls.Add(this.lbMaterialProduct);
            this.panel2.Controls.Add(this.btnKeep);
            this.panel2.Controls.Add(this.txtProductDescription);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.mktPriceProduct);
            this.panel2.Controls.Add(this.cmbSuppliers);
            this.panel2.Controls.Add(this.txtProductMaterial);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.lbNameSupplier);
            this.panel2.Controls.Add(this.lbIDProduct);
            this.panel2.Controls.Add(this.lbDescriptionProduct);
            this.panel2.Controls.Add(this.txtIDProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 559);
            this.panel2.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Location = new System.Drawing.Point(27, 329);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(177, 26);
            this.txtStock.TabIndex = 6;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.Black;
            this.lbCantidad.Location = new System.Drawing.Point(24, 310);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(69, 16);
            this.lbCantidad.TabIndex = 24;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(25, 256);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(129, 16);
            this.lbDate.TabIndex = 18;
            this.lbDate.Text = "Fecha de entrada";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(141, 473);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lbPriceProduct
            // 
            this.lbPriceProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPriceProduct.AutoSize = true;
            this.lbPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceProduct.ForeColor = System.Drawing.Color.Black;
            this.lbPriceProduct.Location = new System.Drawing.Point(24, 203);
            this.lbPriceProduct.Name = "lbPriceProduct";
            this.lbPriceProduct.Size = new System.Drawing.Size(143, 16);
            this.lbPriceProduct.TabIndex = 16;
            this.lbPriceProduct.Text = "Precio del producto";
            // 
            // btnKeep
            // 
            this.btnKeep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKeep.BackColor = System.Drawing.Color.White;
            this.btnKeep.ForeColor = System.Drawing.Color.Black;
            this.btnKeep.Location = new System.Drawing.Point(12, 473);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(84, 33);
            this.btnKeep.TabIndex = 8;
            this.btnKeep.Text = "Guardar";
            this.btnKeep.UseVisualStyleBackColor = false;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductDescription.Location = new System.Drawing.Point(27, 390);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(177, 60);
            this.txtProductDescription.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Location = new System.Drawing.Point(28, 275);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(197, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2024, 9, 3, 18, 50, 5, 0);
            // 
            // mktPriceProduct
            // 
            this.mktPriceProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mktPriceProduct.Location = new System.Drawing.Point(28, 222);
            this.mktPriceProduct.Mask = "00.00";
            this.mktPriceProduct.Name = "mktPriceProduct";
            this.mktPriceProduct.Size = new System.Drawing.Size(171, 20);
            this.mktPriceProduct.TabIndex = 4;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(28, 166);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(171, 21);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // txtProductMaterial
            // 
            this.txtProductMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductMaterial.Location = new System.Drawing.Point(28, 100);
            this.txtProductMaterial.Multiline = true;
            this.txtProductMaterial.Name = "txtProductMaterial";
            this.txtProductMaterial.Size = new System.Drawing.Size(177, 34);
            this.txtProductMaterial.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Location = new System.Drawing.Point(28, 35);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(177, 34);
            this.txtProductName.TabIndex = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.ContextMenuStrip = this.MenuProductos;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(233, 83);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(813, 559);
            this.dgvProduct.TabIndex = 14;
            // 
            // FrmProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 642);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductsView";
            this.Text = "FrmProductsView";
            this.MenuProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbIDProduct;
        public System.Windows.Forms.TextBox txtIDProducts;
        private System.Windows.Forms.Label lbDescriptionProduct;
        private System.Windows.Forms.Label lbNameSupplier;
        private System.Windows.Forms.Label lbMaterialProduct;
        private System.Windows.Forms.Label lbProducts;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteProduct;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateProduct;
        public System.Windows.Forms.ContextMenuStrip MenuProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lbPriceProduct;
        private System.Windows.Forms.Label lbDate;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductMaterial;
        public System.Windows.Forms.ComboBox cmbSuppliers;
        public System.Windows.Forms.TextBox txtProductDescription;
        public System.Windows.Forms.Button btnKeep;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtSearchProductos;
        public System.Windows.Forms.Button btnSearchProduct;
        public System.Windows.Forms.Button btnRestart;
        public System.Windows.Forms.MaskedTextBox mktPriceProduct;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lbCantidad;
        public System.Windows.Forms.Button btnRefresh;
    }
}