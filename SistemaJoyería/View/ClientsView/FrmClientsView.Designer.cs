﻿namespace SistemaJoyería.View.ClientsView
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClearUpdate = new System.Windows.Forms.Button();
            this.tbUEmail = new System.Windows.Forms.TextBox();
            this.txtUAddress = new System.Windows.Forms.Label();
            this.tbUAddress = new System.Windows.Forms.TextBox();
            this.txtUEmail = new System.Windows.Forms.Label();
            this.mskUDuiDoc = new System.Windows.Forms.MaskedTextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.mskUCellphoneN = new System.Windows.Forms.MaskedTextBox();
            this.txtUDuiDoc = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpUClientsBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.Label();
            this.txtUCellphoneN = new System.Windows.Forms.Label();
            this.tbUClientsName = new System.Windows.Forms.TextBox();
            this.tbUClientsSurname = new System.Windows.Forms.TextBox();
            this.txtUClientsBirthday = new System.Windows.Forms.Label();
            this.txtUClientsName = new System.Windows.Forms.Label();
            this.txtUClientsSurname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 528);
            this.panel2.TabIndex = 7;
            // 
            // dgvClientsTable
            // 
            this.dgvClientsTable.AllowUserToAddRows = false;
            this.dgvClientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientsTable.Location = new System.Drawing.Point(328, 0);
            this.dgvClientsTable.Name = "dgvClientsTable";
            this.dgvClientsTable.ReadOnly = true;
            this.dgvClientsTable.RowHeadersVisible = false;
            this.dgvClientsTable.RowHeadersWidth = 51;
            this.dgvClientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientsTable.Size = new System.Drawing.Size(700, 528);
            this.dgvClientsTable.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.btnClearUpdate);
            this.panel5.Controls.Add(this.tbUEmail);
            this.panel5.Controls.Add(this.txtUAddress);
            this.panel5.Controls.Add(this.tbUAddress);
            this.panel5.Controls.Add(this.txtUEmail);
            this.panel5.Controls.Add(this.mskUDuiDoc);
            this.panel5.Controls.Add(this.tbID);
            this.panel5.Controls.Add(this.mskUCellphoneN);
            this.panel5.Controls.Add(this.txtUDuiDoc);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.dtpUClientsBirthday);
            this.panel5.Controls.Add(this.txtID);
            this.panel5.Controls.Add(this.txtUCellphoneN);
            this.panel5.Controls.Add(this.tbUClientsName);
            this.panel5.Controls.Add(this.tbUClientsSurname);
            this.panel5.Controls.Add(this.txtUClientsBirthday);
            this.panel5.Controls.Add(this.txtUClientsName);
            this.panel5.Controls.Add(this.txtUClientsSurname);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 528);
            this.panel5.TabIndex = 59;
            // 
            // btnClearUpdate
            // 
            this.btnClearUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClearUpdate.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearUpdate.ForeColor = System.Drawing.Color.White;
            this.btnClearUpdate.Location = new System.Drawing.Point(25, 555);
            this.btnClearUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearUpdate.Name = "btnClearUpdate";
            this.btnClearUpdate.Size = new System.Drawing.Size(124, 48);
            this.btnClearUpdate.TabIndex = 13;
            this.btnClearUpdate.Text = "Limpiar";
            this.btnClearUpdate.UseVisualStyleBackColor = false;
            // 
            // tbUEmail
            // 
            this.tbUEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.tbUEmail.Location = new System.Drawing.Point(9, 353);
            this.tbUEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUEmail.Name = "tbUEmail";
            this.tbUEmail.Size = new System.Drawing.Size(296, 26);
            this.tbUEmail.TabIndex = 10;
            // 
            // txtUAddress
            // 
            this.txtUAddress.AutoSize = true;
            this.txtUAddress.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtUAddress.Location = new System.Drawing.Point(5, 395);
            this.txtUAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUAddress.Name = "txtUAddress";
            this.txtUAddress.Size = new System.Drawing.Size(84, 18);
            this.txtUAddress.TabIndex = 47;
            this.txtUAddress.Text = "Dirección";
            // 
            // tbUAddress
            // 
            this.tbUAddress.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.tbUAddress.Location = new System.Drawing.Point(9, 417);
            this.tbUAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUAddress.Multiline = true;
            this.tbUAddress.Name = "tbUAddress";
            this.tbUAddress.Size = new System.Drawing.Size(296, 69);
            this.tbUAddress.TabIndex = 11;
            // 
            // txtUEmail
            // 
            this.txtUEmail.AutoSize = true;
            this.txtUEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtUEmail.Location = new System.Drawing.Point(5, 332);
            this.txtUEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUEmail.Name = "txtUEmail";
            this.txtUEmail.Size = new System.Drawing.Size(160, 18);
            this.txtUEmail.TabIndex = 45;
            this.txtUEmail.Text = "Correo Electrónico";
            // 
            // mskUDuiDoc
            // 
            this.mskUDuiDoc.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.mskUDuiDoc.Location = new System.Drawing.Point(9, 291);
            this.mskUDuiDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskUDuiDoc.Mask = "00000000-0";
            this.mskUDuiDoc.Name = "mskUDuiDoc";
            this.mskUDuiDoc.Size = new System.Drawing.Size(296, 26);
            this.mskUDuiDoc.TabIndex = 9;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.tbID.Location = new System.Drawing.Point(9, 516);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(296, 26);
            this.tbID.TabIndex = 12;
            // 
            // mskUCellphoneN
            // 
            this.mskUCellphoneN.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.mskUCellphoneN.Location = new System.Drawing.Point(9, 230);
            this.mskUCellphoneN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskUCellphoneN.Mask = "0000-0000";
            this.mskUCellphoneN.Name = "mskUCellphoneN";
            this.mskUCellphoneN.Size = new System.Drawing.Size(296, 26);
            this.mskUCellphoneN.TabIndex = 8;
            // 
            // txtUDuiDoc
            // 
            this.txtUDuiDoc.AutoSize = true;
            this.txtUDuiDoc.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtUDuiDoc.Location = new System.Drawing.Point(5, 269);
            this.txtUDuiDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUDuiDoc.Name = "txtUDuiDoc";
            this.txtUDuiDoc.Size = new System.Drawing.Size(40, 18);
            this.txtUDuiDoc.TabIndex = 43;
            this.txtUDuiDoc.Text = "DUI";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(180, 555);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 48);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dtpUClientsBirthday
            // 
            this.dtpUClientsBirthday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.dtpUClientsBirthday.Location = new System.Drawing.Point(9, 163);
            this.dtpUClientsBirthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpUClientsBirthday.Name = "dtpUClientsBirthday";
            this.dtpUClientsBirthday.Size = new System.Drawing.Size(296, 26);
            this.dtpUClientsBirthday.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(5, 494);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(27, 18);
            this.txtID.TabIndex = 43;
            this.txtID.Text = "ID";
            // 
            // txtUCellphoneN
            // 
            this.txtUCellphoneN.AutoSize = true;
            this.txtUCellphoneN.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtUCellphoneN.Location = new System.Drawing.Point(5, 208);
            this.txtUCellphoneN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUCellphoneN.Name = "txtUCellphoneN";
            this.txtUCellphoneN.Size = new System.Drawing.Size(102, 18);
            this.txtUCellphoneN.TabIndex = 40;
            this.txtUCellphoneN.Text = "N. Teléfono";
            // 
            // tbUClientsName
            // 
            this.tbUClientsName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.tbUClientsName.Location = new System.Drawing.Point(9, 35);
            this.tbUClientsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUClientsName.Name = "tbUClientsName";
            this.tbUClientsName.Size = new System.Drawing.Size(296, 26);
            this.tbUClientsName.TabIndex = 5;
            // 
            // tbUClientsSurname
            // 
            this.tbUClientsSurname.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.tbUClientsSurname.Location = new System.Drawing.Point(9, 99);
            this.tbUClientsSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUClientsSurname.Name = "tbUClientsSurname";
            this.tbUClientsSurname.Size = new System.Drawing.Size(296, 26);
            this.tbUClientsSurname.TabIndex = 6;
            // 
            // txtUClientsBirthday
            // 
            this.txtUClientsBirthday.AutoSize = true;
            this.txtUClientsBirthday.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtUClientsBirthday.Location = new System.Drawing.Point(5, 141);
            this.txtUClientsBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUClientsBirthday.Name = "txtUClientsBirthday";
            this.txtUClientsBirthday.Size = new System.Drawing.Size(175, 18);
            this.txtUClientsBirthday.TabIndex = 41;
            this.txtUClientsBirthday.Text = "Fecha de nacimiento";
            // 
            // txtUClientsName
            // 
            this.txtUClientsName.AutoSize = true;
            this.txtUClientsName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtUClientsName.Location = new System.Drawing.Point(5, 13);
            this.txtUClientsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUClientsName.Name = "txtUClientsName";
            this.txtUClientsName.Size = new System.Drawing.Size(81, 18);
            this.txtUClientsName.TabIndex = 37;
            this.txtUClientsName.Text = "Nombres";
            // 
            // txtUClientsSurname
            // 
            this.txtUClientsSurname.AutoSize = true;
            this.txtUClientsSurname.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.txtUClientsSurname.Location = new System.Drawing.Point(5, 77);
            this.txtUClientsSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUClientsSurname.Name = "txtUClientsSurname";
            this.txtUClientsSurname.Size = new System.Drawing.Size(81, 18);
            this.txtUClientsSurname.TabIndex = 36;
            this.txtUClientsSurname.Text = "Apellidos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddClients);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 81);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 442);
            this.panel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(783, 19);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refrescar ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddClients
            // 
            this.btnAddClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddClients.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddClients.ForeColor = System.Drawing.Color.White;
            this.btnAddClients.Location = new System.Drawing.Point(931, 19);
            this.btnAddClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(106, 40);
            this.btnAddClients.TabIndex = 4;
            this.btnAddClients.Text = "Añadir";
            this.btnAddClients.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSearchClient);
            this.panel4.Controls.Add(this.tbSearchClient);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 83);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTROL DE CLIENTES";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearchClient.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchClient.ForeColor = System.Drawing.Color.White;
            this.btnSearchClient.Location = new System.Drawing.Point(580, 19);
            this.btnSearchClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(143, 40);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.Text = "Buscar";
            this.btnSearchClient.UseVisualStyleBackColor = false;
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.tbSearchClient.Location = new System.Drawing.Point(270, 29);
            this.tbSearchClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(296, 26);
            this.tbSearchClient.TabIndex = 1;
            // 
            // FrmClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientsView";
            this.Text = "Tabla de clientes";
            this.panel2.ResumeLayout(false);
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
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSearchClient;
        public System.Windows.Forms.TextBox tbSearchClient;
    }
}