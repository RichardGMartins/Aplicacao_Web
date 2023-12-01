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
        public void AtualizarGrid()
        {
            dgFornecedor.DataSource = ListarFornecedores();
            dgFornecedor.Columns[0].HeaderText = "Cód";
            dgFornecedor.Columns[1].HeaderText = "Nome";
            dgFornecedor.Columns[2].HeaderText = "CNPJ";
            dgFornecedor.Columns[3].HeaderText = "Rua";
            dgFornecedor.Columns[4].HeaderText = "N°";
            dgFornecedor.Columns[5].HeaderText = "Cidade";
            dgFornecedor.Columns[6].HeaderText = "UF";
            dgFornecedor.Columns[7].HeaderText = "Telefone";
            dgFornecedor.Columns[8].HeaderText = "CEP";

            dgFornecedor.Columns[0].Width = 50;
            dgFornecedor.Columns[1].Width = 120;
            dgFornecedor.Columns[2].Width = 100;
            dgFornecedor.Columns[3].Width = 100;
            dgFornecedor.Columns[4].Width = 50;
            dgFornecedor.Columns[5].Width = 100;
            dgFornecedor.Columns[6].Width = 50;
            dgFornecedor.Columns[7].Width = 120;
            dgFornecedor.Columns[8].Width = 120;
            


            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.ReadOnly = true;
        }
        public static DataTable ListarFornecedores()
        {
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                string sqlSelecionarFornecedores = "Select * From fornecedor";
                SqlDataAdapter da = new SqlDataAdapter(sqlSelecionarFornecedores, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
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

        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Dados.StringConexao);
                conexao.Open();

                string sqlInserir = "INSERT INTO fornecedor(nome, cnpj, rua, numero,cidade, uf,telefone, cep) VALUES (@nome, @cnpj, @rua, @numero,@cidade, @uf, @telefone, @cep)";

                SqlCommand comando = new SqlCommand(sqlInserir, conexao);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = mtCNPJ2.Text;
                comando.Parameters.Add("@rua", SqlDbType.VarChar).Value = txtEndereço.Text;
                comando.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(txtNumero.Text);
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mtTelefone.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
                comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = cbUF.Text;
                comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = mtCEP.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Fornecedor inserido com sucesso!", "TI Tech26", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                LimparTudo();
                AtualizarGrid();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void LimparTudo()
        {
            txtNome.Clear();
            mtCEP.Clear();
            txtCidade.Clear();
            txtEndereço.Clear();
            txtNumero.Clear();
            mtTelefone.Clear();
            mtCNPJ2.Clear();
            cbUF.SelectedIndex = -1;
            txtNome.Focus();
        }
    }
}
