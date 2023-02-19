using byteBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    public class Gerente_de_Contas : FuncionarioAutenticavel
    {

        public Gerente_de_Contas(String nome, String cpf, double salario) : base(nome, cpf, salario)
        {
            this.tipo = "Gerente de Contas";
            this.senha = "gerentesenha";
        }


        public override double GetBonificacao()
        {
            return this.salario * 0.25;
        }


        public override void AumentarSalario()
        {
            this.salario *= 1.05;
        }

    }
}
