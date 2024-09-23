namespace SistemaJoyería.View.LoginView
{
    partial class FrmInterFromAdmin
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
            this.BtnContraAdmin = new System.Windows.Forms.Button();
            this.txtContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnContraAdmin
            // 
            this.BtnContraAdmin.BackColor = System.Drawing.Color.Blue;
            this.BtnContraAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContraAdmin.Location = new System.Drawing.Point(211, 213);
            this.BtnContraAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnContraAdmin.Name = "BtnContraAdmin";
            this.BtnContraAdmin.Size = new System.Drawing.Size(87, 41);
            this.BtnContraAdmin.TabIndex = 8;
            this.BtnContraAdmin.Text = "Confirmar";
            this.BtnContraAdmin.UseVisualStyleBackColor = false;
            // 
            // txtContraseñaAdmin
            // 
            this.txtContraseñaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaAdmin.Location = new System.Drawing.Point(142, 144);
            this.txtContraseñaAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaAdmin.MaxLength = 50;
            this.txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            this.txtContraseñaAdmin.Size = new System.Drawing.Size(238, 23);
            this.txtContraseñaAdmin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña del Administrador";
            // 
            // FrmInterFromAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnContraAdmin);
            this.Controls.Add(this.txtContraseñaAdmin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInterFromAdmin";
            this.Text = "FrmInterFromAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnContraAdmin;
        public System.Windows.Forms.TextBox txtContraseñaAdmin;
        public System.Windows.Forms.Label label1;
    }
}