using System.Globalization;

namespace Calculadora
{
    public partial class FrmCalculator : Form
    {
        decimal numberOne, numberTwo;
        string Operation;
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            lblTextResult.Text = "Nossa Calculadora";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResult.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                numberOne = Convert.ToDecimal(textResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um Numero");
                textResult.Focus();
            }
            Operation = "Division";
            lblTextResult.Text = textResult.Text + "/";

            textResult.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                numberOne = Convert.ToDecimal(textResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um Numero");
                textResult.Focus();
            }
            Operation = "Multiplication";
            lblTextResult.Text = textResult.Text + "*";

            textResult.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResult.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textResult.Text += "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textResult.Text += "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResult.Text += "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResult.Text += "6";
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            textResult.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResult.Text += "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResult.Text += "3";
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                numberOne = Convert.ToDecimal(textResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um Numero");
                textResult.Focus();
            }
            Operation = "Less";
            lblTextResult.Text = textResult.Text + "-";

            textResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                numberTwo = Convert.ToDecimal(textResult.Text, CultureInfo.InvariantCulture);
                lblTextResult.Text += numberTwo + "=";
                decimal result = 0;
                switch(Operation)
                {
                    case "sun":
                        result = numberOne + numberTwo;
                        break;
                    case "Less":
                        result = numberOne - numberTwo;
                        break;
                    case "Division":
                        if(numberOne == 0)
                        {
                            textResult.Text = "Não é possivel Dividir por zero";
                            return;
                        }
                        result = numberOne / numberTwo;
                        break;
                    case "Multiplication":
                        result = numberTwo * numberOne;
                        break;
                    case "intDivision":
                        result = numberOne % numberTwo;
                        break;
                }
                textResult.Text = result.ToString();
                lblTextResult.Text += result.ToString();
            }
        }

        private void intDivision_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                numberOne = Convert.ToDecimal(textResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um Numero");
                textResult.Focus();
            }
            Operation = "intDivision";
            lblTextResult.Text = textResult.Text + "%";

            textResult.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(textResult.Text != "")
            {
                numberOne = Convert.ToDecimal(textResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um Numero");
                textResult.Focus();
            }
            Operation = "sun";
            lblTextResult.Text = textResult.Text + "+";

            textResult.Clear();
        }
    }
}