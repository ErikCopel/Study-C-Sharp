using System;
using ClassesAbstratas.Funcionarios;
using ClassesAbstratas.Utilitarios;

namespace ClassesAbstratas
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {

            // Funcionario pedro = new Funcionario("123.456.789-10", 5000);
            //
            // pedro.Nome = "Pedro";
            //
            // Diretor maria = new Diretor("987.654.321.98");
            // maria.Nome = "Maria";
            //
            // Console.WriteLine(pedro.Nome);
            // Console.WriteLine(pedro.getBonificacao());
            //
            // Console.WriteLine(maria.Nome);
            // Console.WriteLine(maria.getBonificacao());
            //
            // GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            // gerenciador.Registrar(pedro);
            // gerenciador.Registrar(maria);
            //
            // Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao);
            // Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);
            //
            // pedro.AumentarSalario();
            // maria.AumentarSalario();
            //
            // Console.WriteLine("Novo salario Pedro: " + pedro.Salario);
            // Console.WriteLine("Novo salario Maria: " + maria.Salario);
            CalculaBonificacao();

        }

        static void CalculaBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Designer ulisses = new Designer("123456");
            ulisses.Nome = "Ulisses Souza";

            Diretor paula = new Diretor("987654");
            paula.Nome = "Paula Souza";

            Auxiliar igor = new Auxiliar("654321");
            igor.Nome = "Igor Dias";

            GerenteDeContas camila = new GerenteDeContas("547892");
            camila.Nome = "Camila Oliveira";
            
            gerenciador.Registrar(ulisses);
            gerenciador.Registrar(paula);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de Bonificação: " + gerenciador.TotalBonificacao);

        }
    }
}