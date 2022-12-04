using System;

namespace ClassesAbstratas.Funcionarios
{
    public class Diretor:Funcionario
    {

        public Diretor(string cpf) : base(cpf, 5000)
        {
            
            //Console.WriteLine("Criando um diretor");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
        public override double getBonificacao()
        {
            return this.Salario;
        }
    }
}