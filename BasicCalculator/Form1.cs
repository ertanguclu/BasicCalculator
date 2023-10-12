namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        double x, y;
        string calculate;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNumber4_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "4";
            }
            else
            {
                tbxVision.Text += "4";
            }
        }

        private void BtnNumber6_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "6";
            }
            else
            {
                tbxVision.Text += "6";
            }
        }

        private void BtnNumber1_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "1";
            }
            else
            {
                tbxVision.Text += "1";
            }

        }

        private void BtnNumber2_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "2";
            }
            else
            {
                tbxVision.Text += "2";
            }
        }

        private void BtnNumber3_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "3";
            }
            else
            {
                tbxVision.Text += "3";
            }
        }

        private void BtnNumber5_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "5";
            }
            else
            {
                tbxVision.Text += "5";
            }
        }

        private void BtnNumber7_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "7";
            }
            else
            {
                tbxVision.Text += "7";
            }
        }

        private void BtnNumber8_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "8";
            }
            else
            {
                tbxVision.Text += "8";
            }
        }

        private void BtnNumber9_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "9";
            }
            else
            {
                tbxVision.Text += "9";
            }
        }

        private void BtnNumber0_Click(object sender, EventArgs e)
        {
            if (tbxVision.Text == "0")
            {
                tbxVision.Text = "0";
            }
            else
            {
                tbxVision.Text += "0";
            }
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbxVision.Text) > 0)
            {
                tbxVision.Text = tbxVision.Text.Remove(tbxVision.Text.Length - 1, 1);
                if (tbxVision.Text.Length == 0)
                {
                    tbxVision.Text = "0";
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            tbxVision.Text = "0";
            label1.Text = " ";

        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(tbxVision.Text);
            calculate = "+";
            label1.Text = tbxVision.Text + "+";
            tbxVision.Text = "0";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(tbxVision.Text);
            if (calculate == "+")
            {
                tbxVision.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (calculate == "-")
            {
                tbxVision.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (calculate == "*")
            {
                tbxVision.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (calculate == "/")
            {
                tbxVision.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (calculate == "mod")
            {
                tbxVision.Text = Convert.ToString(x % y);
                label1.Text = "";
            }

        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(tbxVision.Text);
            calculate = "-";
            label1.Text = tbxVision.Text + "-";
            tbxVision.Text = "0";
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(tbxVision.Text);
            calculate = "*";
            label1.Text = tbxVision.Text + "*";
            tbxVision.Text = "0";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(tbxVision.Text);
            calculate = "/";
            label1.Text = tbxVision.Text + "/";
            tbxVision.Text = "0";
        }

        private void BtnSquaring_Click(object sender, EventArgs e)
        {
            double square = Convert.ToDouble(tbxVision.Text);
            square = Math.Pow(square, 2);
            tbxVision.Text = Convert.ToString(square);
        }

        private void BtnSquareRoot_Click(object sender, EventArgs e)
        {
            double squareRoot = Convert.ToDouble(tbxVision.Text);
            squareRoot = Math.Sqrt(squareRoot);
            tbxVision.Text = Convert.ToString(squareRoot);
        }

        private void BtnInversion_Click(object sender, EventArgs e)
        {
            double inversion = Convert.ToDouble(tbxVision.Text);
            inversion = 1 / (inversion);
            tbxVision.Text = Convert.ToString(inversion);
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(tbxVision.Text);
            calculate = "mod";
            label1.Text = tbxVision.Text + "(mod)";
            tbxVision.Text = "0";
        }
    }
}
