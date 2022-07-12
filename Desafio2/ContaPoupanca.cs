public class ContaPoupanca : Conta
{
    public ContaPoupanca(string numero, string titular, decimal saldo) : base(numero, titular, saldo)
    {
    }

    public override decimal Rendimento()
    {
        return Saldo * 0.05m;
    }
}