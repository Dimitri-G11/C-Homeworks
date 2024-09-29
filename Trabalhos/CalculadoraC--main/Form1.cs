namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

       private enum Operacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void btnum_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }

        private void btndois_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void btnquatro_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void btnsete_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void btnoito_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void btnnove_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Soma;
            valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
           label1.Text = "+";
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            label1.Text = "-";
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            label1.Text = "X";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            label1.Text = "/";
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains(","))
            txtresultado.Text = txtresultado.Text + ",";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Soma:
                    resultado = valor + Convert.ToDecimal(txtresultado.Text);
                    break;
                         case Operacao.Subtracao:
                    resultado = valor - Convert.ToDecimal(txtresultado.Text);
                    break;
                          case Operacao.Multiplicacao:
                    resultado = valor * Convert.ToDecimal(txtresultado.Text);
                    break;
                          case Operacao.Divisao:
                    resultado = valor / Convert.ToDecimal(txtresultado.Text);
                    break;
            }
            txtresultado.Text = resultado.ToString();
        }
    }
}
