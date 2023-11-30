using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cadastro.Novas.Ferramentas;

namespace Cadastro
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToLongDateString();
            cbUf.DataSource = CarregaComboUf();
            cbUf.ValueMember = "codigo";
            cbUf.DisplayMember = "uf";
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
