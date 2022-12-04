using System;
using OrientacaoAObjetos.Funcionarios;
using OrientacaoAObjetos.Utilitarios;

namespace OrientacaoAObjetos
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Funcionario pedro = new Funcionario();

            pedro.Nome = "Pedro";
            pedro.Cpf = "123.456.789-10";
            pedro.Salario = 5000;

            Diretor maria = new Diretor();
            maria.Nome = "Maria";
            maria.Cpf = "987.654.321.98";
            maria.Salario = 7000;

            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.getBonificacao());

            Console.WriteLine(maria.Nome);
            Console.WriteLine(maria.getBonificacao());

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(maria);

            Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao);

        }
    }
}