namespace OrientacaoAObjetos.Funcionarios
{
    public class Diretor:Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double getBonificacao()
        {
            return this.Salario;
        }
    }
}