using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {

        public double TotalDeBonificacoes { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacoes += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.TotalDeBonificacoes += diretor.GetBonificacao();
        }

        internal void Registar(Diretor roberta)
        {
            throw new NotImplementedException();
        }
    }
}
