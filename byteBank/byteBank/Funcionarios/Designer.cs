using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    internal class Designer : Funcionario
    {

        public Designer(String nome, String cpf, double salario) : base(nome, cpf, salario)
        {
            this.tipo = "Designer";
        }


        public override double GetBonificacao()
        {
            return this.salario * 0.17;
        }


        public override void AumentarSalario()
        {
            this.salario *= 1.11;
        }
    }
}
