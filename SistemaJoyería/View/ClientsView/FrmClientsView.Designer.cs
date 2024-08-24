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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClientsTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.cmsMenuClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsActualizarClient = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminarClient = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmsMenuClient.SuspendLayout();
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
            this.dgvClientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientsTable.Location = new System.Drawing.Point(0, 0);
            this.dgvClientsTable.Name = "dgvClientsTable";
            this.dgvClientsTable.ReadOnly = true;
            this.dgvClientsTable.RowHeadersWidth = 51;
            this.dgvClientsTable.RowTemplate.Height = 24;
            this.dgvClientsTable.Size = new System.Drawing.Size(1068, 547);
            this.dgvClientsTable.TabIndex = 1;
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
            // cmsMenuClient
            // 
            this.cmsMenuClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsActualizarClient,
            this.cmsEliminarClient});
            this.cmsMenuClient.Name = "cmsMenuClient";
            this.cmsMenuClient.Size = new System.Drawing.Size(145, 52);
            // 
            // cmsActualizarClient
            // 
            this.cmsActualizarClient.Name = "cmsActualizarClient";
            this.cmsActualizarClient.Size = new System.Drawing.Size(144, 24);
            this.cmsActualizarClient.Text = "Actualizar";
            // 
            // cmsEliminarClient
            // 
            this.cmsEliminarClient.Name = "cmsEliminarClient";
            this.cmsEliminarClient.Size = new System.Drawing.Size(144, 24);
            this.cmsEliminarClient.Text = "Eliminar";
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
            this.cmsMenuClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvClientsTable;
        public System.Windows.Forms.Button btnAddClients;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizarClient;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarClient;
        public System.Windows.Forms.ContextMenuStrip cmsMenuClient;
    }
}