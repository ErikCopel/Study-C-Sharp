namespace Heranca.Funcionarios
{
    public class Diretor:Funcionario
    {
        public override double getBonificacao()
        {
            return this.Salario + base.getBonificacao();
        }
    }
}