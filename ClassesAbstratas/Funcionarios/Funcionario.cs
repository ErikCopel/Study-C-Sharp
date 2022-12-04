using System;

namespace ClassesAbstratas.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; set; }

        public abstract void AumentarSalario();
        public abstract double getBonificacao();

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um funcinario");
        }



    }
}