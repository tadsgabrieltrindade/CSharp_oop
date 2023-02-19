//using byteBank;

//ContaCorrente conta1 = new ContaCorrente();



#region
//conta1.titular = "Gabriel";
//conta1.conta = "1315";
//conta1.saldo = 100;
//conta1.numero_agencia = 09;

//conta1.dadosConta();

//Console.WriteLine("Saque de RS75");
//conta1.saque(75.00);

//Console.WriteLine("\r\n");

//Console.WriteLine("Depósito de RS200");
//conta1.deposito(200.00);

//Console.WriteLine("\r\n");

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Marcos";
//conta2.conta = "2136";
//conta2.saldo = 50;
//conta2.numero_agencia = 02;


//conta2.dadosConta();


//Console.WriteLine("TRASFERÊNCIA DA CONTA 1 PARA CONTA 2\r\n");
//conta1.traferir(conta2, 80);

//Console.WriteLine("DADOS DA CONTA 2\r\n");
//conta2.dadosConta();


//ContaCorrente conta3 = new ContaCorrente("João", "0839", 02, 39.92);
//Console.WriteLine("DADOS DA CONTA 3\r\n");
//conta3.dadosConta();
#endregion


using byteBank.Funcionarios;
using byteBank.Parceria;
using byteBank.SistemaInterno;

#region
//Funcionario funcionario = new Funcionario("Pedro", "07504585698", 4378.90);
//funcionario.dados();
//funcionario.AumentarSalario();
//funcionario.dados();


//Diretor diretor = new Diretor("Lucas", "5684523658", 14260);
//diretor.dados();
//diretor.AumentarSalario();
//diretor.dados();
#endregion


Diretor diretor = new Diretor("Antônio", "04501205369", 5000);
Funcionario designer = new Designer("Rebeca", "0236598475", 3000);
Gerente_de_Contas gerenteContas = new Gerente_de_Contas("Marcela", "12453698723", 4000);
Funcionario auxiliar = new Auxiliar("Tomas", "95463214053", 2000);

Console.WriteLine("Total de funcioários: " + Funcionario.GetTotalDeFuncionarios());

diretor.dados();
designer.dados();
gerenteContas.dados();
auxiliar.dados();


Console.WriteLine("\r\n");
SistemaInterno sistema = new SistemaInterno();
sistema.Logar(diretor, "diretorsenha");
sistema.Logar(gerenteContas, "gerentesenha");


ParceioComercial parceiro = new ParceioComercial();
parceiro.senha = "1981";
sistema.Logar(parceiro, "1981");

