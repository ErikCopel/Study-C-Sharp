namespace OrientacaoAObjetos.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double getBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}