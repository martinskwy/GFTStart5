public abstract class Automovel
{
    protected Automovel(string combustivel)
    {
        Combustivel = combustivel;
    }

    public string Combustivel { get; set; }
}