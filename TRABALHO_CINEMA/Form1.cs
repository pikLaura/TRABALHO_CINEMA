﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_CINEMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            new FuncionarioForm().Show();
        }

        private void btlinpar_Click(object sender, EventArgs e)
        {

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
