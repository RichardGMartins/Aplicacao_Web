namespace ListaTarefas
{
    public partial class FrmTarefas : Form
    {
        string dataHoje, dataLimite, hora, tarefa;
        string caminho = ("C:\\Users\\richard.gmartins\\Desktop\\tarefas\\tarefas.txt");
        public FrmTarefas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
           
            if (txtTarefas.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataHoje = lblData.Text;
                dataLimite = dtDataLimite.Text;
                hora = lblHora.Text;
                tarefa = txtTarefas.Text;

                using (StreamWriter writer = new StreamWriter(caminho, true))
                {
                    writer.WriteLine($"({dataHoje}\nTarefa:{tarefa}\nHorario:{hora}\nDataLimite:{dataLimite})\n");
                    writer.WriteLine("---------------------------------------------------------------------------");
                }
                lblSalvo.Text = "Tarefa Adicionada!";
                LimparCampos();
                exibirTarefas();
            }
        }
        private void exibirTarefas()
        {
            listTarefas.Items.Clear();
            string[] linhas = File.ReadAllLines(caminho);
            listTarefas.Items.AddRange(linhas);
        }
        private void btExibir_Click(object sender, EventArgs e)
        {
           exibirTarefas();
        }
        private void LimparCampos()
        {
            txtTarefas.Clear();
            dtDataLimite.Text = DateTime.Now.ToShortDateString();
            txtTarefas.Focus();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString(); //para deixar somente a data sem a hora usar toshortdate
            lblHora.Text = DateTime.Now.ToLongTimeString(); //para hora completa usar tolongetimestring
        }
    }
}