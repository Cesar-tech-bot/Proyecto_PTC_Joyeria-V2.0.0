﻿using SistemaJoyería.Controller.LoginController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJoyería.View.LoginView
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword(string user)
        {
            InitializeComponent();
            ChangePasswordController control = new ChangePasswordController(this, user);

        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
