namespace SistemaJoyería.View.EmployeesView
{
    partial class FrmEmployeesView
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.tbSearchEmpleoyee = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeep = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mskUpdateEmployeeID = new System.Windows.Forms.MaskedTextBox();
            this.dtpUpdateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.mskUpdateEmployeePhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtUpdateEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployeeName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.btnRestart);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSearchEmployee);
            this.panel4.Controls.Add(this.tbSearchEmpleoyee);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1046, 83);
            this.panel4.TabIndex = 62;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(882, 26);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(130, 37);
            this.btnRestart.TabIndex = 67;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTROL DE EMPLEADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployee.Location = new System.Drawing.Point(713, 26);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(130, 37);
            this.btnSearchEmployee.TabIndex = 2;
            this.btnSearchEmployee.Text = "Buscar";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            // 
            // tbSearchEmpleoyee
            // 
            this.tbSearchEmpleoyee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchEmpleoyee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbSearchEmpleoyee.Location = new System.Drawing.Point(242, 31);
            this.tbSearchEmpleoyee.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchEmpleoyee.Name = "tbSearchEmpleoyee";
            this.tbSearchEmpleoyee.Size = new System.Drawing.Size(413, 26);
            this.tbSearchEmpleoyee.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(783, 19);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 40);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.Text = "Refrescar ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddClients
            // 
            this.btnAddClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddClients.ForeColor = System.Drawing.Color.White;
            this.btnAddClients.Location = new System.Drawing.Point(931, 19);
            this.btnAddClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(106, 40);
            this.btnAddClients.TabIndex = 61;
            this.btnAddClients.Text = "Añadir";
            this.btnAddClients.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnKeep);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.mskUpdateEmployeeID);
            this.panel1.Controls.Add(this.dtpUpdateBirthDay);
            this.panel1.Controls.Add(this.mskUpdateEmployeePhoneNumber);
            this.panel1.Controls.Add(this.txtUpdateEmployeeEmail);
            this.panel1.Controls.Add(this.txtUpdateEmployeeLastName);
            this.panel1.Controls.Add(this.txtUpdateEmployeeName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 559);
            this.panel1.TabIndex = 63;
            // 
            // btnKeep
            // 
            this.btnKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnKeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnKeep.ForeColor = System.Drawing.Color.White;
            this.btnKeep.Location = new System.Drawing.Point(124, 438);
            this.btnKeep.Margin = new System.Windows.Forms.Padding(2);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(94, 37);
            this.btnKeep.TabIndex = 66;
            this.btnKeep.Text = "Guardar";
            this.btnKeep.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(12, 438);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 37);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // mskUpdateEmployeeID
            // 
            this.mskUpdateEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mskUpdateEmployeeID.Location = new System.Drawing.Point(18, 326);
            this.mskUpdateEmployeeID.Mask = "00000000-0";
            this.mskUpdateEmployeeID.Name = "mskUpdateEmployeeID";
            this.mskUpdateEmployeeID.Size = new System.Drawing.Size(200, 20);
            this.mskUpdateEmployeeID.TabIndex = 12;
            // 
            // dtpUpdateBirthDay
            // 
            this.dtpUpdateBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpUpdateBirthDay.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic);
            this.dtpUpdateBirthDay.Location = new System.Drawing.Point(18, 388);
            this.dtpUpdateBirthDay.Name = "dtpUpdateBirthDay";
            this.dtpUpdateBirthDay.Size = new System.Drawing.Size(200, 27);
            this.dtpUpdateBirthDay.TabIndex = 11;
            // 
            // mskUpdateEmployeePhoneNumber
            // 
            this.mskUpdateEmployeePhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mskUpdateEmployeePhoneNumber.Location = new System.Drawing.Point(18, 202);
            this.mskUpdateEmployeePhoneNumber.Mask = "0000-0000";
            this.mskUpdateEmployeePhoneNumber.Name = "mskUpdateEmployeePhoneNumber";
            this.mskUpdateEmployeePhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.mskUpdateEmployeePhoneNumber.TabIndex = 9;
            // 
            // txtUpdateEmployeeEmail
            // 
            this.txtUpdateEmployeeEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateEmployeeEmail.Location = new System.Drawing.Point(18, 264);
            this.txtUpdateEmployeeEmail.Name = "txtUpdateEmployeeEmail";
            this.txtUpdateEmployeeEmail.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateEmployeeEmail.TabIndex = 8;
            // 
            // txtUpdateEmployeeLastName
            // 
            this.txtUpdateEmployeeLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateEmployeeLastName.Location = new System.Drawing.Point(18, 140);
            this.txtUpdateEmployeeLastName.Name = "txtUpdateEmployeeLastName";
            this.txtUpdateEmployeeLastName.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateEmployeeLastName.TabIndex = 7;
            // 
            // txtUpdateEmployeeName
            // 
            this.txtUpdateEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateEmployeeName.Location = new System.Drawing.Point(18, 78);
            this.txtUpdateEmployeeName.Name = "txtUpdateEmployeeName";
            this.txtUpdateEmployeeName.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateEmployeeName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(15, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(15, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "DUI";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de telefono";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEmployees.Location = new System.Drawing.Point(242, 83);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(804, 559);
            this.dgvEmployees.TabIndex = 64;
            // 
            // FrmEmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 642);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddClients);
            this.Name = "FrmEmployeesView";
            this.Text = "EmployeesView";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSearchEmployee;
        public System.Windows.Forms.TextBox tbSearchEmpleoyee;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnAddClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpUpdateBirthDay;
        public System.Windows.Forms.Button btnKeep;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtUpdateEmployeeLastName;
        public System.Windows.Forms.TextBox txtUpdateEmployeeName;
        public System.Windows.Forms.MaskedTextBox mskUpdateEmployeePhoneNumber;
        public System.Windows.Forms.TextBox txtUpdateEmployeeEmail;
        public System.Windows.Forms.MaskedTextBox mskUpdateEmployeeID;
        public System.Windows.Forms.Button btnRestart;
    }
}