using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:Funcionario
    {

        public string Senha { get; set; }

        public GerenteDeContas(string cpf):base(cpf, 4000.0)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentaSalario()
        {
            this.Salario *= 1.05;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
