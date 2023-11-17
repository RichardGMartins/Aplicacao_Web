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
using PdfSharp.Drawing;
using System.Diagnostics;

namespace ListaTarefas
{
   

    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            using (Bitmap capturaTela = CapturarTela())
            {
                //Salva a imagem da tela em arquvio temporario
                string tempImagePath = "C:\\Users\\richard.gmartins\\source\\repos\\ListaTarefas\\ListaTarefas\\arquivos\\temp.png";
                capturaTela.Save(tempImagePath,ImageFormat.Png);

                //Cria um doct PDF
                PdfDocument pdfdoc = new PdfDocument();
                PdfPage page = pdfdoc.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                //Add a imagem da tela ao doct PDF
                XImage image = XImage.FromFile(tempImagePath);
                gfx.DrawImage(image, 0, 0);

                //Salva em Pdf
                string pdfFilePath = "C:\\Users\\richard.gmartins\\source\\repos\\ListaTarefas\\ListaTarefas\\arquivos\\ScreenShot.pdf";
                pdfdoc.Save(pdfFilePath);

                //Abre o pdc apos a execução
                //Process.Start(pdfFilePath);
                MessageBox.Show("Cadastro Feito.");

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
