namespace SistemaJoyería.View.LoginView
{
    partial class FrmRegisterNewUser
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
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnRegisterNewUser = new System.Windows.Forms.Button();
            this.txtConfirmContra = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(218, 298);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(169, 20);
            this.txtCorreo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "rol";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(246, 170);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 19;
            // 
            // btnRegisterNewUser
            // 
            this.btnRegisterNewUser.Location = new System.Drawing.Point(246, 344);
            this.btnRegisterNewUser.Name = "btnRegisterNewUser";
            this.btnRegisterNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterNewUser.TabIndex = 18;
            this.btnRegisterNewUser.Text = "Crear Usuario";
            this.btnRegisterNewUser.UseVisualStyleBackColor = true;
            // 
            // txtConfirmContra
            // 
            this.txtConfirmContra.Location = new System.Drawing.Point(405, 243);
            this.txtConfirmContra.Name = "txtConfirmContra";
            this.txtConfirmContra.Size = new System.Drawing.Size(123, 20);
            this.txtConfirmContra.TabIndex = 17;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(87, 243);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(113, 20);
            this.txtContra.TabIndex = 16;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(257, 90);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirmar Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CRea tu usuario";
            // 
            // FrmRegisterNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnRegisterNewUser);
            this.Controls.Add(this.txtConfirmContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegisterNewUser";
            this.Text = "FrmRegisterNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbRol;
        public System.Windows.Forms.Button btnRegisterNewUser;
        public System.Windows.Forms.TextBox txtConfirmContra;
        public System.Windows.Forms.TextBox txtContra;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}