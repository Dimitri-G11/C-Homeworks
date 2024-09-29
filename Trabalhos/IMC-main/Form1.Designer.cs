namespace Calculadora_de_IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            txtAltura = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPeso = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            lblResultado = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 190, 0);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 39);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(249, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources._10481308;
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 100, 0);
            label1.Location = new Point(97, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 3;
            label1.Text = "Calcular IMC";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 82);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "Altura (m)";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(49, 105);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(195, 23);
            txtAltura.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 131);
            label5.Name = "label5";
            label5.Size = new Size(77, 13);
            label5.TabIndex = 7;
            label5.Text = "Exemplo: 1,72";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(112, 222);
            label6.Name = "label6";
            label6.Size = new Size(77, 13);
            label6.TabIndex = 10;
            label6.Text = "Exemplo: 73,1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(121, 173);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 9;
            label7.Text = "Peso (kg)";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(49, 196);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(195, 23);
            txtPeso.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 52);
            label2.Name = "label2";
            label2.Size = new Size(266, 13);
            label2.TabIndex = 11;
            label2.Text = "Coloque as informações corretamente nos campos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 428);
            label4.Name = "label4";
            label4.Size = new Size(249, 13);
            label4.TabIndex = 12;
            label4.Text = " Dimitri Georges ";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(18, 257);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(83, 28);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(184, 257);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(83, 28);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(34, 332);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtPeso);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtAltura);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calculadora de IMC";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtAltura;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPeso;
        private Label label2;
        private Label label4;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblResultado;
    }
}
