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
            this.cmsEliminarClient = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbUClientsSurname = new System.Windows.Forms.TextBox();
            this.tbUClientsName = new System.Windows.Forms.TextBox();
            this.txtUClientsSurname = new System.Windows.Forms.Label();
            this.txtUClientsName = new System.Windows.Forms.Label();
            this.dtpUClientsBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtUClientsBirthday = new System.Windows.Forms.Label();
            this.txtUCellphoneN = new System.Windows.Forms.Label();
            this.tbUCellphoneN = new System.Windows.Forms.TextBox();
            this.tbUDuiDoc = new System.Windows.Forms.TextBox();
            this.txtUDuiDoc = new System.Windows.Forms.Label();
            this.tbUEmail = new System.Windows.Forms.TextBox();
            this.txtUEmail = new System.Windows.Forms.Label();
            this.tbUAddress = new System.Windows.Forms.TextBox();
            this.txtUAddress = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmsMenuClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUAddress);
            this.panel2.Controls.Add(this.btnClearUpdate);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtUAddress);
            this.panel2.Controls.Add(this.tbUEmail);
            this.panel2.Controls.Add(this.txtUEmail);
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.tbUDuiDoc);
            this.panel2.Controls.Add(this.txtUDuiDoc);
            this.panel2.Controls.Add(this.dtpUClientsBirthday);
            this.panel2.Controls.Add(this.txtUClientsBirthday);
            this.panel2.Controls.Add(this.txtUCellphoneN);
            this.panel2.Controls.Add(this.tbUCellphoneN);
            this.panel2.Controls.Add(this.tbUClientsSurname);
            this.panel2.Controls.Add(this.tbUClientsName);
            this.panel2.Controls.Add(this.txtUClientsSurname);
            this.panel2.Controls.Add(this.txtUClientsName);
            this.panel2.Controls.Add(this.dgvClientsTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 547);
            this.panel2.TabIndex = 7;
            // 
            // dgvClientsTable
            // 
            this.dgvClientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsTable.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsTable.Location = new System.Drawing.Point(294, 0);
            this.dgvClientsTable.Name = "dgvClientsTable";
            this.dgvClientsTable.ReadOnly = true;
            this.dgvClientsTable.RowHeadersWidth = 51;
            this.dgvClientsTable.RowTemplate.Height = 24;
            this.dgvClientsTable.Size = new System.Drawing.Size(846, 547);
            this.dgvClientsTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddClients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 100);
            this.panel1.TabIndex = 6;
            // 
            // btnAddClients
            // 
            this.btnAddClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClients.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClients.ForeColor = System.Drawing.Color.Black;
            this.btnAddClients.Location = new System.Drawing.Point(987, 23);
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
            this.cmsEliminarClient});
            this.cmsMenuClient.Name = "cmsMenuClient";
            this.cmsMenuClient.Size = new System.Drawing.Size(133, 28);
            // 
            // cmsEliminarClient
            // 
            this.cmsEliminarClient.Name = "cmsEliminarClient";
            this.cmsEliminarClient.Size = new System.Drawing.Size(132, 24);
            this.cmsEliminarClient.Text = "Eliminar";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 544);
            this.panel3.TabIndex = 2;
            // 
            // tbUClientsSurname
            // 
            this.tbUClientsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUClientsSurname.Location = new System.Drawing.Point(79, 40);
            this.tbUClientsSurname.Name = "tbUClientsSurname";
            this.tbUClientsSurname.Size = new System.Drawing.Size(195, 24);
            this.tbUClientsSurname.TabIndex = 38;
            // 
            // tbUClientsName
            // 
            this.tbUClientsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUClientsName.Location = new System.Drawing.Point(79, 10);
            this.tbUClientsName.Name = "tbUClientsName";
            this.tbUClientsName.Size = new System.Drawing.Size(195, 24);
            this.tbUClientsName.TabIndex = 39;
            // 
            // txtUClientsSurname
            // 
            this.txtUClientsSurname.AutoSize = true;
            this.txtUClientsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUClientsSurname.Location = new System.Drawing.Point(6, 40);
            this.txtUClientsSurname.Name = "txtUClientsSurname";
            this.txtUClientsSurname.Size = new System.Drawing.Size(67, 18);
            this.txtUClientsSurname.TabIndex = 36;
            this.txtUClientsSurname.Text = "Apellidos";
            // 
            // txtUClientsName
            // 
            this.txtUClientsName.AutoSize = true;
            this.txtUClientsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUClientsName.Location = new System.Drawing.Point(6, 13);
            this.txtUClientsName.Name = "txtUClientsName";
            this.txtUClientsName.Size = new System.Drawing.Size(70, 18);
            this.txtUClientsName.TabIndex = 37;
            this.txtUClientsName.Text = "Nombres";
            // 
            // dtpUClientsBirthday
            // 
            this.dtpUClientsBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUClientsBirthday.Location = new System.Drawing.Point(9, 97);
            this.dtpUClientsBirthday.Name = "dtpUClientsBirthday";
            this.dtpUClientsBirthday.Size = new System.Drawing.Size(265, 24);
            this.dtpUClientsBirthday.TabIndex = 42;
            // 
            // txtUClientsBirthday
            // 
            this.txtUClientsBirthday.AutoSize = true;
            this.txtUClientsBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUClientsBirthday.Location = new System.Drawing.Point(6, 76);
            this.txtUClientsBirthday.Name = "txtUClientsBirthday";
            this.txtUClientsBirthday.Size = new System.Drawing.Size(145, 18);
            this.txtUClientsBirthday.TabIndex = 41;
            this.txtUClientsBirthday.Text = "Fecha de nacimiento";
            // 
            // txtUCellphoneN
            // 
            this.txtUCellphoneN.AutoSize = true;
            this.txtUCellphoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUCellphoneN.Location = new System.Drawing.Point(6, 137);
            this.txtUCellphoneN.Name = "txtUCellphoneN";
            this.txtUCellphoneN.Size = new System.Drawing.Size(85, 18);
            this.txtUCellphoneN.TabIndex = 40;
            this.txtUCellphoneN.Text = "N. Teléfono";
            // 
            // tbUCellphoneN
            // 
            this.tbUCellphoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUCellphoneN.Location = new System.Drawing.Point(97, 134);
            this.tbUCellphoneN.Name = "tbUCellphoneN";
            this.tbUCellphoneN.Size = new System.Drawing.Size(113, 24);
            this.tbUCellphoneN.TabIndex = 38;
            // 
            // tbUDuiDoc
            // 
            this.tbUDuiDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUDuiDoc.Location = new System.Drawing.Point(97, 171);
            this.tbUDuiDoc.Name = "tbUDuiDoc";
            this.tbUDuiDoc.Size = new System.Drawing.Size(113, 24);
            this.tbUDuiDoc.TabIndex = 44;
            // 
            // txtUDuiDoc
            // 
            this.txtUDuiDoc.AutoSize = true;
            this.txtUDuiDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUDuiDoc.Location = new System.Drawing.Point(40, 171);
            this.txtUDuiDoc.Name = "txtUDuiDoc";
            this.txtUDuiDoc.Size = new System.Drawing.Size(33, 18);
            this.txtUDuiDoc.TabIndex = 43;
            this.txtUDuiDoc.Text = "DUI";
            // 
            // tbUEmail
            // 
            this.tbUEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUEmail.Location = new System.Drawing.Point(9, 228);
            this.tbUEmail.Name = "tbUEmail";
            this.tbUEmail.Size = new System.Drawing.Size(265, 24);
            this.tbUEmail.TabIndex = 46;
            // 
            // txtUEmail
            // 
            this.txtUEmail.AutoSize = true;
            this.txtUEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUEmail.Location = new System.Drawing.Point(6, 207);
            this.txtUEmail.Name = "txtUEmail";
            this.txtUEmail.Size = new System.Drawing.Size(134, 18);
            this.txtUEmail.TabIndex = 45;
            this.txtUEmail.Text = "Correo Electrónico";
            // 
            // tbUAddress
            // 
            this.tbUAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUAddress.Location = new System.Drawing.Point(9, 287);
            this.tbUAddress.Multiline = true;
            this.tbUAddress.Name = "tbUAddress";
            this.tbUAddress.Size = new System.Drawing.Size(243, 92);
            this.tbUAddress.TabIndex = 48;
            // 
            // txtUAddress
            // 
            this.txtUAddress.AutoSize = true;
            this.txtUAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUAddress.Location = new System.Drawing.Point(6, 266);
            this.txtUAddress.Name = "txtUAddress";
            this.txtUAddress.Size = new System.Drawing.Size(71, 18);
            this.txtUAddress.TabIndex = 47;
            this.txtUAddress.Text = "Dirección";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(12, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 49);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnClearUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnClearUpdate.Location = new System.Drawing.Point(160, 407);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(114, 49);
            this.btnClearUpdate.TabIndex = 0;
            this.btnClearUpdate.Text = "Limpiar";
            this.btnClearUpdate.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(40, 487);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(22, 18);
            this.txtID.TabIndex = 43;
            this.txtID.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(97, 487);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(113, 24);
            this.tbID.TabIndex = 44;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(790, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(191, 49);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refrescar ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // FrmClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientsView";
            this.Text = "Tabla de clientes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarClient;
        public System.Windows.Forms.ContextMenuStrip cmsMenuClient;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox tbUClientsSurname;
        public System.Windows.Forms.TextBox tbUClientsName;
        public System.Windows.Forms.Label txtUClientsSurname;
        public System.Windows.Forms.Label txtUClientsName;
        public System.Windows.Forms.DateTimePicker dtpUClientsBirthday;
        public System.Windows.Forms.Label txtUClientsBirthday;
        public System.Windows.Forms.Label txtUCellphoneN;
        public System.Windows.Forms.TextBox tbUCellphoneN;
        public System.Windows.Forms.TextBox tbUDuiDoc;
        public System.Windows.Forms.Label txtUDuiDoc;
        public System.Windows.Forms.TextBox tbUEmail;
        public System.Windows.Forms.Label txtUEmail;
        public System.Windows.Forms.TextBox tbUAddress;
        public System.Windows.Forms.Button btnClearUpdate;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label txtUAddress;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.Label txtID;
        public System.Windows.Forms.Button btnRefresh;
    }
}