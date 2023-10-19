namespace ProjetoCalculaFrete
{
    public partial class Form1 : Form
    {
        decimal valUF, valTransp, valProf, valTotal, valTotalVista;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransporte.Text == "P")
            {
                valTransp = 3000;
                pictureBox1.Image = Image.FromFile("C:\\Users\\richard.gmartins\\source\\repos\\ProjetoCalculaFrete\\ProjetoCalculaFrete\\img\\tamanho p.jpg");
            }
            if (cbTransporte.Text == "M")
            {
                valTransp = 4500;
                pictureBox1.Image = Image.FromFile("C:\\Users\\richard.gmartins\\source\\repos\\ProjetoCalculaFrete\\ProjetoCalculaFrete\\img\\tamanho m.jpg");
            }
            if (cbTransporte.Text == "G")
            {
                valTransp = 6500;
                pictureBox1.Image = Image.FromFile("C:\\Users\\richard.gmartins\\source\\repos\\ProjetoCalculaFrete\\ProjetoCalculaFrete\\img\\tamanho g.jpg");
            }
            lblValTransp.Text = valTransp.ToString("C");
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUF.Text == "SP" || cbUF.Text == "MG" || cbUF.Text == "SC")
            {
                valUF = 500;
            }
            else if (cbUF.Text == "RJ" || cbUF.Text == "PR")
            {
                valUF = 830;
            }
            else if (cbUF.Text == "AM")
            {
                valUF = 7450;
            }
            else
            {
                valUF = 2340;
            }
            lblValUF.Text = valUF.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valTotal = valProf + valTransp + valUF;

            if (valTotal > 15000)
            {
                valTotalVista = valTotal - (valTotal / 100 * 15);
                lblDesc.Text = (valTotal / 100 * 15).ToString("C");
            }
            lblValTotal.Text = valTotal.ToString("C");
        }

        private void rbAvista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAvista.Checked)
            {
                
                txtAvista.Text = valTotalVista.ToString("C");
            }
            else
            {
                txtAvista.Text = null;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        //Declarar o metodo abaixo para reutilizarmos em cada final de parcela. Assim, evitamos a redundancia de cod.
        private void limparValor()
        {
            string val = lblDesc.Text;
            val = val.Replace('R', ' ');
            val = val.Replace('$', ' ');
            valTotal = Convert.ToDecimal(val);
        }

        private void cbCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCredito.Text == "1")
            {
                txtCredito.Text = valTotal.ToString("C");
            }
            if (cbCredito.Text == "2")
            {
                valTotal = valTotal / 2;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "3")
            {
                valTotal = valTotal / 3;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "4")
            {
                valTotal = valTotal / 4;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "5")
            {
                valTotal = valTotal / 5;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "6")
            {
                valTotal = valTotal / 6;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "7")
            {
                valTotal = valTotal / 7;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "8")
            {
                valTotal = valTotal / 8;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "9")
            {
                valTotal = valTotal / 9;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "10")
            {
                valTotal = valTotal / 10;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "11")
            {
                valTotal = valTotal / 11;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
            if (cbCredito.Text == "12")
            {
                valTotal = valTotal / 12;
                txtCredito.Text = valTotal.ToString("C");
                limparValor();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblData.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPROFISSIONAIS.Text == "1")
            {
                valProf = 2500;
            }
            if (cbPROFISSIONAIS.Text == "3")
            {
                valProf = 4500;
            }
            if (cbPROFISSIONAIS.Text == "5")
            {
                valProf = 6800;
            }
            lblValProf.Text = valProf.ToString("C");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}