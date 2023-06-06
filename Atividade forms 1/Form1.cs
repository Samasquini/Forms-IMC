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
        private static bool sttsCpf = false;
        public Form1()
        {
            InitializeComponent();
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
            sttsCpf = Validacoes.ValidaCpf(cpf);
            if (sttsCpf)
            {
                string nome = textBox1.Text;
                string sexo = comboBox1.Text;
                int idade = Convert.ToInt32(numericUpDown1.Text);
                Pessoa pessoa = new Pessoa(nome, sexo, idade, cpf);
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
            Ver_Cpf.Visible = false;

            textBox1.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "Selecione";
            numericUpDown1.Text = "0";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sttsCpf)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }            
        }
    }
}
