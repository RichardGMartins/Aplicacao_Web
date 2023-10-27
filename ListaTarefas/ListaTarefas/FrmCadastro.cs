using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using PdfSharp.Pdf;

namespace ListaTarefas
{
   

    public partial class FrmCadastro : Form
    {
        string name = "", cpf, telefone, dataNasc;
        string caminho = ("C:\\Users\\richard.gmartins\\Desktop\\tarefas\\cadastrousuarios.txt");

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || mtCPF.Text == "" || dateNasc.Text == "" || mtPhone.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                name = txtName.Text;
                cpf = mtCPF.Text;
                dataNasc = dateNasc.Text;
                telefone = mtPhone.Text;

                using (StreamWriter writer = new StreamWriter(caminho, true))
                {
                    writer.WriteLine($"(Nome:{name}\nCPF:{cpf}\nDatadeNascimento:{dataNasc}\nTelefone:{telefone})\n");
                    writer.WriteLine("---------------------------------------------------------------------------");
                }
                lblSalvo.Text = "Tarefa Adicionada!";
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btUpload_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Selecione uma imagem";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foto.Image = new System.Drawing.Bitmap(ofd.FileName);
                }
            }
        }
        private Bitmap CapturarTela()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap capturarTela = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(capturarTela))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            }
            return capturarTela;
        }

    }
}
