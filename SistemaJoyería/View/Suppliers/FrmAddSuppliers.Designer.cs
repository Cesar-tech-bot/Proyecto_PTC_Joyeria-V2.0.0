﻿namespace SistemaJoyería.View.Suppliers
{
    partial class FrmAddSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSuppliers));
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.NombreContacto = new System.Windows.Forms.Label();
            this.NombreEmpresa = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(94, 157);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(328, 24);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(98, 255);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(377, 24);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(172, 206);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(377, 24);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreContacto.Location = new System.Drawing.Point(190, 56);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(377, 24);
            this.txtNombreContacto.TabIndex = 2;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(189, 13);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(377, 24);
            this.txtNombreEmpresa.TabIndex = 1;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(11, 257);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(75, 20);
            this.Direccion.TabIndex = 0;
            this.Direccion.Text = "Dirección";
            this.Direccion.Click += new System.EventHandler(this.Direccion_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(11, 208);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(140, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "Correo Electrónico";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(11, 161);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(71, 20);
            this.Telefono.TabIndex = 0;
            this.Telefono.Text = "Teléfono";
            this.Telefono.Click += new System.EventHandler(this.Telefono_Click);
            // 
            // NombreContacto
            // 
            this.NombreContacto.AutoSize = true;
            this.NombreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreContacto.Location = new System.Drawing.Point(11, 61);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(156, 20);
            this.NombreContacto.TabIndex = 0;
            this.NombreContacto.Text = "Nombre de Contacto";
            this.NombreContacto.Click += new System.EventHandler(this.NombreContacto_Click);
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.AutoSize = true;
            this.NombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEmpresa.Location = new System.Drawing.Point(11, 19);
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.Size = new System.Drawing.Size(155, 20);
            this.NombreEmpresa.TabIndex = 0;
            this.NombreEmpresa.Text = "Nombre de Empresa";
            this.NombreEmpresa.Click += new System.EventHandler(this.NombreEmpresa_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(320, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.Location = new System.Drawing.Point(158, 103);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(378, 24);
            this.dtpFechaRegistro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(134, 323);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 36);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmAddSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(581, 383);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.NombreEmpresa);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.NombreContacto);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddSuppliers";
            this.Text = "FrmAddSuplliers";
            this.Load += new System.EventHandler(this.FrmAddSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label NombreContacto;
        private System.Windows.Forms.Label NombreEmpresa;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNombreContacto;
        public System.Windows.Forms.TextBox txtNombreEmpresa;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnLimpiar;
    }
}