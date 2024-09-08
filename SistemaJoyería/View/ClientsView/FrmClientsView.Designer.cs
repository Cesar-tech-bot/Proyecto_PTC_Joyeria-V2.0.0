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
            this.tbUAddress = new System.Windows.Forms.TextBox();
            this.tbUEmail = new System.Windows.Forms.TextBox();
            this.mskUDuiDoc = new System.Windows.Forms.MaskedTextBox();
            this.mskUCellphoneN = new System.Windows.Forms.MaskedTextBox();
            this.dtpUClientsBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbUClientsSurname = new System.Windows.Forms.TextBox();
            this.tbUClientsName = new System.Windows.Forms.TextBox();
            this.txtUAddress = new System.Windows.Forms.Label();
            this.txtUEmail = new System.Windows.Forms.Label();
            this.txtUDuiDoc = new System.Windows.Forms.Label();
            this.txtUClientsBirthday = new System.Windows.Forms.Label();
            this.txtUCellphoneN = new System.Windows.Forms.Label();
            this.txtUClientsSurname = new System.Windows.Forms.Label();
            this.txtUClientsName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbSearchClients = new System.Windows.Forms.TextBox();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClientsTable);
            this.panel2.Controls.Add(this.tbUAddress);
            this.panel2.Controls.Add(this.tbUEmail);
            this.panel2.Controls.Add(this.mskUDuiDoc);
            this.panel2.Controls.Add(this.mskUCellphoneN);
            this.panel2.Controls.Add(this.dtpUClientsBirthday);
            this.panel2.Controls.Add(this.tbUClientsSurname);
            this.panel2.Controls.Add(this.tbUClientsName);
            this.panel2.Controls.Add(this.txtUAddress);
            this.panel2.Controls.Add(this.txtUEmail);
            this.panel2.Controls.Add(this.txtUDuiDoc);
            this.panel2.Controls.Add(this.txtUClientsBirthday);
            this.panel2.Controls.Add(this.txtUCellphoneN);
            this.panel2.Controls.Add(this.txtUClientsSurname);
            this.panel2.Controls.Add(this.txtUClientsName);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 955);
            this.panel2.TabIndex = 7;
            // 
            // dgvClientsTable
            // 
            this.dgvClientsTable.AllowUserToAddRows = false;
            this.dgvClientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.dgvClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientsTable.Location = new System.Drawing.Point(438, 0);
            this.dgvClientsTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientsTable.Name = "dgvClientsTable";
            this.dgvClientsTable.ReadOnly = true;
            this.dgvClientsTable.RowHeadersVisible = false;
            this.dgvClientsTable.RowHeadersWidth = 51;
            this.dgvClientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientsTable.Size = new System.Drawing.Size(1486, 955);
            this.dgvClientsTable.TabIndex = 15;
            // 
            // tbUAddress
            // 
            this.tbUAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUAddress.Location = new System.Drawing.Point(19, 540);
            this.tbUAddress.Multiline = true;
            this.tbUAddress.Name = "tbUAddress";
            this.tbUAddress.Size = new System.Drawing.Size(369, 84);
            this.tbUAddress.TabIndex = 11;
            // 
            // tbUEmail
            // 
            this.tbUEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUEmail.Location = new System.Drawing.Point(19, 425);
            this.tbUEmail.Name = "tbUEmail";
            this.tbUEmail.Size = new System.Drawing.Size(369, 30);
            this.tbUEmail.TabIndex = 10;
            // 
            // mskUDuiDoc
            // 
            this.mskUDuiDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskUDuiDoc.Location = new System.Drawing.Point(160, 306);
            this.mskUDuiDoc.Mask = "00000000-0";
            this.mskUDuiDoc.Name = "mskUDuiDoc";
            this.mskUDuiDoc.Size = new System.Drawing.Size(134, 30);
            this.mskUDuiDoc.TabIndex = 9;
            // 
            // mskUCellphoneN
            // 
            this.mskUCellphoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskUCellphoneN.Location = new System.Drawing.Point(160, 252);
            this.mskUCellphoneN.Mask = "0000-0000";
            this.mskUCellphoneN.Name = "mskUCellphoneN";
            this.mskUCellphoneN.Size = new System.Drawing.Size(115, 30);
            this.mskUCellphoneN.TabIndex = 8;
            // 
            // dtpUClientsBirthday
            // 
            this.dtpUClientsBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUClientsBirthday.Location = new System.Drawing.Point(17, 186);
            this.dtpUClientsBirthday.Name = "dtpUClientsBirthday";
            this.dtpUClientsBirthday.Size = new System.Drawing.Size(371, 30);
            this.dtpUClientsBirthday.TabIndex = 7;
            // 
            // tbUClientsSurname
            // 
            this.tbUClientsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUClientsSurname.Location = new System.Drawing.Point(128, 69);
            this.tbUClientsSurname.Name = "tbUClientsSurname";
            this.tbUClientsSurname.Size = new System.Drawing.Size(279, 30);
            this.tbUClientsSurname.TabIndex = 6;
            // 
            // tbUClientsName
            // 
            this.tbUClientsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUClientsName.Location = new System.Drawing.Point(128, 16);
            this.tbUClientsName.Name = "tbUClientsName";
            this.tbUClientsName.Size = new System.Drawing.Size(279, 30);
            this.tbUClientsName.TabIndex = 5;
            // 
            // txtUAddress
            // 
            this.txtUAddress.AutoSize = true;
            this.txtUAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUAddress.Location = new System.Drawing.Point(21, 495);
            this.txtUAddress.Name = "txtUAddress";
            this.txtUAddress.Size = new System.Drawing.Size(93, 25);
            this.txtUAddress.TabIndex = 47;
            this.txtUAddress.Text = "Dirección";
            // 
            // txtUEmail
            // 
            this.txtUEmail.AutoSize = true;
            this.txtUEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUEmail.Location = new System.Drawing.Point(13, 380);
            this.txtUEmail.Name = "txtUEmail";
            this.txtUEmail.Size = new System.Drawing.Size(173, 25);
            this.txtUEmail.TabIndex = 45;
            this.txtUEmail.Text = "Correo Electrónico";
            // 
            // txtUDuiDoc
            // 
            this.txtUDuiDoc.AutoSize = true;
            this.txtUDuiDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUDuiDoc.Location = new System.Drawing.Point(64, 306);
            this.txtUDuiDoc.Name = "txtUDuiDoc";
            this.txtUDuiDoc.Size = new System.Drawing.Size(45, 25);
            this.txtUDuiDoc.TabIndex = 43;
            this.txtUDuiDoc.Text = "DUI";
            // 
            // txtUClientsBirthday
            // 
            this.txtUClientsBirthday.AutoSize = true;
            this.txtUClientsBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUClientsBirthday.Location = new System.Drawing.Point(12, 136);
            this.txtUClientsBirthday.Name = "txtUClientsBirthday";
            this.txtUClientsBirthday.Size = new System.Drawing.Size(193, 25);
            this.txtUClientsBirthday.TabIndex = 41;
            this.txtUClientsBirthday.Text = "Fecha de nacimiento";
            // 
            // txtUCellphoneN
            // 
            this.txtUCellphoneN.AutoSize = true;
            this.txtUCellphoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUCellphoneN.Location = new System.Drawing.Point(21, 252);
            this.txtUCellphoneN.Name = "txtUCellphoneN";
            this.txtUCellphoneN.Size = new System.Drawing.Size(113, 25);
            this.txtUCellphoneN.TabIndex = 40;
            this.txtUCellphoneN.Text = "N. Teléfono";
            // 
            // txtUClientsSurname
            // 
            this.txtUClientsSurname.AutoSize = true;
            this.txtUClientsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUClientsSurname.Location = new System.Drawing.Point(13, 69);
            this.txtUClientsSurname.Name = "txtUClientsSurname";
            this.txtUClientsSurname.Size = new System.Drawing.Size(92, 25);
            this.txtUClientsSurname.TabIndex = 36;
            this.txtUClientsSurname.Text = "Apellidos";
            // 
            // txtUClientsName
            // 
            this.txtUClientsName.AutoSize = true;
            this.txtUClientsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUClientsName.Location = new System.Drawing.Point(14, 19);
            this.txtUClientsName.Name = "txtUClientsName";
            this.txtUClientsName.Size = new System.Drawing.Size(91, 25);
            this.txtUClientsName.TabIndex = 37;
            this.txtUClientsName.Text = "Nombres";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.btnClearUpdate);
            this.panel5.Controls.Add(this.tbID);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.txtID);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(438, 955);
            this.panel5.TabIndex = 59;
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUpdate.Location = new System.Drawing.Point(29, 699);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(166, 83);
            this.btnClearUpdate.TabIndex = 12;
            this.btnClearUpdate.Text = "Limpiar";
            this.btnClearUpdate.UseVisualStyleBackColor = true;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(175, 821);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 38);
            this.tbID.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(241, 699);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 83);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(122, 824);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(41, 32);
            this.txtID.TabIndex = 43;
            this.txtID.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddClients);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 544);
            this.panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(1574, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(191, 49);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refrescar ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddClients
            // 
            this.btnAddClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClients.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClients.ForeColor = System.Drawing.Color.Black;
            this.btnAddClients.Location = new System.Drawing.Point(1771, 23);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(141, 49);
            this.btnAddClients.TabIndex = 4;
            this.btnAddClients.Text = "Añadir";
            this.btnAddClients.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.tbSearchClients);
            this.panel4.Controls.Add(this.btnSearchClients);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1924, 102);
            this.panel4.TabIndex = 13;
            // 
            // tbSearchClients
            // 
            this.tbSearchClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSearchClients.Location = new System.Drawing.Point(655, 35);
            this.tbSearchClients.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchClients.Multiline = true;
            this.tbSearchClients.Name = "tbSearchClients";
            this.tbSearchClients.Size = new System.Drawing.Size(583, 37);
            this.tbSearchClients.TabIndex = 1;
            // 
            // btnSearchClients
            // 
            this.btnSearchClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchClients.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClients.ForeColor = System.Drawing.Color.Black;
            this.btnSearchClients.Location = new System.Drawing.Point(1327, 18);
            this.btnSearchClients.Name = "btnSearchClients";
            this.btnSearchClients.Size = new System.Drawing.Size(192, 58);
            this.btnSearchClients.TabIndex = 2;
            this.btnSearchClients.Text = "Buscar";
            this.btnSearchClients.UseVisualStyleBackColor = false;
            // 
            // FrmClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2554, 1318);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "FrmClientsView";
            this.Text = "Tabla de clientes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnAddClients;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label txtUClientsSurname;
        public System.Windows.Forms.Label txtUClientsName;
        public System.Windows.Forms.Label txtUClientsBirthday;
        public System.Windows.Forms.Label txtUCellphoneN;
        public System.Windows.Forms.Label txtUDuiDoc;
        public System.Windows.Forms.Label txtUEmail;
        public System.Windows.Forms.Label txtUAddress;
        public System.Windows.Forms.Label txtID;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.TextBox tbUClientsName;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClearUpdate;
        public System.Windows.Forms.TextBox tbUAddress;
        public System.Windows.Forms.TextBox tbUEmail;
        public System.Windows.Forms.MaskedTextBox mskUDuiDoc;
        public System.Windows.Forms.MaskedTextBox mskUCellphoneN;
        public System.Windows.Forms.DateTimePicker dtpUClientsBirthday;
        public System.Windows.Forms.TextBox tbUClientsSurname;
        public System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.DataGridView dgvClientsTable;
        public System.Windows.Forms.TextBox tbSearchClients;
        public System.Windows.Forms.Button btnSearchClients;
    }
}