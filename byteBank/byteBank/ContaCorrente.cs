using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    public class ContaCorrente
    {
        public int numero_agencia { get; set; }
        public string conta { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public static int qnt_contas { get; set; }


        public ContaCorrente(string titular, string conta, int numero_agencia, double saldo)
        {
            this.titular = titular;
            this.conta = conta;
            this.numero_agencia = numero_agencia;
            this.saldo = saldo;
            qnt_contas += 1;
        }

        public ContaCorrente()
        {
            qnt_contas += 1;
        }


        public void dadosConta()
        {
            Console.WriteLine("Títular: " + this.titular);
            Console.WriteLine("Conta: " + this.conta);
            Console.WriteLine("Dígito: " + this.numero_agencia);
            Console.WriteLine("Saldo: R$" + this.saldo);
            Console.WriteLine("\r\n");
            Console.WriteLine("Quantidade de contas cadastradas: " + qnt_contas);
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
