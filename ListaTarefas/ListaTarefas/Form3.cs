﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTarefas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTarefas tarefas= new FrmTarefas();
            tarefas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastro cad = new FrmCadastro();
            cad.ShowDialog();
        }
    }
}
