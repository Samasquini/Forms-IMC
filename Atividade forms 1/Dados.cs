using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_forms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Result_IMC.Visible = false;
            Result_Grau.Visible = false;
            Result_Classf.Visible = false;
            Ver_Cpf.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text;
            bool verificar = Validacoes.ValidaCpf(cpf);
            if (verificar)
            {
                string nome = textBox1.Text;
                string sexo = comboBox1.Text;
                int idade = Convert.ToInt32(numericUpDown1.Text);
                double altura = Convert.ToDouble(numericUpDown2.Text);
                double peso = Convert.ToDouble(numericUpDown3.Text);
                Pessoa pessoa = new Pessoa(nome, sexo, idade, cpf, altura, peso);
                (double imc, string classificacao, string grau) = pessoa.Calcular_IMC();
                Result_IMC.Text = imc.ToString("F2");
                Result_IMC.Visible = true;
                Result_Classf.Text = classificacao;
                Result_Classf.Visible = true;
                Result_Grau.Text = grau;
                Result_Grau.Visible = true;
            }
            else
            {
                Ver_Cpf.Visible = true;
                Ver_Cpf.Text = "CPF invalido!";
            }
        }

        private void Result_Grau_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result_IMC.Visible = false;
            Result_Grau.Visible = false;
            Result_Classf.Visible = false;
            Ver_Cpf.Visible = false;

            textBox1.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "Selecione";
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0.00";
            numericUpDown3.Text = "0.00";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
