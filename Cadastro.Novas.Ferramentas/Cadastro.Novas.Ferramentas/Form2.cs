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

            AtualizarGrid();
        }
        public void AtualizarGrid()
        {
            dgCliente.DataSource = ListarClientes();
            dgCliente.Columns[0].HeaderText = "Cód";
            dgCliente.Columns[1].HeaderText = "Nome";
            dgCliente.Columns[2].HeaderText = "CPF";
            dgCliente.Columns[3].HeaderText = "Rua";
            dgCliente.Columns[4].HeaderText = "N°";
            dgCliente.Columns[5].HeaderText = "Telefone";
            dgCliente.Columns[6].HeaderText = "Cidade";
            dgCliente.Columns[7].HeaderText = "UF";
            dgCliente.Columns[8].HeaderText = "Compl.";
            dgCliente.Columns[9].HeaderText = "CEP";
            dgCliente.Columns[10].HeaderText = "DtNasc";

            dgCliente.Columns[0].Width = 50;
            dgCliente.Columns[1].Width = 120;
            dgCliente.Columns[2].Width= 100;
            dgCliente.Columns[3].Width = 100;
            dgCliente.Columns[4].Width = 50; 
            dgCliente.Columns[5].Width = 100;
            dgCliente.Columns[6].Width = 120; 
            dgCliente.Columns[7].Width = 50;
            dgCliente.Columns[8].Width = 120;
            dgCliente.Columns[9].Width = 100;
            dgCliente.Columns[10].Width = 100;


            dgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgCliente.AllowUserToAddRows = false;
            dgCliente.AllowUserToDeleteRows = false;
            dgCliente.ReadOnly = true;
        }

        public static DataTable ListarClientes()
        {
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                string sqlSelecionarClientes = "Select * From cliente";
                SqlDataAdapter da = new SqlDataAdapter(sqlSelecionarClientes, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
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

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Dados.StringConexao);
                conexao.Open();

                string sqlInserir = "INSERT INTO cliente(nome, cpf, rua, numero, telefone, cidade, uf, complemento, cep, dtnascimento) VALUES (@nome, @cpf, @rua, @numero, @telefone, @cidade, @uf, @complemento, @cep, @dtnascimento)";

                SqlCommand comando = new SqlCommand(sqlInserir, conexao);

                comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mtCPF2.Text;
                comando.Parameters.Add("@rua", SqlDbType.VarChar).Value = txtEndereço.Text;
                comando.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(txtNumero.Text);
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = mtTelefone.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtCidade.Text;
                comando.Parameters.Add("@uf", SqlDbType.VarChar).Value = cbUF.Text;
                comando.Parameters.Add("@complemento", SqlDbType.VarChar).Value = txtCompl.Text;
                comando.Parameters.Add("@cep", SqlDbType.VarChar).Value = mtCEP.Text;
                comando.Parameters.Add("@dtnascimento", SqlDbType.DateTime).Value = Convert.ToDateTime(mtDTNASC.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente inserido com sucesso!", "TI Tech26", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCompl.Clear();
            mtDTNASC.Clear();
            txtEndereço.Clear();
            txtNumero.Clear();
            mtTelefone.Clear();
            mtCPF2.Clear();
            cbUF.SelectedIndex = -1;
            txtNome.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
