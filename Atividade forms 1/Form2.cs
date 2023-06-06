using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade_forms_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Result_IMC.Visible = false;
            Result_Grau.Visible = false;
            Result_Classf.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(numericUpDown2.Text);
            double peso = double.Parse(numericUpDown3.Text);
            (double imc, string classificacao, string grau) = Pessoa.Calcular_IMC(peso, altura);
            Result_IMC.Text = imc.ToString("F2");
            Result_IMC.Visible = true;
            Result_Classf.Text = classificacao;
            Result_Classf.Visible = true;
            Result_Grau.Text = grau;
            Result_Grau.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result_IMC.Visible = false;
            Result_Grau.Visible = false;
            Result_Classf.Visible = false;

            numericUpDown2.Text = "0.00";
            numericUpDown3.Text = "0.00";
        }
    }
}
