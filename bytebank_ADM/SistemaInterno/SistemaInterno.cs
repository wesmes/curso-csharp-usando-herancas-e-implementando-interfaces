﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {

        public bool Logar(Autenticavel funcionario, string senha)
        {

            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo(a) ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }

        }

    }
}
