namespace ClassesAbstratas.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
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