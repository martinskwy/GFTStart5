public class ContaCorrente : Conta
{
    public ContaCorrente(string numero, string titular, decimal saldo) : base(numero, titular, saldo)
    {
    }

    public override decimal Rendimento()
    {
        return Saldo * 0.03m;
    }
}