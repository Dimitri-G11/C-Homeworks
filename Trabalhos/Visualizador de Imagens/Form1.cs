using System;
using System.Windows.Forms;
using System.Drawing; // Necess�rio para manipula��o de imagens

namespace Visualizador_de_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento de Load do Form, pode deixar vazio ou remover se n�o for necess�rio
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Evento de clique do bot�o "Carregar"
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // Cria um di�logo para selecionar o arquivo de imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Selecione uma imagem";

            // Verifica se o usu�rio selecionou um arquivo e se � v�lido
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carrega e exibe a imagem no PictureBox
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        // Evento de clique do bot�o "Limpar"
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Remove a imagem exibida no PictureBox
            pictureBox.Image = null;
        }
    }
}
