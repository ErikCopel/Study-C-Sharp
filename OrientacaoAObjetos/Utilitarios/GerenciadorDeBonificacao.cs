using OrientacaoAObjetos.Funcionarios;

namespace OrientacaoAObjetos.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.getBonificacao();
        }
        public void Registrar(Diretor diretor)
        {
            this.TotalBonificacao += diretor.getBonificacao();
        }

    }
}