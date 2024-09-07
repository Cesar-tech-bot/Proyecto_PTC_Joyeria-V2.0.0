namespace SistemaJoyería.View.ClientsView
{
    partial class FrmAddClients
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
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtDuiDoc = new System.Windows.Forms.Label();
            this.txtClientsBirthday = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtCellphoneN = new System.Windows.Forms.Label();
            this.txtClientsSurname = new System.Windows.Forms.Label();
            this.txtClientsName = new System.Windows.Forms.Label();
            this.tbClientsName = new System.Windows.Forms.TextBox();
            this.tbClientsSurname = new System.Windows.Forms.TextBox();
            this.dtpClientsBirthday = new System.Windows.Forms.DateTimePicker();
            this.mskCellphoneN = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mskDuiDoc = new System.Windows.Forms.MaskedTextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 

            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(59, 259);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(75, 20);
            this.txtAddress.TabIndex = 42;
            this.txtAddress.Text = "Dirección";
            // 
            // txtDuiDoc
            // 
            this.txtDuiDoc.AutoSize = true;
            this.txtDuiDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuiDoc.Location = new System.Drawing.Point(500, 193);
            this.txtDuiDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDuiDoc.Name = "txtDuiDoc";
            this.txtDuiDoc.Size = new System.Drawing.Size(38, 20);
            this.txtDuiDoc.TabIndex = 40;
            this.txtDuiDoc.Text = "DUI";
            // 

            // txtClientsBirthday
            // 
            this.txtClientsBirthday.AutoSize = true;
            this.txtClientsBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientsBirthday.Location = new System.Drawing.Point(44, 137);
            this.txtClientsBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtClientsBirthday.Name = "txtClientsBirthday";
            this.txtClientsBirthday.Size = new System.Drawing.Size(157, 20);
            this.txtClientsBirthday.TabIndex = 38;
            this.txtClientsBirthday.Text = "Fecha de nacimiento";
            // 

            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(59, 193);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Text = "Correo Electrónico";
            // 
            // txtCellphoneN
            // 
            this.txtCellphoneN.AutoSize = true;
            this.txtCellphoneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellphoneN.Location = new System.Drawing.Point(466, 138);
            this.txtCellphoneN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCellphoneN.Name = "txtCellphoneN";
            this.txtCellphoneN.Size = new System.Drawing.Size(90, 20);
            this.txtCellphoneN.TabIndex = 29;
            this.txtCellphoneN.Text = "N. Teléfono";
            // 
            // txtClientsSurname
            // 
            this.txtClientsSurname.AutoSize = true;
            this.txtClientsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientsSurname.Location = new System.Drawing.Point(46, 87);
            this.txtClientsSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtClientsSurname.Name = "txtClientsSurname";
            this.txtClientsSurname.Size = new System.Drawing.Size(65, 20);
            this.txtClientsSurname.TabIndex = 30;
            this.txtClientsSurname.Text = "Apellido";
            // 
            // txtClientsName
            // 
            this.txtClientsName.AutoSize = true;
            this.txtClientsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientsName.Location = new System.Drawing.Point(46, 36);
            this.txtClientsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtClientsName.Name = "txtClientsName";
            this.txtClientsName.Size = new System.Drawing.Size(65, 20);
            this.txtClientsName.TabIndex = 31;
            this.txtClientsName.Text = "Nombre";
            // 
            // tbClientsName
            // 
            this.tbClientsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientsName.Location = new System.Drawing.Point(161, 41);
            this.tbClientsName.Name = "tbClientsName";
            this.tbClientsName.Size = new System.Drawing.Size(522, 30);
            this.tbClientsName.TabIndex = 43;
            // 
            // tbClientsSurname
            // 
            this.tbClientsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientsSurname.Location = new System.Drawing.Point(161, 107);
            this.tbClientsSurname.Name = "tbClientsSurname";
            this.tbClientsSurname.Size = new System.Drawing.Size(522, 30);
            this.tbClientsSurname.TabIndex = 44;
            // 
            // dtpClientsBirthday
            // 
            this.dtpClientsBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClientsBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClientsBirthday.Location = new System.Drawing.Point(285, 164);
            this.dtpClientsBirthday.Name = "dtpClientsBirthday";
            this.dtpClientsBirthday.Size = new System.Drawing.Size(296, 30);
            this.dtpClientsBirthday.TabIndex = 45;
            // 
            // mskCellphoneN
            // 

            // 
            // FrmAddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.mskDuiDoc);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.mskCellphoneN);
            this.Controls.Add(this.dtpClientsBirthday);
            this.Controls.Add(this.tbClientsSurname);
            this.Controls.Add(this.tbClientsName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDuiDoc);
            this.Controls.Add(this.txtClientsBirthday);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCellphoneN);
            this.Controls.Add(this.txtClientsSurname);
            this.Controls.Add(this.txtClientsName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddClients";
            this.Text = "Añadir clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label txtAddress;
        public System.Windows.Forms.Label txtDuiDoc;
        public System.Windows.Forms.Label txtClientsBirthday;
        public System.Windows.Forms.Label txtEmail;
        public System.Windows.Forms.Label txtCellphoneN;
        public System.Windows.Forms.Label txtClientsSurname;
        public System.Windows.Forms.Label txtClientsName;
        public System.Windows.Forms.TextBox tbClientsName;
        public System.Windows.Forms.TextBox tbClientsSurname;
        public System.Windows.Forms.DateTimePicker dtpClientsBirthday;
        public System.Windows.Forms.MaskedTextBox mskCellphoneN;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.MaskedTextBox mskDuiDoc;
        public System.Windows.Forms.TextBox tbAddress;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnOK;
    }
}