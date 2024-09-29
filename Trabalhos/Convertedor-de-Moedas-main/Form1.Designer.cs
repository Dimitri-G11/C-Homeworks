namespace Conversor_de_Moedas_C_
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
            txtValor = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            cmbDestino = new ComboBox();
            btnConverter = new Button();
            lblResultado = new Label();
            btnLimpar = new Button();
            cmbOrigem = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(43, 47);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(52, 23);
            txtValor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 10);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 1;
            label1.Text = "Conversor de Moedas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbDestino);
            panel1.Controls.Add(btnConverter);
            panel1.Controls.Add(lblResultado);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(cmbOrigem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtValor);
            panel1.Location = new Point(12, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 206);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 50);
            label3.Name = "label3";
            label3.Size = new Size(22, 17);
            label3.TabIndex = 8;
            label3.Text = "->";
            // 
            // cmbDestino
            // 
            cmbDestino.ForeColor = SystemColors.ActiveCaptionText;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(226, 47);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(105, 23);
            cmbDestino.TabIndex = 7;
            cmbDestino.Click += Form1_Load;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.LimeGreen;
            btnConverter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.ForeColor = SystemColors.ButtonHighlight;
            btnConverter.Location = new Point(43, 108);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(288, 27);
            btnConverter.TabIndex = 6;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(37, 159);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 21);
            lblResultado.TabIndex = 5;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.LightSeaGreen;
            btnLimpar.Location = new Point(43, 76);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(288, 26);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // cmbOrigem
            // 
            cmbOrigem.FormattingEnabled = true;
            cmbOrigem.Location = new Point(94, 47);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.Size = new Size(105, 23);
            cmbOrigem.TabIndex = 3;
            cmbOrigem.Click += Form1_Load;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 50);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 217);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Conversor de Moeda Dimitri Georges";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtValor;
        private Label label1;
        private Panel panel1;
        private Button btnLimpar;
        private ComboBox cmbOrigem;
        private Label label2;
        private Button btnConverter;
        private Label lblResultado;
        private ComboBox cmbDestino;
        private Label label3;
    }
}
