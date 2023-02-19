using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Funcionarios
{
    //Classe abstrados não podem ser instanciados. Criados objetos diretamente. 
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; private set; }
        public double salario { get; protected set; }

        public string tipo { get; set; }

        public static int TotalDeFuncionarios { get; private set; }


        public Funcionario(string nome, string cpf, double salario) {
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
            this.tipo = "Geral";
            TotalDeFuncionarios++;


        }

        //Toda classe que herdadar dessa, deve implementar obrigatóriamanente essa método. Pois aqui indico que precisa ter essa ideia 
        public abstract double GetBonificacao();



        public virtual void dados()
        {
            Console.WriteLine("\r\n");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("CPF: " + this.cpf);
            Console.WriteLine("Salário: " + this.salario.ToString("F"));
            Console.WriteLine("Tipo: " + this.tipo);
            Console.WriteLine("Bonificação do " + this.nome + " é de R$" + this.GetBonificacao().ToString("F"));
        }

        public static int GetTotalDeFuncionarios()
        {
            return TotalDeFuncionarios;
        }

        public abstract void AumentarSalario();

       


    }
}
