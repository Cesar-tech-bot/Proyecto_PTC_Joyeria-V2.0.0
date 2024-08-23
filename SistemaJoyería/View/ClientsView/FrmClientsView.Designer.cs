namespace SistemaJoyería.View.ClientsView
{
    partial class FrmClientsView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClientsTable = new System.Windows.Forms.DataGridView();
            this.DatosId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos_Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClientsTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 547);
            this.panel2.TabIndex = 7;
            // 
            // dgvClientsTable
            // 
            this.dgvClientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsTable.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosId,
            this.Nombres,
            this.Apellidos_Clientes,
            this.FechaNacimiento,
            this.NumeroTelefono,
            this.DocDui,
            this.CorreoPersonal,
            this.Dirección});
            this.dgvClientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientsTable.Location = new System.Drawing.Point(0, 0);
            this.dgvClientsTable.Name = "dgvClientsTable";
            this.dgvClientsTable.ReadOnly = true;
            this.dgvClientsTable.RowHeadersWidth = 51;
            this.dgvClientsTable.RowTemplate.Height = 24;
            this.dgvClientsTable.Size = new System.Drawing.Size(1068, 547);
            this.dgvClientsTable.TabIndex = 1;
            // 
            // DatosId
            // 
            this.DatosId.HeaderText = "ID";
            this.DatosId.MinimumWidth = 6;
            this.DatosId.Name = "DatosId";
            this.DatosId.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres ";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos_Clientes
            // 
            this.Apellidos_Clientes.HeaderText = "Apellidos ";
            this.Apellidos_Clientes.MinimumWidth = 6;
            this.Apellidos_Clientes.Name = "Apellidos_Clientes";
            this.Apellidos_Clientes.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // NumeroTelefono
            // 
            this.NumeroTelefono.HeaderText = "N.Teléfono";
            this.NumeroTelefono.MinimumWidth = 6;
            this.NumeroTelefono.Name = "NumeroTelefono";
            this.NumeroTelefono.ReadOnly = true;
            // 
            // DocDui
            // 
            this.DocDui.HeaderText = "DUI";
            this.DocDui.MinimumWidth = 6;
            this.DocDui.Name = "DocDui";
            this.DocDui.ReadOnly = true;
            // 
            // CorreoPersonal
            // 
            this.CorreoPersonal.HeaderText = "Correo Electrónico";
            this.CorreoPersonal.MinimumWidth = 6;
            this.CorreoPersonal.Name = "CorreoPersonal";
            this.CorreoPersonal.ReadOnly = true;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.MinimumWidth = 6;
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddClients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 100);
            this.panel1.TabIndex = 6;
            // 
            // btnAddClients
            // 
            this.btnAddClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClients.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClients.ForeColor = System.Drawing.Color.Black;
            this.btnAddClients.Location = new System.Drawing.Point(915, 23);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(141, 49);
            this.btnAddClients.TabIndex = 0;
            this.btnAddClients.Text = "Añadir";
            this.btnAddClients.UseVisualStyleBackColor = false;
            // 
            // FrmClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClientsView";
            this.Text = "Tabla de clientes";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvClientsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocDui;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddClients;
    }
}