﻿namespace SistemaJoyería.View.EmployeesView
{
    partial class FrmAddEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmployees));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mskEmployeeDUI = new System.Windows.Forms.MaskedTextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.mskEmployeeCellphone = new System.Windows.Forms.MaskedTextBox();
            this.dtpEmployeeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtDuiDoc = new System.Windows.Forms.Label();
            this.txtEmployeesBirthday = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtCellphoneN = new System.Windows.Forms.Label();
            this.txtEmployeesSurname = new System.Windows.Forms.Label();
            this.txtEmployeesName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtAddressEmployee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnOK.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(237, 517);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Location = new System.Drawing.Point(316, 636);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 46);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Guardar";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(85, 517);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Location = new System.Drawing.Point(113, 636);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Limpiar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // mskEmployeeDUI
            // 
            this.mskEmployeeDUI.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.mskEmployeeDUI.Location = new System.Drawing.Point(20, 320);
            this.mskEmployeeDUI.Margin = new System.Windows.Forms.Padding(2);
            this.mskEmployeeDUI.Location = new System.Drawing.Point(27, 394);
            this.mskEmployeeDUI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskEmployeeDUI.Mask = "0000000-0";
            this.mskEmployeeDUI.Name = "mskEmployeeDUI";
            this.mskEmployeeDUI.Size = new System.Drawing.Size(382, 26);
            this.mskEmployeeDUI.TabIndex = 48;
            this.mskEmployeeDUI.Size = new System.Drawing.Size(508, 26);
            this.mskEmployeeDUI.TabIndex = 5;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtEmployeeEmail.Location = new System.Drawing.Point(21, 245);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeEmail.Location = new System.Drawing.Point(28, 302);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(383, 26);
            this.txtEmployeeEmail.TabIndex = 47;
            this.txtEmployeeEmail.Size = new System.Drawing.Size(509, 26);
            this.txtEmployeeEmail.TabIndex = 4;
            // 
            // mskEmployeeCellphone
            // 
            this.mskEmployeeCellphone.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.mskEmployeeCellphone.Location = new System.Drawing.Point(20, 171);
            this.mskEmployeeCellphone.Margin = new System.Windows.Forms.Padding(2);
            this.mskEmployeeCellphone.Location = new System.Drawing.Point(27, 210);
            this.mskEmployeeCellphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskEmployeeCellphone.Mask = "0000-0000";
            this.mskEmployeeCellphone.Name = "mskEmployeeCellphone";
            this.mskEmployeeCellphone.Size = new System.Drawing.Size(383, 26);
            this.mskEmployeeCellphone.TabIndex = 46;
            this.mskEmployeeCellphone.Size = new System.Drawing.Size(509, 26);
            this.mskEmployeeCellphone.TabIndex = 3;
            // 
            // dtpEmployeeBirthDay
            // 
            this.dtpEmployeeBirthDay.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.dtpEmployeeBirthDay.Location = new System.Drawing.Point(20, 382);
            this.dtpEmployeeBirthDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEmployeeBirthDay.Location = new System.Drawing.Point(27, 470);
            this.dtpEmployeeBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEmployeeBirthDay.Name = "dtpEmployeeBirthDay";
            this.dtpEmployeeBirthDay.Size = new System.Drawing.Size(383, 26);
            this.dtpEmployeeBirthDay.TabIndex = 45;
            this.dtpEmployeeBirthDay.Size = new System.Drawing.Size(509, 26);
            this.dtpEmployeeBirthDay.TabIndex = 6;
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtEmployeeLastName.Location = new System.Drawing.Point(20, 93);
            this.txtEmployeeLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeLastName.Location = new System.Drawing.Point(27, 114);
            this.txtEmployeeLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(383, 26);
            this.txtEmployeeLastName.TabIndex = 44;
            this.txtEmployeeLastName.Size = new System.Drawing.Size(509, 26);
            this.txtEmployeeLastName.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            this.txtEmployeeName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtEmployeeName.Location = new System.Drawing.Point(20, 34);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeName.Location = new System.Drawing.Point(27, 42);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(383, 26);
            this.txtEmployeeName.TabIndex = 43;
            this.txtEmployeeName.Size = new System.Drawing.Size(509, 26);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtDuiDoc
            // 
            this.txtDuiDoc.AutoSize = true;
            this.txtDuiDoc.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtDuiDoc.Location = new System.Drawing.Point(17, 288);
            this.txtDuiDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDuiDoc.Name = "txtDuiDoc";
            this.txtDuiDoc.Size = new System.Drawing.Size(37, 18);
            this.txtDuiDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtDuiDoc.Location = new System.Drawing.Point(23, 354);
            this.txtDuiDoc.Name = "txtDuiDoc";
            this.txtDuiDoc.Size = new System.Drawing.Size(41, 20);
            this.txtDuiDoc.TabIndex = 57;
            this.txtDuiDoc.Text = "DUI";
            // 
            // txtEmployeesBirthday
            // 
            this.txtEmployeesBirthday.AutoSize = true;
            this.txtEmployeesBirthday.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtEmployeesBirthday.Location = new System.Drawing.Point(18, 357);
            this.txtEmployeesBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmployeesBirthday.Name = "txtEmployeesBirthday";
            this.txtEmployeesBirthday.Size = new System.Drawing.Size(166, 18);
            this.txtEmployeesBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmployeesBirthday.Location = new System.Drawing.Point(24, 439);
            this.txtEmployeesBirthday.Name = "txtEmployeesBirthday";
            this.txtEmployeesBirthday.Size = new System.Drawing.Size(183, 20);
            this.txtEmployeesBirthday.TabIndex = 56;
            this.txtEmployeesBirthday.Text = "Fecha de nacimiento";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtEmail.Location = new System.Drawing.Point(17, 224);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(49, 18);
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(23, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(56, 20);
            this.txtEmail.TabIndex = 52;
            this.txtEmail.Text = "Email";
            // 
            // txtCellphoneN
            // 
            this.txtCellphoneN.AutoSize = true;
            this.txtCellphoneN.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtCellphoneN.Location = new System.Drawing.Point(17, 138);
            this.txtCellphoneN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCellphoneN.Name = "txtCellphoneN";
            this.txtCellphoneN.Size = new System.Drawing.Size(96, 18);
            this.txtCellphoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtCellphoneN.Location = new System.Drawing.Point(23, 170);
            this.txtCellphoneN.Name = "txtCellphoneN";
            this.txtCellphoneN.Size = new System.Drawing.Size(105, 20);
            this.txtCellphoneN.TabIndex = 53;
            this.txtCellphoneN.Text = "N. Teléfono";
            // 
            // txtEmployeesSurname
            // 
            this.txtEmployeesSurname.AutoSize = true;
            this.txtEmployeesSurname.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtEmployeesSurname.Location = new System.Drawing.Point(17, 72);
            this.txtEmployeesSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmployeesSurname.Name = "txtEmployeesSurname";
            this.txtEmployeesSurname.Size = new System.Drawing.Size(74, 18);
            this.txtEmployeesSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmployeesSurname.Location = new System.Drawing.Point(23, 89);
            this.txtEmployeesSurname.Name = "txtEmployeesSurname";
            this.txtEmployeesSurname.Size = new System.Drawing.Size(76, 20);
            this.txtEmployeesSurname.TabIndex = 54;
            this.txtEmployeesSurname.Text = "Apellido";
            // 
            // txtEmployeesName
            // 
            this.txtEmployeesName.AutoSize = true;
            this.txtEmployeesName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtEmployeesName.Location = new System.Drawing.Point(16, 11);
            this.txtEmployeesName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmployeesName.Name = "txtEmployeesName";
            this.txtEmployeesName.Size = new System.Drawing.Size(68, 18);
            this.txtEmployeesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmployeesName.Location = new System.Drawing.Point(21, 14);
            this.txtEmployeesName.Name = "txtEmployeesName";
            this.txtEmployeesName.Size = new System.Drawing.Size(74, 20);
            this.txtEmployeesName.TabIndex = 55;
            this.txtEmployeesName.Text = "Nombre";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtAddress.Location = new System.Drawing.Point(17, 418);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(81, 18);
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(23, 514);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(90, 20);
            this.txtAddress.TabIndex = 52;
            this.txtAddress.Text = "Dirección";
            // 
            // txtAddressEmployee
            // 
            this.txtAddressEmployee.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtAddressEmployee.Location = new System.Drawing.Point(21, 439);
            this.txtAddressEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressEmployee.Location = new System.Drawing.Point(28, 540);
            this.txtAddressEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressEmployee.Multiline = true;
            this.txtAddressEmployee.Name = "txtAddressEmployee";
            this.txtAddressEmployee.Size = new System.Drawing.Size(509, 67);
            this.txtAddressEmployee.TabIndex = 7;
            // 
            // FrmAddEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 694);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.mskEmployeeDUI);
            this.Controls.Add(this.txtAddressEmployee);
            this.Controls.Add(this.txtEmployeeEmail);
            this.Controls.Add(this.mskEmployeeCellphone);
            this.Controls.Add(this.dtpEmployeeBirthDay);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtDuiDoc);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmployeesBirthday);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCellphoneN);
            this.Controls.Add(this.txtEmployeesSurname);
            this.Controls.Add(this.txtEmployeesName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddEmployees";
            this.Text = "FrmAddEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.MaskedTextBox mskEmployeeDUI;
        public System.Windows.Forms.TextBox txtEmployeeEmail;
        public System.Windows.Forms.MaskedTextBox mskEmployeeCellphone;
        public System.Windows.Forms.DateTimePicker dtpEmployeeBirthDay;
        public System.Windows.Forms.TextBox txtEmployeeLastName;
        public System.Windows.Forms.TextBox txtEmployeeName;
        public System.Windows.Forms.Label txtDuiDoc;
        public System.Windows.Forms.Label txtEmployeesBirthday;
        public System.Windows.Forms.Label txtEmail;
        public System.Windows.Forms.Label txtCellphoneN;
        public System.Windows.Forms.Label txtEmployeesSurname;
        public System.Windows.Forms.Label txtEmployeesName;
        public System.Windows.Forms.Label txtAddress;
        public System.Windows.Forms.TextBox txtAddressEmployee;
    }
}