Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(1000.00);
c1.Sacar(200.00);
Console.WriteLine("Saldo inicial é de: " + c1.Saldo);

c2.Depositar(200.00);
c2.Sacar(150.00);
Console.WriteLine("Saldo inicial é de: " + c2.Saldo);

c1.Transferir (375.00, c2);


Console.WriteLine("\n O Saldo da conta 1 é de:" + c1.Saldo);
Console.WriteLine("\n O Saldo da conta 2 é de:" + c2.Saldo);