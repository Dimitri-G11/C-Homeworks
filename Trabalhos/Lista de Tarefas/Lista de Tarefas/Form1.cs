namespace Lista_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo da tarefa não está vazio
            if (!string.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                // Adiciona o texto do TextBox à ListBox
                listBoxTarefas.Items.Add(txtTarefa.Text);
                // Limpa o TextBox após adicionar a tarefa
                txtTarefa.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira uma tarefa.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtTarefa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            // Verifica se um item foi selecionado na ListBox
            if (listBoxTarefas.SelectedIndex != -1)
            {
                // Verifica se o campo da tarefa não está vazio
                if (!string.IsNullOrWhiteSpace(txtTarefa.Text))
                {
                    // Atualiza o item selecionado com o novo texto
                    listBoxTarefas.Items[listBoxTarefas.SelectedIndex] = txtTarefa.Text;
                    // Limpa o TextBox após a edição
                    txtTarefa.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, insira uma tarefa.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma tarefa para editar.");
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {

            // Remove todos os itens da ListBox
            listBoxTarefas.Items.Clear();
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            // Verifica se um item foi selecionado na ListBox
            if (listBoxTarefas.SelectedIndex != -1)
            {
                // Remove o item selecionado
                listBoxTarefas.Items.RemoveAt(listBoxTarefas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma tarefa para remover.");
            }
        }
    }
}
