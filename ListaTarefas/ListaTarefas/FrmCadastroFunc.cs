namespace ListaTarefas
{
    public partial class Form1 : Form
    {
        string name = "", cpf, telefone, dataNasc, salario, cargo,hora,data;
        string caminho = ("C:\\Users\\richard.gmartins\\source\\repos\\ListaTarefas\\ListaTarefas\\arquivos\\cadastrofuncionarios.txt");
        string caminho2 = ("C:\\Users\\richard.gmartins\\source\\repos\\ListaTarefas\\ListaTarefas\\arquivos\\registrodeponto.txt");
        private System.Windows.Forms.Timer timer;
        DateTime startime;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            startime= DateTime.Now;
            gbSaida.Enabled = false;  
        }

        private void lblData_Click(object sender, EventArgs e)
        {
            data = lblData.Text;
        }

        private void lblHoraAtual_Click(object sender, EventArgs e)
        {
            hora = lblHoraAtual.Text;
        }

        private void gbSaida_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btCadastra_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtCPF.Text == "" || dtNasc.Text == "" || mtPhone.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                name = txtNome.Text;
                cpf = mtCPF.Text;
                dataNasc = dtNasc.Text;
                telefone = mtPhone.Text;
                salario = mtSalario.Text;
                cargo = cbCargo.Text;
                using (StreamWriter writer = new StreamWriter(caminho, true))
                {
                    writer.WriteLine($"Nome:{name}\nCPF:{cpf}\nData de Nascimento:{dataNasc}\nTelefone:{telefone}\nSalário:{salario}\nCargo:{cargo}\n");
                    writer.WriteLine("---------------------------------------------------------------------------\n");
                }
                MessageBox.Show("Funcionario Cadastrado com Sucesso!","Atenção", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
        private void btRegistra_Click(object sender, EventArgs e)
        {
            lblEntrada.Text = lblHoraAtual.Text;
        }
        private void btSaida_Click(object sender, EventArgs e)
        {
            lblSaida.Text = lblHoraAtual.Text;
            using (StreamWriter writer = new StreamWriter(caminho2, true))
            {
                writer.WriteLine($"Data : {lblData.Text}\nHora Entrada: {lblEntrada.Text}\nHora Saida: {lblSaida.Text}\nBom descanso,Até amanha!");
                writer.WriteLine("----------------------------------------------------------------------\n");
                lblStatus.Text = "Registro de " + lblData.Text + "- Saida:" + lblSaida.Text + "Ok.";
                gbSaida.Enabled = false;
            }
        }
        private void lblEntrada_Click(object sender, EventArgs e)
        {
            hora = lblHoraAtual.Text;
        }

        private void lblSaida_Click(object sender, EventArgs e)
        {
            hora = lblHoraAtual.Text;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();

            TimeSpan ts = DateTime.Now - startime;
            if (ts.TotalSeconds >= 20)
            {
                timer.Stop();
                gbSaida.Enabled = true;
            }
        }
        private void LimparTela()
        {
            txtNome.Clear();
            mtCPF.Clear();
            dtNasc.Text = DateTime.Now.ToShortDateString();
            mtPhone.Clear();
            mtSalario.Clear();
            cbCargo.SelectedIndex = -1;
        }
    }
}
