using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_De_Senha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int comprimento;
            // Verifica se o comprimento da senha é um número válido
            if (!int.TryParse(txtComprimento.Text, out comprimento) || comprimento <= 0)
            {
                MessageBox.Show("Por favor, insira um número positivo para o comprimento da senha.");
                return;
            }

            // Gera a senha e exibe no label
            string senha = GerarSenha(comprimento);
            lblSenha.Text = senha;
        }

        private string GerarSenha(int comprimento)
        {
            StringBuilder senha = new StringBuilder();
            Random random = new Random();

            // Variável para armazenar os caracteres permitidos
            string caracteres = "";

            // Adiciona caracteres com base nas opções selecionadas
            if (chkMaiusculas.Checked) caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (chkMinusculas.Checked) caracteres += "abcdefghijklmnopqrstuvwxyz";
            if (chkNumeros.Checked) caracteres += "0123456789";
            if (chkEspeciais.Checked) caracteres += "!@#$%^&*()_+[]{}|;:,.<>?";

            // Verifica se pelo menos um tipo de caractere foi selecionado
            if (string.IsNullOrEmpty(caracteres))
            {
                MessageBox.Show("Por favor, selecione pelo menos um tipo de caractere.");
                return string.Empty;
            }

            // Gera a senha aleatória
            for (int i = 0; i < comprimento; i++)
            {
                int index = random.Next(caracteres.Length);
                senha.Append(caracteres[index]);
            }

            return senha.ToString();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            // Copia a senha gerada para a área de transferência
            Clipboard.SetText(lblSenha.Text);
            MessageBox.Show("Senha copiada para a área de transferência!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialização se necessário (pode ser deixado vazio)
        }
    }
}