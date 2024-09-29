using System;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        private int turn = 0; // 0 para X, 1 para O

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa o status do jogo
            labelStatus.Text = "Turno do Jogador X";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Text == "")
            {
                clickedButton.Text = turn % 2 == 0 ? "X" : "O";
                turn++;
                labelStatus.Text = turn % 2 == 0 ? "Turno do Jogador O" : "Turno do Jogador X";
                CheckForWinner();
            }
        }

        private void CheckForWinner()
        {
            // Verificação de linhas
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") ||
                // Verificação de colunas
                (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
                // Verificação de diagonais
                (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
            {
                string winner = turn % 2 == 0 ? "O" : "X";
                MessageBox.Show($"{winner} ganha!");
                DisableButtons();
            }
            else if (turn == 9)
            {
                MessageBox.Show("Empate!");
            }
        }

        private void DisableButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = true;
                    control.Text = "";
                }
            }
            labelStatus.Text = "Turno do Jogador X";
            turn = 0; // Reinicia a contagem de turnos
        }
    }
}