namespace Calculadora1
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
            txtresultado = new TextBox();
            btnsete = new Button();
            btnnove = new Button();
            btnoito = new Button();
            btncinco = new Button();
            btnseis = new Button();
            btnquatro = new Button();
            btndois = new Button();
            btntres = new Button();
            btnum = new Button();
            btnzero = new Button();
            btnvirgula = new Button();
            btnigual = new Button();
            btnsoma = new Button();
            btnsubtrair = new Button();
            btndividir = new Button();
            btnmultiplicar = new Button();
            btnlimpar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtresultado.Location = new Point(12, 12);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(230, 43);
            txtresultado.TabIndex = 0;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnsete
            // 
            btnsete.Location = new Point(12, 101);
            btnsete.Name = "btnsete";
            btnsete.Size = new Size(53, 48);
            btnsete.TabIndex = 1;
            btnsete.Text = "7";
            btnsete.UseVisualStyleBackColor = true;
            btnsete.Click += btnsete_Click;
            // 
            // btnnove
            // 
            btnnove.Location = new Point(130, 101);
            btnnove.Name = "btnnove";
            btnnove.Size = new Size(53, 48);
            btnnove.TabIndex = 2;
            btnnove.Text = "9";
            btnnove.UseVisualStyleBackColor = true;
            btnnove.Click += btnnove_Click;
            // 
            // btnoito
            // 
            btnoito.Location = new Point(71, 101);
            btnoito.Name = "btnoito";
            btnoito.Size = new Size(53, 48);
            btnoito.TabIndex = 3;
            btnoito.Text = "8";
            btnoito.UseVisualStyleBackColor = true;
            btnoito.Click += btnoito_Click;
            // 
            // btncinco
            // 
            btncinco.Location = new Point(71, 155);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(53, 48);
            btncinco.TabIndex = 6;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = true;
            btncinco.Click += btncinco_Click;
            // 
            // btnseis
            // 
            btnseis.Location = new Point(130, 155);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(53, 48);
            btnseis.TabIndex = 5;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = true;
            btnseis.Click += btnseis_Click;
            // 
            // btnquatro
            // 
            btnquatro.Location = new Point(12, 155);
            btnquatro.Name = "btnquatro";
            btnquatro.Size = new Size(53, 48);
            btnquatro.TabIndex = 4;
            btnquatro.Text = "4";
            btnquatro.UseVisualStyleBackColor = true;
            btnquatro.Click += btnquatro_Click;
            // 
            // btndois
            // 
            btndois.Location = new Point(71, 209);
            btndois.Name = "btndois";
            btndois.Size = new Size(53, 48);
            btndois.TabIndex = 9;
            btndois.Text = "2";
            btndois.UseVisualStyleBackColor = true;
            btndois.Click += btndois_Click;
            // 
            // btntres
            // 
            btntres.Location = new Point(130, 209);
            btntres.Name = "btntres";
            btntres.Size = new Size(53, 48);
            btntres.TabIndex = 8;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = true;
            btntres.Click += btntres_Click;
            // 
            // btnum
            // 
            btnum.Location = new Point(12, 209);
            btnum.Name = "btnum";
            btnum.Size = new Size(53, 48);
            btnum.TabIndex = 7;
            btnum.Text = "1";
            btnum.UseVisualStyleBackColor = true;
            btnum.Click += btnum_Click;
            // 
            // btnzero
            // 
            btnzero.Location = new Point(71, 263);
            btnzero.Name = "btnzero";
            btnzero.Size = new Size(53, 48);
            btnzero.TabIndex = 10;
            btnzero.Text = "0";
            btnzero.UseVisualStyleBackColor = true;
            btnzero.Click += btnzero_Click;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(12, 263);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(53, 48);
            btnvirgula.TabIndex = 11;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            btnvirgula.Click += btnvirgula_Click;
            // 
            // btnigual
            // 
            btnigual.Location = new Point(130, 263);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(53, 48);
            btnigual.TabIndex = 12;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // btnsoma
            // 
            btnsoma.Location = new Point(189, 101);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(53, 25);
            btnsoma.TabIndex = 13;
            btnsoma.Text = "+";
            btnsoma.UseVisualStyleBackColor = true;
            btnsoma.Click += btnsoma_Click;
            // 
            // btnsubtrair
            // 
            btnsubtrair.Location = new Point(189, 132);
            btnsubtrair.Name = "btnsubtrair";
            btnsubtrair.Size = new Size(53, 25);
            btnsubtrair.TabIndex = 14;
            btnsubtrair.Text = "-";
            btnsubtrair.UseVisualStyleBackColor = true;
            btnsubtrair.Click += btnsubtrair_Click;
            // 
            // btndividir
            // 
            btndividir.Location = new Point(189, 194);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(53, 25);
            btndividir.TabIndex = 16;
            btndividir.Text = "/";
            btndividir.UseVisualStyleBackColor = true;
            btndividir.Click += btndividir_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(189, 163);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(53, 25);
            btnmultiplicar.TabIndex = 15;
            btnmultiplicar.Text = "X";
            btnmultiplicar.UseVisualStyleBackColor = true;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(189, 225);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(53, 86);
            btnlimpar.TabIndex = 17;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 364);
            label1.Name = "label1";
            label1.Size = new Size(254, 15);
            label1.TabIndex = 18;
            label1.Text = "Dimitri Georges";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 388);
            Controls.Add(label1);
            Controls.Add(btnlimpar);
            Controls.Add(btndividir);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnsubtrair);
            Controls.Add(btnsoma);
            Controls.Add(btnigual);
            Controls.Add(btnvirgula);
            Controls.Add(btnzero);
            Controls.Add(btndois);
            Controls.Add(btntres);
            Controls.Add(btnum);
            Controls.Add(btncinco);
            Controls.Add(btnseis);
            Controls.Add(btnquatro);
            Controls.Add(btnoito);
            Controls.Add(btnnove);
            Controls.Add(btnsete);
            Controls.Add(txtresultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresultado;
        private Button btnsete;
        private Button btnnove;
        private Button btnoito;
        private Button btncinco;
        private Button btnseis;
        private Button btnquatro;
        private Button btndois;
        private Button btntres;
        private Button btnum;
        private Button btnzero;
        private Button btnvirgula;
        private Button btnigual;
        private Button btnsoma;
        private Button btnsubtrair;
        private Button btndividir;
        private Button btnmultiplicar;
        private Button btnlimpar;
        private Label label1;
    }
}
