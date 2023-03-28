﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: Funcionario
    {

        public Diretor()
        {
            Console.WriteLine("Criando um diretor.");
        }

        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

    }
}
