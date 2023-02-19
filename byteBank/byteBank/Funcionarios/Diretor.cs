using byteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(String nome, String cpf, double salario) : base(nome, cpf, salario)
        {
            this.tipo = "Diretor";
            this.senha = "diretorsenha";
        }


        public override double GetBonificacao()
        {
            return this.salario * 0.50;
        }


        public override void AumentarSalario()
        {
            this.salario *= 1.15;
        }


    }


}
