public abstract class Conta
{
    protected Conta(string numero, string titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public string Numero { get; private set; }
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    public abstract decimal Rendimento();
}