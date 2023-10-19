namespace Alcool_ou_Gasolina
{
    public partial class Form1 : Form
    {
        double valAlcool, valGasolina, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtVal1.Clear();
            txtVal2.Clear();
            lblTotal.Text= string.Empty;
            txtVal1.Focus();
        }
        private void btDivisão_Click(object sender, EventArgs e)
        {
            if (txtVal1.Text == "" || txtVal2.Text == "")
            {
                MessageBox.Show("Preencha os dois campos para fazer o calculo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                valAlcool = Convert.ToDouble(txtVal1.Text); 
                valGasolina = Convert.ToDouble(txtVal2.Text);
                total = valAlcool / valGasolina;
                 if (total < 0.7 ) //Para valores quebrados utilizar double e não decimal
                {
                    lblTotal.Text = "Álcool";
                }
                 else
                {
                    lblTotal.Text = "Gasolina";
                }
            }
        }
    }
}