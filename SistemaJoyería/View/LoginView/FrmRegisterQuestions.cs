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
    public partial class FrmRegisterQuestions : Form
    {
        public FrmRegisterQuestions()
        {
            InitializeComponent();
            ControllerRegisterQuestions control = new ControllerRegisterQuestions(this);
        }

        private void FrmRegisterQuestions_Load(object sender, EventArgs e)
        {

        }
    }
}
