public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0; 
    }

    public void Sacar(double valor)
    {
        ValidarValor(valor);
        VerificarSaldo(valor);
        Saldo = Saldo - valor;
    }

    public void Depositar(double valor)
    {
        VerificarSaldo(valor);
        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        Sacar(valor);
        conta.Depositar(valor);
    }

    private void ValidarValor(double valor)
    {
        if(valor <= 0 || valor > Saldo)
        {
            throw new ArgumentException("Valor invalido");
        }    
    }

    private void VerificarSaldo(double valor)
    {
        if(valor <= 0 )
        {
            throw new ArgumentException("Valor invalido");
        }
    }

}