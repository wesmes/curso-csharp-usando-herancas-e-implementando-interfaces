using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpg)
        {
            this.Cpf = Cpf;
            TotalDeFuncionarios++;
            // Console.WriteLine("Criando um funcionário");
        }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }


    }
}
