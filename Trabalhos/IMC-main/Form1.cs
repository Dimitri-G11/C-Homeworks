namespace Calculadora_de_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar se os valores de peso e altura são válidos
            if (decimal.TryParse(txtPeso.Text, out decimal peso) && decimal.TryParse(txtAltura.Text, out decimal altura))
            {
                if (peso > 0 && altura > 0)
                {
                    // Calcular o IMC
                    decimal imc = peso / (altura * altura);

                    // Determinar a classificação do IMC
                    string classificacao;

                    if (imc < 18.5m)
                        classificacao = "Abaixo do peso";
                    else if (imc >= 18.5m && imc < 24.9m)
                        classificacao = "Peso normal";
                    else if (imc >= 25.0m && imc < 29.9m)
                        classificacao = "Sobrepeso";
                    else
                        classificacao = "Obesidade";

                    // Exibir o resultado e a classificação
                    lblResultado.Text = $"IMC: {imc:F2}\nClassificação: {classificacao}";
                }
                else
                {
                    MessageBox.Show("Peso e altura devem ser maiores que zero.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para peso e altura.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            lblResultado.Text = string.Empty;
        }

    }
}
