using byteBank;

ContaCorrente conta1 = new ContaCorrente();
ContaCorrente conta2 = new ContaCorrente();


conta1.titular = "Gabriel";
conta1.conta = "1315";
conta1.saldo = 100;
conta1.numero_agencia = 09;

conta1.dadosConta();

Console.WriteLine("Saque de RS75");
conta1.saque(75.00);

Console.WriteLine("\r\n");

Console.WriteLine("Depósito de RS200");
conta1.deposito(200.00);

Console.WriteLine("\r\n");

conta2.titular = "Marcos";
conta2.conta = "2136";
conta2.saldo = 50;
conta2.numero_agencia = 02;


conta2.dadosConta();


Console.WriteLine("TRASFERÊNCIA DA CONTA 1 PARA CONTA 2\r\n");
conta1.traferir(conta2, 80);

Console.WriteLine("DADOS DA CONTA 2\r\n");
conta2.dadosConta();

