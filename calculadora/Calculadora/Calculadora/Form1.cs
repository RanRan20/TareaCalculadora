namespace Calculadora
{
    public partial class Form1 : Form
    {

        double number1;
        double number2;
        double rest;
        string ope;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ope = "÷";
            number1 = double.Parse(screen.Text);
            screen.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ope = "x";
            number1 = double.Parse(screen.Text);
            screen.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ope = "-";
            number1 = double.Parse(screen.Text);
            screen.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ope = "+";
            number1 = double.Parse(screen.Text);
            screen.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(screen.Text);
            switch (ope)
            {
                case "+":
                    rest = number1 + number2;
                    screen.Text = rest.ToString();
                    break;

                case "-":
                    rest = number1 - number2;
                    screen.Text = rest.ToString();
                    break;

                case "x":
                    rest = number1 * number2;
                    screen.Text = rest.ToString();
                    break;

                case "÷":
                    rest = number1 / number2;
                    screen.Text = rest.ToString();
                    break;

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ope = "√";
            number1 = double.Parse(screen.Text);
            screen.Text = Math.Sqrt(number1).ToString();
        }
    }
}