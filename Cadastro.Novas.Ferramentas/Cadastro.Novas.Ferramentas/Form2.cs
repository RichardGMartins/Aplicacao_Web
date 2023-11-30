﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cadastro.Novas.Ferramentas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToLongDateString();
            cbUF.DataSource = CarregaComboUf();
            cbUF.ValueMember = "codigo";
            cbUF.DisplayMember = "uf";
        }

        private DataTable CarregaComboUf()
        {
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                string sql = "Select codigo, uf from uf";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnteste_Click(object sender, EventArgs e)
        {
            //Testar conexão com o bd
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);

                con.Open();

                con.Close();

                MessageBox.Show("Conexão ok!");
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
