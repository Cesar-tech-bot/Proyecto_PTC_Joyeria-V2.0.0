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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIDProduct = new System.Windows.Forms.Label();
            this.txtIDProducts = new System.Windows.Forms.TextBox();
            this.btnKeep = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lbDescriptionProduct = new System.Windows.Forms.Label();
            this.lbNameSupplier = new System.Windows.Forms.Label();
            this.txtProductMaterial = new System.Windows.Forms.TextBox();
            this.lbMaterialProduct = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProducts = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.MenuProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.MenuProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(150)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.txtSupplierName);
            this.panel1.Controls.Add(this.lbIDProduct);
            this.panel1.Controls.Add(this.txtIDProducts);
            this.panel1.Controls.Add(this.btnKeep);
            this.panel1.Controls.Add(this.txtProductDescription);
            this.panel1.Controls.Add(this.lbDescriptionProduct);
            this.panel1.Controls.Add(this.lbNameSupplier);
            this.panel1.Controls.Add(this.txtProductMaterial);
            this.panel1.Controls.Add(this.lbMaterialProduct);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lbProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 498);
            this.panel1.TabIndex = 2;
            // 
            // lbIDProduct
            // 
            this.lbIDProduct.AutoSize = true;
            this.lbIDProduct.Location = new System.Drawing.Point(16, 466);
            this.lbIDProduct.Name = "lbIDProduct";
            this.lbIDProduct.Size = new System.Drawing.Size(64, 13);
            this.lbIDProduct.TabIndex = 9;
            this.lbIDProduct.Text = "ID Producto";
            // 
            // txtIDProducts
            // 
            this.txtIDProducts.Location = new System.Drawing.Point(86, 463);
            this.txtIDProducts.Name = "txtIDProducts";
            this.txtIDProducts.Size = new System.Drawing.Size(100, 20);
            this.txtIDProducts.TabIndex = 8;
            // 
            // btnKeep
            // 
            this.btnKeep.Location = new System.Drawing.Point(12, 393);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(68, 33);
            this.btnKeep.TabIndex = 7;
            this.btnKeep.Text = "Guardar";
            this.btnKeep.UseVisualStyleBackColor = true;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(7, 260);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(177, 103);
            this.txtProductDescription.TabIndex = 6;
            // 
            // lbDescriptionProduct
            // 
            this.lbDescriptionProduct.AutoSize = true;
            this.lbDescriptionProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionProduct.Location = new System.Drawing.Point(12, 233);
            this.lbDescriptionProduct.Name = "lbDescriptionProduct";
            this.lbDescriptionProduct.Size = new System.Drawing.Size(164, 19);
            this.lbDescriptionProduct.TabIndex = 5;
            this.lbDescriptionProduct.Text = "Descripción del Producto";
            // 
            // lbNameSupplier
            // 
            this.lbNameSupplier.AutoSize = true;
            this.lbNameSupplier.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSupplier.Location = new System.Drawing.Point(12, 160);
            this.lbNameSupplier.Name = "lbNameSupplier";
            this.lbNameSupplier.Size = new System.Drawing.Size(149, 19);
            this.lbNameSupplier.TabIndex = 3;
            this.lbNameSupplier.Text = "Nombre del Proveedor";
            // 
            // txtProductMaterial
            // 
            this.txtProductMaterial.Location = new System.Drawing.Point(7, 116);
            this.txtProductMaterial.Name = "txtProductMaterial";
            this.txtProductMaterial.Size = new System.Drawing.Size(177, 20);
            this.txtProductMaterial.TabIndex = 3;
            // 
            // lbMaterialProduct
            // 
            this.lbMaterialProduct.AutoSize = true;
            this.lbMaterialProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterialProduct.Location = new System.Drawing.Point(12, 84);
            this.lbMaterialProduct.Name = "lbMaterialProduct";
            this.lbMaterialProduct.Size = new System.Drawing.Size(142, 19);
            this.lbMaterialProduct.TabIndex = 2;
            this.lbMaterialProduct.Text = "Material del Producto";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(7, 47);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(177, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.Location = new System.Drawing.Point(12, 20);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(143, 19);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.Text = "Nombre del Producto";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(200, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(600, 498);
            this.dgvProducts.TabIndex = 3;
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
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(7, 187);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(177, 20);
            this.txtSupplierName.TabIndex = 10;
            // 
            // FrmProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductsView";
            this.Text = "FrmProductsView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.MenuProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIDProduct;
        public System.Windows.Forms.TextBox txtIDProducts;
        public System.Windows.Forms.Button btnKeep;
        public System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lbDescriptionProduct;
        private System.Windows.Forms.Label lbNameSupplier;
        public System.Windows.Forms.TextBox txtProductMaterial;
        private System.Windows.Forms.Label lbMaterialProduct;
        public System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProducts;
        public System.Windows.Forms.DataGridView dgvProducts;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteProduct;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateProduct;
        public System.Windows.Forms.TextBox txtSupplierName;
        public System.Windows.Forms.ContextMenuStrip MenuProductos;
    }
}