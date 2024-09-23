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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnContraAdmin
            // 
            this.BtnContraAdmin.BackColor = System.Drawing.Color.Blue;
            this.BtnContraAdmin.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.BtnContraAdmin.Location = new System.Drawing.Point(211, 213);
            this.BtnContraAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnContraAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BtnContraAdmin.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.BtnContraAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnContraAdmin.Location = new System.Drawing.Point(147, 320);
            this.BtnContraAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnContraAdmin.Name = "BtnContraAdmin";
            this.BtnContraAdmin.Size = new System.Drawing.Size(159, 64);
            this.BtnContraAdmin.TabIndex = 2;
            this.BtnContraAdmin.Text = "Confirmar";
            this.BtnContraAdmin.UseVisualStyleBackColor = false;
            // 
            // txtContraseñaAdmin
            // 
            this.txtContraseñaAdmin.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtContraseñaAdmin.Location = new System.Drawing.Point(142, 144);
            this.txtContraseñaAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaAdmin.MaxLength = 50;
            this.txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            this.txtContraseñaAdmin.Size = new System.Drawing.Size(238, 26);
            this.txtContraseñaAdmin.TabIndex = 7;
            this.txtContraseñaAdmin.Location = new System.Drawing.Point(72, 270);
            this.txtContraseñaAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseñaAdmin.MaxLength = 50;
            this.txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            this.txtContraseñaAdmin.Size = new System.Drawing.Size(311, 31);
            this.txtContraseñaAdmin.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label1.Location = new System.Drawing.Point(155, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña del Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::SistemaJoyería.Properties.Resources.User1;
            this.pictureBox1.Location = new System.Drawing.Point(72, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInterFromAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(463, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnContraAdmin);
            this.Controls.Add(this.txtContraseñaAdmin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInterFromAdmin";
            this.Text = "FrmInterFromAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnContraAdmin;
        public System.Windows.Forms.TextBox txtContraseñaAdmin;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}