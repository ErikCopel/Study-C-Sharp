using ClassesAbstratas.Funcionarios;

namespace ClassesAbstratas.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.getBonificacao();
        }

    }
}