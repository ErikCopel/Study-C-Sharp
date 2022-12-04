namespace ClassesAbstratas.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 1500)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            throw new System.NotImplementedException();
        }
    }
}