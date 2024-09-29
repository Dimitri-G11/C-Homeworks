namespace Gerador_De_Senha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.chkMaiusculas = new System.Windows.Forms.CheckBox();
            this.chkMinusculas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkEspeciais = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(12, 51);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(136, 20);
            this.txtComprimento.TabIndex = 0;
            // 
            // chkMaiusculas
            // 
            this.chkMaiusculas.AutoSize = true;
            this.chkMaiusculas.Location = new System.Drawing.Point(36, 89);
            this.chkMaiusculas.Name = "chkMaiusculas";
            this.chkMaiusculas.Size = new System.Drawing.Size(79, 17);
            this.chkMaiusculas.TabIndex = 1;
            this.chkMaiusculas.Text = "Maiusculas";
            this.chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkMinusculas
            // 
            this.chkMinusculas.AutoSize = true;
            this.chkMinusculas.Location = new System.Drawing.Point(36, 112);
            this.chkMinusculas.Name = "chkMinusculas";
            this.chkMinusculas.Size = new System.Drawing.Size(79, 17);
            this.chkMinusculas.TabIndex = 2;
            this.chkMinusculas.Text = "Minusculas";
            this.chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Location = new System.Drawing.Point(36, 135);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(68, 17);
            this.chkNumeros.TabIndex = 3;
            this.chkNumeros.Text = "Numeros";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkEspeciais
            // 
            this.chkEspeciais.AutoSize = true;
            this.chkEspeciais.Location = new System.Drawing.Point(36, 158);
            this.chkEspeciais.Name = "chkEspeciais";
            this.chkEspeciais.Size = new System.Drawing.Size(71, 17);
            this.chkEspeciais.TabIndex = 4;
            this.chkEspeciais.Text = "Especiais";
            this.chkEspeciais.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(21, 190);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(86, 28);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(123, 190);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(86, 28);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(174, 57);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(35, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 251);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.chkEspeciais);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkMinusculas);
            this.Controls.Add(this.chkMaiusculas);
            this.Controls.Add(this.txtComprimento);
            this.Name = "Form1";
            this.Text = "Gerador de senha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.CheckBox chkMaiusculas;
        private System.Windows.Forms.CheckBox chkMinusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkEspeciais;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblSenha;
    }
}

