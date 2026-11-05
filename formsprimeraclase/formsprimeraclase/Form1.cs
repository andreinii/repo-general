using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formsprimeraclase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double primerNumero = 0;
        string operacion = "";
        bool nuevoNumero = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            int resultado = numero1 + numero2;

            lblResultado.Text = resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "-";
            nuevoNumero = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            primerNumero = 0;
            operacion = "";
            nuevoNumero = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {


            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
                txtPantalla.Text = "1";
            else
                txtPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
                txtPantalla.Text = "2";
            else
                txtPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
                txtPantalla.Text = "3";
            else
                txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }


            if (txtPantalla.Text == "0")
                txtPantalla.Text = "4";
            else
                txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }


            if (txtPantalla.Text == "0")
                txtPantalla.Text = "5";
            else
                txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }


            if (txtPantalla.Text == "0")
                txtPantalla.Text = "6";
            else
                txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }


            if (txtPantalla.Text == "0")
                txtPantalla.Text = "7";
            else
                txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }


            if (txtPantalla.Text == "0")
                txtPantalla.Text = "8";
            else
                txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }


            if (txtPantalla.Text == "0")
                txtPantalla.Text = "9";
            else
                txtPantalla.Text += "9";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "+";
            nuevoNumero = true;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            double segundoNumero = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            if (operacion == "+")
            {
                resultado = primerNumero + segundoNumero;
            }

            if (operacion == "-")
            {
                resultado = primerNumero - segundoNumero;
            }

            if (operacion == "x")
            {
                resultado = primerNumero * segundoNumero;
            }

            if (operacion == "d")
            {
                resultado = primerNumero / segundoNumero;
            }

            txtPantalla.Text = resultado.ToString();
            nuevoNumero = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "x";
            nuevoNumero = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "d";
            nuevoNumero = true;
        }
    }
}
