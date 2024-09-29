namespace Lista_de_Tarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdicionar = new Button();
            txtTarefa = new TextBox();
            listBoxTarefas = new ListBox();
            btnRemover = new Button();
            btnEditar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(230, 25);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += Adicionar_Click;
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(15, 26);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(193, 23);
            txtTarefa.TabIndex = 1;
            // 
            // listBoxTarefas
            // 
            listBoxTarefas.FormattingEnabled = true;
            listBoxTarefas.ItemHeight = 15;
            listBoxTarefas.Location = new Point(15, 55);
            listBoxTarefas.Name = "listBoxTarefas";
            listBoxTarefas.Size = new Size(193, 304);
            listBoxTarefas.TabIndex = 2;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(230, 154);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(230, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(230, 183);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar Lista";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 384);
            Controls.Add(btnLimpar);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(listBoxTarefas);
            Controls.Add(txtTarefa);
            Controls.Add(btnAdicionar);
            Name = "Form1";
            Text = "Lista de Tarefas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private TextBox txtTarefa;
        private ListBox listBoxTarefas;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnLimpar;
    }
}
