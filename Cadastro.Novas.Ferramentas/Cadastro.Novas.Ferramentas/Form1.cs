using System.Drawing.Printing;

namespace Cadastro.Novas.Ferramentas
{
    public partial class Cadastro : Form
    {
        private PrintDocument printDocument;
        private string filePath;
        public Cadastro()

        {
            InitializeComponent();
            //Inicializar os companentes

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            //Configurar o PrintPreviewDialog
            printPreviewDialog1.Document = printDocument;
            //Configuraro o OpenFileDialog
            openFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
            //Configurar o SaveFileDialog
            saveFileDialog1.Filter = "Arquivos de Texto|*.txt|Todos os Arquivos|*.*";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string conteudo = $"Nome: {txtNome.Text}\nIdade: {dtNasc}\nEmail: {txtEmail}";

            Font fonte = new Font("Arial", 12);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            e.Graphics.DrawString(conteudo, fonte, Brushes.Black, x, y);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btVisu_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btSelecionarP_Click(object sender, EventArgs e)
        {
          if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;

                string[] linhas = { txtNome.Text, dtNasc.Text, txtEmail.Text };
                File.WriteAllLines(filePath, linhas);
            }
        }

        private void btAbrirArquivos_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                string[] linhas = File.ReadAllLines(filePath);
                if (linhas.Length >= 3)
                {
                    txtNome.Text = linhas[0];
                    dtNasc.Text = linhas[1];
                    txtEmail.Text = linhas[2];

                }
            }
        }

        private void dtNasc_ValueChanged(object sender, EventArgs e)
        {
            int anoNascimento, idade;
            string ano;

            ano = dtNasc.Value.ToString();
            ano = ano.Substring(6, 4);
            anoNascimento = Convert.ToInt32(ano);
            idade = DateTime.Now.Year - anoNascimento;
            lblIdade.Text = idade.ToString() + "anos";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}