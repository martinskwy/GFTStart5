ContaCorrente contaCorrente = new ContaCorrente("2749-0", "Gustavo", 10000m);
ContaPoupanca contaPoupanca = new ContaPoupanca("7667-9", "Maria", 10000m);

Console.WriteLine("Conta Corrente:");
Console.WriteLine($"Nome: {contaCorrente.Titular} Numero da Conta: {contaCorrente.Numero} Saldo: {contaCorrente.Saldo:c} Rendimento: {contaCorrente.Rendimento():c}");

Console.WriteLine("Conta Poupança:");
Console.WriteLine($"Nome: {contaPoupanca.Titular} Numero da Conta: {contaPoupanca.Numero} Saldo: {contaPoupanca.Saldo:c} Rendimento: {contaPoupanca.Rendimento():c}");