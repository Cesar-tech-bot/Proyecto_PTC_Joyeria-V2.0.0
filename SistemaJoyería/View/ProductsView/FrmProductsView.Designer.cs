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
            this.txtSupplierName = new System.Windows.Forms.TextBox();
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
            this.MenuProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProductos = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.MenuProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSupplierName.Location = new System.Drawing.Point(26, 152);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(177, 34);
            this.txtSupplierName.TabIndex = 10;
            // 
            // lbIDProduct
            // 
            this.lbIDProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIDProduct.AutoSize = true;
            this.lbIDProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDProduct.ForeColor = System.Drawing.Color.Black;
            this.lbIDProduct.Location = new System.Drawing.Point(18, 527);
            this.lbIDProduct.Name = "lbIDProduct";
            this.lbIDProduct.Size = new System.Drawing.Size(82, 15);
            this.lbIDProduct.TabIndex = 9;
            this.lbIDProduct.Text = "ID Producto";
            // 
            // txtIDProducts
            // 
            this.txtIDProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDProducts.Location = new System.Drawing.Point(103, 526);
            this.txtIDProducts.Name = "txtIDProducts";
            this.txtIDProducts.Size = new System.Drawing.Size(100, 20);
            this.txtIDProducts.TabIndex = 8;
            // 
            // btnKeep
            // 
            this.btnKeep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKeep.BackColor = System.Drawing.Color.White;
            this.btnKeep.ForeColor = System.Drawing.Color.Black;
            this.btnKeep.Location = new System.Drawing.Point(13, 459);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(84, 33);
            this.btnKeep.TabIndex = 7;
            this.btnKeep.Text = "Guardar";
            this.btnKeep.UseVisualStyleBackColor = false;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductDescription.Location = new System.Drawing.Point(26, 304);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(177, 103);
            this.txtProductDescription.TabIndex = 6;
            // 
            // lbDescriptionProduct
            // 
            this.lbDescriptionProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescriptionProduct.AutoSize = true;
            this.lbDescriptionProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionProduct.ForeColor = System.Drawing.Color.Black;
            this.lbDescriptionProduct.Location = new System.Drawing.Point(24, 285);
            this.lbDescriptionProduct.Name = "lbDescriptionProduct";
            this.lbDescriptionProduct.Size = new System.Drawing.Size(182, 16);
            this.lbDescriptionProduct.TabIndex = 5;
            this.lbDescriptionProduct.Text = "Descripción del Producto";
            // 
            // lbNameSupplier
            // 
            this.lbNameSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameSupplier.AutoSize = true;
            this.lbNameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSupplier.ForeColor = System.Drawing.Color.Black;
            this.lbNameSupplier.Location = new System.Drawing.Point(23, 209);
            this.lbNameSupplier.Name = "lbNameSupplier";
            this.lbNameSupplier.Size = new System.Drawing.Size(165, 16);
            this.lbNameSupplier.TabIndex = 3;
            this.lbNameSupplier.Text = "Nombre del Proveedor";
            // 
            // txtProductMaterial
            // 
            this.txtProductMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductMaterial.Location = new System.Drawing.Point(25, 228);
            this.txtProductMaterial.Multiline = true;
            this.txtProductMaterial.Name = "txtProductMaterial";
            this.txtProductMaterial.Size = new System.Drawing.Size(177, 34);
            this.txtProductMaterial.TabIndex = 3;
            // 
            // lbMaterialProduct
            // 
            this.lbMaterialProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaterialProduct.AutoSize = true;
            this.lbMaterialProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaterialProduct.ForeColor = System.Drawing.Color.Black;
            this.lbMaterialProduct.Location = new System.Drawing.Point(24, 133);
            this.lbMaterialProduct.Name = "lbMaterialProduct";
            this.lbMaterialProduct.Size = new System.Drawing.Size(155, 16);
            this.lbMaterialProduct.TabIndex = 2;
            this.lbMaterialProduct.Text = "Material del Producto";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Location = new System.Drawing.Point(26, 76);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(177, 34);
            this.txtProductName.TabIndex = 1;
            // 
            // lbProducts
            // 
            this.lbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.ForeColor = System.Drawing.Color.Black;
            this.lbProducts.Location = new System.Drawing.Point(24, 57);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(154, 16);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.Text = "Nombre del Producto";
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
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Controls.Add(this.txtSearchProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 83);
            this.panel1.TabIndex = 12;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(831, 24);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(91, 31);
            this.btnSearchProduct.TabIndex = 1;
            this.btnSearchProduct.Text = "Buscar";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // txtSearchProductos
            // 
            this.txtSearchProductos.Location = new System.Drawing.Point(331, 24);
            this.txtSearchProductos.Multiline = true;
            this.txtSearchProductos.Name = "txtSearchProductos";
            this.txtSearchProductos.Size = new System.Drawing.Size(438, 31);
            this.txtSearchProductos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnRestart);
            this.panel2.Controls.Add(this.lbProducts);
            this.panel2.Controls.Add(this.lbMaterialProduct);
            this.panel2.Controls.Add(this.txtProductMaterial);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtSupplierName);
            this.panel2.Controls.Add(this.lbNameSupplier);
            this.panel2.Controls.Add(this.lbIDProduct);
            this.panel2.Controls.Add(this.lbDescriptionProduct);
            this.panel2.Controls.Add(this.txtIDProducts);
            this.panel2.Controls.Add(this.txtProductDescription);
            this.panel2.Controls.Add(this.btnKeep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 559);
            this.panel2.TabIndex = 13;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.BackColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(131, 459);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(84, 33);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.ContextMenuStrip = this.MenuProductos;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(230, 83);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(816, 559);
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
        public System.Windows.Forms.Button btnKeep;
        public System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lbDescriptionProduct;
        private System.Windows.Forms.Label lbNameSupplier;
        public System.Windows.Forms.TextBox txtProductMaterial;
        private System.Windows.Forms.Label lbMaterialProduct;
        public System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProducts;
        public System.Windows.Forms.ToolStripMenuItem cmsDeleteProduct;
        public System.Windows.Forms.ToolStripMenuItem cmsUpdateProduct;
        public System.Windows.Forms.TextBox txtSupplierName;
        public System.Windows.Forms.ContextMenuStrip MenuProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvProduct;
        public System.Windows.Forms.TextBox txtSearchProductos;
        public System.Windows.Forms.Button btnRestart;
        public System.Windows.Forms.Button btnSearchProduct;
    }
}