namespace SistemaJoyería.View.Suppliers
{
    partial class FrmSuppliers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresacar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarRegistro = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.proveedorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proveedorEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proveedorContacto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proveedorTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proveedorEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proveedorDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSuppliers = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRefresacar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscarRegistro);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 62);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.button1.Location = new System.Drawing.Point(569, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRefresacar
            // 
            this.btnRefresacar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresacar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresacar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRefresacar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresacar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresacar.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnRefresacar.Location = new System.Drawing.Point(923, 17);
            this.btnRefresacar.Name = "btnRefresacar";
            this.btnRefresacar.Size = new System.Drawing.Size(108, 28);
            this.btnRefresacar.TabIndex = 5;
            this.btnRefresacar.Text = "Refrescar";
            this.btnRefresacar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnEliminar.Location = new System.Drawing.Point(806, 18);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnAgregar.Location = new System.Drawing.Point(688, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 28);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnBuscar.Location = new System.Drawing.Point(444, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 29);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarRegistro
            // 
            this.txtBuscarRegistro.AutoSize = true;
            this.txtBuscarRegistro.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtBuscarRegistro.Location = new System.Drawing.Point(12, 22);
            this.txtBuscarRegistro.Name = "txtBuscarRegistro";
            this.txtBuscarRegistro.Size = new System.Drawing.Size(127, 21);
            this.txtBuscarRegistro.TabIndex = 2;
            this.txtBuscarRegistro.Text = "Buscar registro:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Location = new System.Drawing.Point(140, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(15, 6, 6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // proveedorId
            // 
            this.proveedorId.Text = "IDSuppliers";
            // 
            // proveedorEmpresa
            // 
            this.proveedorEmpresa.Text = "CompanyName";
            // 
            // proveedorContacto
            // 
            this.proveedorContacto.Text = "ContactName";
            // 
            // proveedorTelefono
            // 
            this.proveedorTelefono.Text = "Phone";
            // 
            // proveedorEmail
            // 
            this.proveedorEmail.Text = "Email";
            // 
            // proveedorDireccion
            // 
            this.proveedorDireccion.Text = "Direction";
            // 
            // listSuppliers
            // 
            this.listSuppliers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.proveedorId,
            this.proveedorEmpresa,
            this.proveedorContacto,
            this.proveedorTelefono,
            this.proveedorEmail,
            this.proveedorDireccion});
            this.listSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSuppliers.FullRowSelect = true;
            this.listSuppliers.HideSelection = false;
            this.listSuppliers.Location = new System.Drawing.Point(0, 62);
            this.listSuppliers.Name = "listSuppliers";
            this.listSuppliers.Size = new System.Drawing.Size(1046, 580);
            this.listSuppliers.TabIndex = 6;
            this.listSuppliers.UseCompatibleStateImageBehavior = false;
            this.listSuppliers.View = System.Windows.Forms.View.Details;
            this.listSuppliers.SelectedIndexChanged += new System.EventHandler(this.listSuppliers_SelectedIndexChanged);
            // 
            // FrmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 642);
            this.Controls.Add(this.listSuppliers);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmSuppliers";
            this.Text = "FrmSuppliers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Label txtBuscarRegistro;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnRefresacar;
        private System.Windows.Forms.ColumnHeader proveedorId;
        private System.Windows.Forms.ColumnHeader proveedorEmpresa;
        private System.Windows.Forms.ColumnHeader proveedorContacto;
        private System.Windows.Forms.ColumnHeader proveedorTelefono;
        private System.Windows.Forms.ColumnHeader proveedorEmail;
        private System.Windows.Forms.ColumnHeader proveedorDireccion;
        public System.Windows.Forms.ListView listSuppliers;
        public System.Windows.Forms.Button button1;
    }
}