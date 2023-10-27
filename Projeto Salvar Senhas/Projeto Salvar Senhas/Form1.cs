using System.Drawing.Text;

namespace Projeto_Salvar_Senhas
{
    public partial class Form1 : Form
    {
        string site = "", email = "", senha = "";
        string caminho = "C:\\Users\\richard.gmartins\\Desktop\\arquivos\\senhas.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text =="" || txtSite.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                //2. Receber os valores dos textbox nas vars
                site = txtSite.Text; ;
                email= txtUsuario.Text;
                senha= txtSenha.Text;
                //.Salvar as informaçoes num arquivo txt.
                using(StreamWriter writer= new StreamWriter(caminho, true)) 
                {
                    writer.WriteLine($"Site:{site}\nUsuario{email}\nSenha:{senha}");
                    writer.WriteLine("---------------------------------------------\n");
                }

                lblStatus.Text = "Informações foram salvas com sucesso!";

                LimparCampos();
            }
            
        }
        private void LimparCampos()
        {
            txtSenha.Clear();
            txtSite.Clear();
            txtUsuario.Clear();
            txtSite.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listSenhas.Items.Clear();
            string[] linhas = File.ReadAllLines(caminho);
            listSenhas.Items.AddRange(linhas);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}