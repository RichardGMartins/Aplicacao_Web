namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal val1, val2, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Metodo void para limpar os campos das operações
        private void Limpar()//assinatura do método sem retorno
        {
            txtVal1.Text = null;
            txtVal2.Text = null;
            cbOperacao.Text = null;
            lblResult.Text = null;
            txtVal1.Focus();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVal1.Text == "" || txtVal2.Text == "")
            {
                MessageBox.Show("Preencha os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cbOperacao.Text == "*")
            {
                val1 = Convert.ToDecimal(txtVal1.Text);
                val2 = Convert.ToDecimal(txtVal2.Text);
                total = val1 * val2;
                lblResult.Text = total.ToString();
            }
            else if (cbOperacao.Text == "/")
            {
                val1 = Convert.ToDecimal(txtVal1.Text);
                val2 = Convert.ToDecimal(txtVal2.Text);
                if (val2 == 0)
                {
                    MessageBox.Show("Segundo valor não pode ser igual a 0 !\n" + "Insira um valor válido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVal2.Text = "";
                    txtVal2.Focus();
                }
                else
                {
                    total = val1 / val2;
                    lblResult.Text = total.ToString();
                }
            }
            else if (cbOperacao.Text == "+")
            {
                val1 = Convert.ToDecimal(txtVal1.Text);
                val2 = Convert.ToDecimal(txtVal2.Text);
                total = val1 + val2;
                lblResult.Text = total.ToString();
            }
            else if (cbOperacao.Text == "-")
            {
                val1 = Convert.ToDecimal(txtVal1.Text);
                val2 = Convert.ToDecimal(txtVal2.Text);
                total = val1 - val2;
                lblResult.Text = total.ToString();
            }
            else
            {
                lblResult.Text = "Por favor insira uma operação";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}