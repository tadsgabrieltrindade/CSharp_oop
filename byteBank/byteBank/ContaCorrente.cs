using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;


        public void dadosConta()
        {
            Console.WriteLine("Títular: " + this.titular);
            Console.WriteLine("Conta: " + this.conta);
            Console.WriteLine("Dígito: " + this.numero_agencia);
            Console.WriteLine("Saldo: R$" + this.saldo);
            Console.WriteLine("\r\n");
        }

        public void deposito(double valor)
        {
            this.saldo = saldo + valor;
            Console.WriteLine("Saldo atual: R$" + this.saldo);
        }

        public void saque(double valor)
        {
            if(valor > this.saldo)
            {
                Console.WriteLine("Valor de saque maior do que valor disponível para saque.");
                Console.WriteLine("Saldo atual: R$" + this.saldo);
            }
            else
            {
                this.saldo = saldo - valor;
                Console.WriteLine("Saldo atual: R$" + this.saldo);
            }

        }

        public void traferir(ContaCorrente destino, double valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Valor de transferência maior do que valor disponível.");
                Console.WriteLine("Saldo atual: R$" + this.saldo);
            }
            else
            {
                this.saldo = saldo - valor;
                destino.deposito(valor);
                Console.WriteLine("Saldo atual: R$" + this.saldo);
            }
        }
    }
}
