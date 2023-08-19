namespace Calculadora
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private String operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
            operators = "+";

        }
        private void btnUno_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "1";
            }
            else
            {
                txtResultado.Text += "1";
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "0";
            }
            else
            {
                txtResultado.Text += "0";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "2";
            }
            else
            {
                txtResultado.Text += "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "3";
            }
            else
            {
                txtResultado.Text += "3";
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "4";
            }
            else
            {
                txtResultado.Text += "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "5";
            }
            else
            {
                txtResultado.Text += "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "6";
            }
            else
            {
                txtResultado.Text += "6";
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "7";
            }
            else
            {
                txtResultado.Text += "7";
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "8";
            }
            else
            {
                txtResultado.Text += "8";
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "9";
            }
            else
            {
                txtResultado.Text += "9";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("-"))
            {
                txtResultado.Text = txtResultado.Text.Trim('-');
            }
            else
            {
                txtResultado.Text = "-" + txtResultado.Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    valueSecond = decimal.Parse(txtResultado.Text);
                    Result = valueFirst + valueSecond;
                    txtResultado.Text = Result.ToString();
                    break;
                case "-":
                    valueSecond = decimal.Parse(txtResultado.Text);
                    Result = valueFirst - valueSecond;
                    txtResultado.Text = Result.ToString();
                    break;
            }
        }

        private void btnUno_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "1";
            }
            else
            {
                txtResultado.Text += "1";
            }
        }

        private void btnDos_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "2";
            }
            else
            {
                txtResultado.Text += "2";
            }
        }

        private void btnTres_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "3";
            }
            else
            {
                txtResultado.Text += "3";
            }
        }

        private void btnCuatro_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "4";
            }
            else
            {
                txtResultado.Text += "4";
            }
        }

        private void btnCinco_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "5";
            }
            else
            {
                txtResultado.Text += "5";
            }
        }

        private void btnSeis_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "6";
            }
            else
            {
                txtResultado.Text += "6";
            }
        }

        private void btnSiete_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "7";
            }
            else
            {
                txtResultado.Text += "7";
            }
        }

        private void btnOcho_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "8";
            }
            else
            {
                txtResultado.Text += "8";
            }
        }

        private void btnNueve_Click_1(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "9";
            }
            else
            {
                txtResultado.Text += "9";
            }
        }

        private void btnPunto_Click_1(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }

        }

        private void masmenosbtn_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("-"))
            {
                txtResultado.Text = txtResultado.Text.Trim('-');
            }
            else
            {
                txtResultado.Text = "-" + txtResultado.Text;
            }
        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
            operators = "-";
        }
    }
}