﻿namespace SistemaJoyería.View.EmployeesView
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
            this.txtID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.cmbEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.cmbEmployee.SuspendLayout();
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
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
<<<<<<< HEAD
            this.btnAddEmployee.Location = new System.Drawing.Point(914, 26);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnAddEmployee.Location = new System.Drawing.Point(1219, 32);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
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
<<<<<<< HEAD
            this.btnRestart.Location = new System.Drawing.Point(783, 26);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnRestart.Location = new System.Drawing.Point(1044, 32);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
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
<<<<<<< HEAD
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
=======
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
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
<<<<<<< HEAD
            this.btnSearchEmployee.Location = new System.Drawing.Point(644, 26);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnSearchEmployee.Location = new System.Drawing.Point(859, 32);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
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
<<<<<<< HEAD
            this.txtSearchEmployee.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtSearchEmployee.Location = new System.Drawing.Point(227, 32);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
=======
            this.txtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearchEmployee.Location = new System.Drawing.Point(303, 39);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(549, 30);
            this.txtSearchEmployee.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnRefresh.Location = new System.Drawing.Point(783, 19);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnRefresh.Location = new System.Drawing.Point(1044, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
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
<<<<<<< HEAD
            this.btnAddClients.Location = new System.Drawing.Point(931, 19);
            this.btnAddClients.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnAddClients.Location = new System.Drawing.Point(1241, 23);
            this.btnAddClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
<<<<<<< HEAD
            this.btnClear.Location = new System.Drawing.Point(18, 454);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnClear.Location = new System.Drawing.Point(24, 559);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 46);
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
<<<<<<< HEAD
            this.btnUpdate.Location = new System.Drawing.Point(124, 456);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnUpdate.Location = new System.Drawing.Point(165, 561);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 46);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // mskUpdateEmployeeDUI
            // 
            this.mskUpdateEmployeeDUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.mskUpdateEmployeeDUI.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.mskUpdateEmployeeDUI.Location = new System.Drawing.Point(18, 228);
            this.mskUpdateEmployeeDUI.Mask = "00000000-0";
            this.mskUpdateEmployeeDUI.Name = "mskUpdateEmployeeDUI";
            this.mskUpdateEmployeeDUI.Size = new System.Drawing.Size(200, 26);
            this.mskUpdateEmployeeDUI.TabIndex = 12;
=======
            this.mskUpdateEmployeeDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mskUpdateEmployeeDUI.Location = new System.Drawing.Point(24, 281);
            this.mskUpdateEmployeeDUI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskUpdateEmployeeDUI.Mask = "00000000-0";
            this.mskUpdateEmployeeDUI.Name = "mskUpdateEmployeeDUI";
            this.mskUpdateEmployeeDUI.Size = new System.Drawing.Size(265, 26);
            this.mskUpdateEmployeeDUI.TabIndex = 8;
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // dtpUpdateBirthDay
            // 
            this.dtpUpdateBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.dtpUpdateBirthDay.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.dtpUpdateBirthDay.Location = new System.Drawing.Point(19, 285);
            this.dtpUpdateBirthDay.Name = "dtpUpdateBirthDay";
            this.dtpUpdateBirthDay.Size = new System.Drawing.Size(200, 26);
            this.dtpUpdateBirthDay.TabIndex = 11;
=======
            this.dtpUpdateBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dtpUpdateBirthDay.Location = new System.Drawing.Point(25, 351);
            this.dtpUpdateBirthDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpUpdateBirthDay.Name = "dtpUpdateBirthDay";
            this.dtpUpdateBirthDay.Size = new System.Drawing.Size(265, 26);
            this.dtpUpdateBirthDay.TabIndex = 9;
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // mskUpdateEmployeePhoneNumber
            // 
            this.mskUpdateEmployeePhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.mskUpdateEmployeePhoneNumber.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.mskUpdateEmployeePhoneNumber.Location = new System.Drawing.Point(19, 125);
            this.mskUpdateEmployeePhoneNumber.Mask = "0000-0000";
            this.mskUpdateEmployeePhoneNumber.Name = "mskUpdateEmployeePhoneNumber";
            this.mskUpdateEmployeePhoneNumber.Size = new System.Drawing.Size(200, 26);
            this.mskUpdateEmployeePhoneNumber.TabIndex = 9;
=======
            this.mskUpdateEmployeePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mskUpdateEmployeePhoneNumber.Location = new System.Drawing.Point(25, 154);
            this.mskUpdateEmployeePhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskUpdateEmployeePhoneNumber.Mask = "0000-0000";
            this.mskUpdateEmployeePhoneNumber.Name = "mskUpdateEmployeePhoneNumber";
            this.mskUpdateEmployeePhoneNumber.Size = new System.Drawing.Size(265, 26);
            this.mskUpdateEmployeePhoneNumber.TabIndex = 6;
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // txtIDEmployee
            // 
            this.txtIDEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtIDEmployee.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtIDEmployee.Location = new System.Drawing.Point(18, 401);
            this.txtIDEmployee.Name = "txtIDEmployee";
            this.txtIDEmployee.ReadOnly = true;
            this.txtIDEmployee.Size = new System.Drawing.Size(200, 26);
            this.txtIDEmployee.TabIndex = 8;
=======
            this.txtIDEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDEmployee.Location = new System.Drawing.Point(24, 494);
            this.txtIDEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDEmployee.Name = "txtIDEmployee";
            this.txtIDEmployee.ReadOnly = true;
            this.txtIDEmployee.Size = new System.Drawing.Size(265, 26);
            this.txtIDEmployee.TabIndex = 11;
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // txtUAddress
            // 
            this.txtUAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtUAddress.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUAddress.Location = new System.Drawing.Point(19, 335);
=======
            this.txtUAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtUAddress.Location = new System.Drawing.Point(25, 412);
            this.txtUAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.txtUAddress.Multiline = true;
            this.txtUAddress.Name = "txtUAddress";
            this.txtUAddress.Size = new System.Drawing.Size(265, 50);
            this.txtUAddress.TabIndex = 10;
            // 
            // txtUpdateEmployeeEmail
            // 
            this.txtUpdateEmployeeEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtUpdateEmployeeEmail.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUpdateEmployeeEmail.Location = new System.Drawing.Point(19, 175);
            this.txtUpdateEmployeeEmail.Name = "txtUpdateEmployeeEmail";
            this.txtUpdateEmployeeEmail.Size = new System.Drawing.Size(200, 26);
            this.txtUpdateEmployeeEmail.TabIndex = 8;
=======
            this.txtUpdateEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtUpdateEmployeeEmail.Location = new System.Drawing.Point(25, 215);
            this.txtUpdateEmployeeEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateEmployeeEmail.Name = "txtUpdateEmployeeEmail";
            this.txtUpdateEmployeeEmail.Size = new System.Drawing.Size(265, 26);
            this.txtUpdateEmployeeEmail.TabIndex = 7;
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // txtUpdateEmployeeLastName
            // 
            this.txtUpdateEmployeeLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtUpdateEmployeeLastName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUpdateEmployeeLastName.Location = new System.Drawing.Point(19, 76);
            this.txtUpdateEmployeeLastName.Name = "txtUpdateEmployeeLastName";
            this.txtUpdateEmployeeLastName.Size = new System.Drawing.Size(200, 26);
            this.txtUpdateEmployeeLastName.TabIndex = 7;
=======
            this.txtUpdateEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtUpdateEmployeeLastName.Location = new System.Drawing.Point(25, 94);
            this.txtUpdateEmployeeLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateEmployeeLastName.Name = "txtUpdateEmployeeLastName";
            this.txtUpdateEmployeeLastName.Size = new System.Drawing.Size(265, 26);
            this.txtUpdateEmployeeLastName.TabIndex = 5;
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // txtUpdateEmployeeName
            // 
            this.txtUpdateEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtUpdateEmployeeName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtUpdateEmployeeName.Location = new System.Drawing.Point(19, 29);
            this.txtUpdateEmployeeName.Name = "txtUpdateEmployeeName";
            this.txtUpdateEmployeeName.Size = new System.Drawing.Size(200, 26);
            this.txtUpdateEmployeeName.TabIndex = 6;
=======
            this.txtUpdateEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtUpdateEmployeeName.Location = new System.Drawing.Point(25, 36);
            this.txtUpdateEmployeeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateEmployeeName.Name = "txtUpdateEmployeeName";
            this.txtUpdateEmployeeName.Size = new System.Drawing.Size(265, 26);
            this.txtUpdateEmployeeName.TabIndex = 4;
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.AutoSize = true;
<<<<<<< HEAD
            this.txtID.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtID.Location = new System.Drawing.Point(15, 382);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(25, 18);
=======
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(20, 470);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(28, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.txtID.TabIndex = 3;
            this.txtID.Text = "ID";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
<<<<<<< HEAD
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label7.Location = new System.Drawing.Point(16, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 18);
=======
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoSize = true;
<<<<<<< HEAD
            this.txtAddress.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtAddress.Location = new System.Drawing.Point(16, 316);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(81, 18);
=======
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(21, 389);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(90, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
<<<<<<< HEAD
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
=======
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.label6.TabIndex = 4;
            this.label6.Text = "DUI";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
<<<<<<< HEAD
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
=======
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
<<<<<<< HEAD
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
=======
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de telefono";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
=======
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
=======
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEmployees.Location = new System.Drawing.Point(323, 102);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.Size = new System.Drawing.Size(1072, 688);
            this.dgvEmployees.TabIndex = 14;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmbEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbDelete});
            this.cmbEmployee.Name = "cmbEmployee";
<<<<<<< HEAD
            this.cmbEmployee.Size = new System.Drawing.Size(174, 26);
=======
            this.cmbEmployee.Size = new System.Drawing.Size(205, 28);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            // 
            // cmbDelete
            // 
            this.cmbDelete.Name = "cmbDelete";
<<<<<<< HEAD
            this.cmbDelete.Size = new System.Drawing.Size(173, 22);
=======
            this.cmbDelete.Size = new System.Drawing.Size(204, 24);
>>>>>>> 29f0cb2a41fde4e45bb7870c63b36f94577475bb
            this.cmbDelete.Text = "Eliminar Empleado";
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEmployeesView";
            this.Text = "EmployeesView";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.cmbEmployee.ResumeLayout(false);
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
        public System.Windows.Forms.DataGridView dgvEmployees;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpUpdateBirthDay;
        public System.Windows.Forms.TextBox txtIDEmployee;
        public System.Windows.Forms.TextBox txtUAddress;
        public System.Windows.Forms.Label txtID;
        public System.Windows.Forms.Label txtAddress;
        public System.Windows.Forms.ContextMenuStrip cmbEmployee;
        public System.Windows.Forms.ToolStripMenuItem cmbDelete;
    }
}