using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    internal class Auxiliar : Funcionario
    {

        public Auxiliar(String nome, String cpf, double salario) : base(nome, cpf, salario)
        {
            this.tipo = "Auxiliar";
        }


        public override double GetBonificacao()
        {
            return this.salario * 0.20;
        }


        public override void AumentarSalario()
        {
            this.salario *= 1.10;
        }
    }
}
