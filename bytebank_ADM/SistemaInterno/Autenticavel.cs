﻿using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {

        public string Senha { get; set; }

        public abstract bool Autenticar(string senha);

        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumentaSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
