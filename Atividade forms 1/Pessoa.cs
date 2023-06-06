using System;

public class Pessoa
{
    private string nome;
    private string sexo;
    private int idade;
    private string cpf;
    private double altura;
    private double peso;

    public Pessoa(string nome, string sexo, int idade, string cpf)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.idade = idade;
        this.cpf = cpf;
    }

    public string Nome
    {
        get { return this.nome; }
        set { this.nome = value; }
    }

    public string Sexo
    {
        get { return this.sexo; }
        set { this.sexo = value; }
    }

    public int Idade
    {
        get { return this.idade; }
        set { this.idade = value; }
    }

    public string Cpf
    {
        get { return this.cpf; }
        set { this.cpf = value; }
    }

    public double Altura
    {
        get { return this.altura; }
        set { this.altura = value; }
    }
    
    public double Peso
    {
        get { return this.peso; }
        set { this.peso = value; }
    }

    public static (double, string, string) Calcular_IMC(double peso, double altura)
    {
        double imc = peso / Math.Pow(altura, 2);
        string classificacao;
        string grau;
        if(imc < 18.5)
        {
            classificacao = "Magreza";
            grau = "0";
        }
        else if(imc >= 18.5 && imc <= 24.9)
        {
            classificacao = "Normal";
            grau = "0";
        }
        else if(imc >= 25 && imc <= 29.9)
        {
            classificacao = "Sobrepeso";
            grau = "I";
        }
        else if(imc >= 30 && imc <= 39.9)
        {
            classificacao = "Obesidade";
            grau = "II";
        }
        else
        {
            classificacao = "Obesidade grave";
            grau = "III";
        }
        return(imc, classificacao, grau);
    }

    

}