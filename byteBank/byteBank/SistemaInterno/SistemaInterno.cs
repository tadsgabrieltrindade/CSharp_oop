using byteBank.Funcionarios;
using byteBank.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.SistemaInterno
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool autenticado = funcionario.Autenticar(senha);
            if (autenticado)
            {
                Console.WriteLine("Boas vindas ao sistema!");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }

            return autenticado;
        }

       


    }
}
