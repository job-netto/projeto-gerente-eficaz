﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento
{
    public partial class FormTelaGeral : FormBase
    {
        public FormTelaGeral()
        {
            InitializeComponent();
        }

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroMotorista();
            frm.ShowDialog();
        }


        private void caminhãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroCaminhao();
            frm.ShowDialog();
        }

        private void viajemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormControle();
            frm.ShowDialog();
        }
    }
}
