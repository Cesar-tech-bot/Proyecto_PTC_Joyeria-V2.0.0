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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mskUpdateEmployeeDUI = new System.Windows.Forms.MaskedTextBox();
            this.dtpUpdateBirthDay = new System.Windows.Forms.DateTimePicker();
            this.mskUpdateEmployeePhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtIDEmployee = new System.Windows.Forms.TextBox();
            this.txtUAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployeeName = new System.Windows.Forms.TextBox();
            this.cmbEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmbEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.btnAddEmployee);
            this.panel4.Controls.Add(this.btnRestart);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSearchEmployee);
            this.panel4.Controls.Add(this.txtSearchEmployee);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1395, 102);
            this.panel4.TabIndex = 62;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(1219, 32);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(173, 46);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Añadir";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRestart.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(1044, 32);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(173, 46);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTROL DE EMPLEADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearchEmployee.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployee.Location = new System.Drawing.Point(859, 32);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(173, 46);
            this.btnSearchEmployee.TabIndex = 2;
            this.btnSearchEmployee.Text = "Buscar";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchEmployee.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtSearchEmployee.Location = new System.Drawing.Point(303, 39);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(549, 31);
            this.txtSearchEmployee.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1044, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(191, 49);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.Text = "Refrescar ";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddClients
            // 
            this.btnAddClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddClients.ForeColor = System.Drawing.Color.White;
            this.btnAddClients.Location = new System.Drawing.Point(1241, 23);
            this.btnAddClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(141, 49);
            this.btnAddClients.TabIndex = 61;
            this.btnAddClients.Text = "Añadir";
            this.btnAddClients.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.mskUpdateEmployeeDUI);
            this.panel1.Controls.Add(this.dtpUpdateBirthDay);
            this.panel1.Controls.Add(this.mskUpdateEmployeePhoneNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIDEmployee);
            this.panel1.Controls.Add(this.txtUAddress);
            this.panel1.Controls.Add(this.txtUpdateEmployeeEmail);
            this.panel1.Controls.Add(this.txtUpdateEmployeeLastName);
            this.panel1.Controls.Add(this.txtUpdateEmployeeName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 688);
            this.panel1.TabIndex = 63;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 631);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 46);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(170, 631);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 46);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // mskUpdateEmployeeDUI
            // 
            this.mskUpdateEmployeeDUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mskUpdateEmployeeDUI.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.mskUpdateEmployeeDUI.Location = new System.Drawing.Point(25, 332);
            this.mskUpdateEmployeeDUI.Margin = new System.Windows.Forms.Padding(4);
            this.mskUpdateEmployeeDUI.Mask = "00000000-0";
            this.mskUpdateEmployeeDUI.Name = "mskUpdateEmployeeDUI";
            this.mskUpdateEmployeeDUI.Size = new System.Drawing.Size(265, 31);
            this.mskUpdateEmployeeDUI.TabIndex = 8;
            // 
            // dtpUpdateBirthDay
            // 
            this.dtpUpdateBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpUpdateBirthDay.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.dtpUpdateBirthDay.Location = new System.Drawing.Point(24, 407);
            this.dtpUpdateBirthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpUpdateBirthDay.Name = "dtpUpdateBirthDay";
            this.dtpUpdateBirthDay.Size = new System.Drawing.Size(265, 31);
            this.dtpUpdateBirthDay.TabIndex = 9;
            // 
            // mskUpdateEmployeePhoneNumber
            // 
            this.mskUpdateEmployeePhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mskUpdateEmployeePhoneNumber.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.mskUpdateEmployeePhoneNumber.Location = new System.Drawing.Point(25, 180);
            this.mskUpdateEmployeePhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mskUpdateEmployeePhoneNumber.Mask = "0000-0000";
            this.mskUpdateEmployeePhoneNumber.Name = "mskUpdateEmployeePhoneNumber";
            this.mskUpdateEmployeePhoneNumber.Size = new System.Drawing.Size(265, 31);
            this.mskUpdateEmployeePhoneNumber.TabIndex = 6;
            // 
            // txtIDEmployee
            // 
            this.txtIDEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDEmployee.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtIDEmployee.Location = new System.Drawing.Point(25, 579);
            this.txtIDEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEmployee.Name = "txtIDEmployee";
            this.txtIDEmployee.ReadOnly = true;
            this.txtIDEmployee.Size = new System.Drawing.Size(265, 31);
            this.txtIDEmployee.TabIndex = 11;
            // 
            // txtUAddress
            // 
            this.txtUAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUAddress.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUAddress.Location = new System.Drawing.Point(25, 484);
            this.txtUAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtUAddress.Multiline = true;
            this.txtUAddress.Name = "txtUAddress";
            this.txtUAddress.Size = new System.Drawing.Size(265, 50);
            this.txtUAddress.TabIndex = 10;
            // 
            // txtUpdateEmployeeEmail
            // 
            this.txtUpdateEmployeeEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateEmployeeEmail.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUpdateEmployeeEmail.Location = new System.Drawing.Point(25, 253);
            this.txtUpdateEmployeeEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateEmployeeEmail.Name = "txtUpdateEmployeeEmail";
            this.txtUpdateEmployeeEmail.Size = new System.Drawing.Size(265, 31);
            this.txtUpdateEmployeeEmail.TabIndex = 7;
            // 
            // txtUpdateEmployeeLastName
            // 
            this.txtUpdateEmployeeLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateEmployeeLastName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUpdateEmployeeLastName.Location = new System.Drawing.Point(25, 106);
            this.txtUpdateEmployeeLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateEmployeeLastName.Name = "txtUpdateEmployeeLastName";
            this.txtUpdateEmployeeLastName.Size = new System.Drawing.Size(265, 31);
            this.txtUpdateEmployeeLastName.TabIndex = 5;
            // 
            // txtUpdateEmployeeName
            // 
            this.txtUpdateEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateEmployeeName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUpdateEmployeeName.Location = new System.Drawing.Point(25, 36);
            this.txtUpdateEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateEmployeeName.Name = "txtUpdateEmployeeName";
            this.txtUpdateEmployeeName.Size = new System.Drawing.Size(265, 31);
            this.txtUpdateEmployeeName.TabIndex = 4;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmbEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbDelete});
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(205, 28);
            // 
            // cmbDelete
            // 
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(204, 24);
            this.cmbDelete.Text = "Eliminar Empleado";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(323, 102);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1072, 688);
            this.dgvEmployees.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoSize = true;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(21, 457);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(110, 23);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "DUI";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de teléfono";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.AutoSize = true;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(22, 552);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(33, 23);
            this.txtID.TabIndex = 3;
            this.txtID.Text = "ID";
            // 
            // FrmEmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 790);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddClients);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmployeesView";
            this.Text = "EmployeesView";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmbEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSearchEmployee;
        public System.Windows.Forms.TextBox txtSearchEmployee;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnAddClients;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtUpdateEmployeeLastName;
        public System.Windows.Forms.TextBox txtUpdateEmployeeName;
        public System.Windows.Forms.MaskedTextBox mskUpdateEmployeePhoneNumber;
        public System.Windows.Forms.TextBox txtUpdateEmployeeEmail;
        public System.Windows.Forms.MaskedTextBox mskUpdateEmployeeDUI;
        public System.Windows.Forms.Button btnRestart;
        public System.Windows.Forms.Button btnAddEmployee;
        public System.Windows.Forms.DateTimePicker dtpUpdateBirthDay;
        public System.Windows.Forms.TextBox txtIDEmployee;
        public System.Windows.Forms.TextBox txtUAddress;
        public System.Windows.Forms.ContextMenuStrip cmbEmployee;
        public System.Windows.Forms.ToolStripMenuItem cmbDelete;
        public System.Windows.Forms.DataGridView dgvEmployees;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label txtID;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label txtAddress;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
    }
}