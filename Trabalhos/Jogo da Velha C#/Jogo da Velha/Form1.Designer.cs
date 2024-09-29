namespace Jogo_da_velha
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            labelStatus = new Label();
            buttonReiniciar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 41);
            button1.Name = "button1";
            button1.Size = new Size(53, 47);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 41);
            button2.Name = "button2";
            button2.Size = new Size(53, 47);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(166, 41);
            button3.Name = "button3";
            button3.Size = new Size(53, 47);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(166, 104);
            button4.Name = "button4";
            button4.Size = new Size(53, 47);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(93, 104);
            button5.Name = "button5";
            button5.Size = new Size(53, 47);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(21, 104);
            button6.Name = "button6";
            button6.Size = new Size(53, 47);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(166, 168);
            button7.Name = "button7";
            button7.Size = new Size(53, 47);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(93, 168);
            button8.Name = "button8";
            button8.Size = new Size(53, 47);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(21, 168);
            button9.Name = "button9";
            button9.Size = new Size(53, 47);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Jogo da Velha";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(80, 235);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(79, 15);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Jogo da Velha";
            // 
            // buttonReiniciar
            // 
            buttonReiniciar.Location = new Point(65, 282);
            buttonReiniciar.Name = "buttonReiniciar";
            buttonReiniciar.Size = new Size(110, 24);
            buttonReiniciar.TabIndex = 11;
            buttonReiniciar.Text = "Reiniciar";
            buttonReiniciar.UseVisualStyleBackColor = true;
            buttonReiniciar.Click += ButtonReiniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 324);
            Controls.Add(buttonReiniciar);
            Controls.Add(labelStatus);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Jogo da velha Kauan Lauer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}