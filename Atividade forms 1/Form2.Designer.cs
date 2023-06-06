namespace Atividade_forms_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.Result_Grau = new System.Windows.Forms.Label();
            this.Result_Classf = new System.Windows.Forms.Label();
            this.Result_IMC = new System.Windows.Forms.Label();
            this.Grau = new System.Windows.Forms.Label();
            this.Classificacao = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 371);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 66);
            this.button3.TabIndex = 28;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Result_Grau
            // 
            this.Result_Grau.AutoSize = true;
            this.Result_Grau.BackColor = System.Drawing.Color.White;
            this.Result_Grau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Grau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_Grau.Location = new System.Drawing.Point(221, 276);
            this.Result_Grau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result_Grau.Name = "Result_Grau";
            this.Result_Grau.Size = new System.Drawing.Size(2, 27);
            this.Result_Grau.TabIndex = 38;
            // 
            // Result_Classf
            // 
            this.Result_Classf.AutoSize = true;
            this.Result_Classf.BackColor = System.Drawing.Color.White;
            this.Result_Classf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Classf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_Classf.Location = new System.Drawing.Point(168, 227);
            this.Result_Classf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result_Classf.Name = "Result_Classf";
            this.Result_Classf.Size = new System.Drawing.Size(2, 27);
            this.Result_Classf.TabIndex = 37;
            // 
            // Result_IMC
            // 
            this.Result_IMC.AutoSize = true;
            this.Result_IMC.BackColor = System.Drawing.Color.White;
            this.Result_IMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_IMC.Location = new System.Drawing.Point(77, 184);
            this.Result_IMC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result_IMC.Name = "Result_IMC";
            this.Result_IMC.Size = new System.Drawing.Size(2, 27);
            this.Result_IMC.TabIndex = 36;
            // 
            // Grau
            // 
            this.Grau.AutoSize = true;
            this.Grau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grau.Location = new System.Drawing.Point(20, 280);
            this.Grau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grau.Name = "Grau";
            this.Grau.Size = new System.Drawing.Size(173, 20);
            this.Grau.TabIndex = 35;
            this.Grau.Text = "Grau de obesidade:";
            // 
            // Classificacao
            // 
            this.Classificacao.AutoSize = true;
            this.Classificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classificacao.Location = new System.Drawing.Point(20, 234);
            this.Classificacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Classificacao.Name = "Classificacao";
            this.Classificacao.Size = new System.Drawing.Size(129, 20);
            this.Classificacao.TabIndex = 34;
            this.Classificacao.Text = "Classificação:";
            // 
            // IMC
            // 
            this.IMC.AutoSize = true;
            this.IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMC.Location = new System.Drawing.Point(20, 188);
            this.IMC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(48, 20);
            this.IMC.TabIndex = 33;
            this.IMC.Text = "IMC:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(192, 134);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown3.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(192, 81);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Digite seu Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Digite sua altura:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 66);
            this.button1.TabIndex = 39;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 371);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 66);
            this.button2.TabIndex = 40;
            this.button2.Text = "Resetar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result_Grau);
            this.Controls.Add(this.Result_Classf);
            this.Controls.Add(this.Result_IMC);
            this.Controls.Add(this.Grau);
            this.Controls.Add(this.Classificacao);
            this.Controls.Add(this.IMC);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Name = "Form2";
            this.Text = "Calcular IMC";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Result_Grau;
        private System.Windows.Forms.Label Result_Classf;
        private System.Windows.Forms.Label Result_IMC;
        private System.Windows.Forms.Label Grau;
        private System.Windows.Forms.Label Classificacao;
        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}