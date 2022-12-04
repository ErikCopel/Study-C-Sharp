namespace ClassesAbstratas.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.12;
        }

        public override double getBonificacao()
        {
            throw new System.NotImplementedException();
        }
    }
}