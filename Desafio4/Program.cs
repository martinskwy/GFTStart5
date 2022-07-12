while (true)
{
    Console.Write("Digite sua idade: ");
    if (!int.TryParse(Console.ReadLine(), out int idade))
    {
        continue;
    }

    if (idade >= 18 && idade <= 67)
    {
        Console.WriteLine("Parebéns! Você pode doar sangue.");
    }
    else
    {
        Console.WriteLine("Infelizmente você ainda não pode doar sangue.");
    }
    break;
}