int quantidadePessoasAteDezAnos = 0, quantidadePessoasAteVinteAnos = 0, quantidadePessoasAteTrintaAnos = 0, quantidadePessoasDemaisIdades = 0;
double pesoPessoasAteDezAnos = 0, pesoPessoasAteVinteAnos = 0, pesoPessoasAteTrintaAnos = 0, pesoDemaisPessoas = 0;
for (int i = 1; i <= 10;)
{
    Console.Write($"Digite a idade da {i}ª pessoa: ");
    if (!int.TryParse(Console.ReadLine(), out int idade))
    {
        continue;
    }
    Console.Write($"Digite o peso da {i}ª pessoa: ");
    if (!double.TryParse(Console.ReadLine(), out double peso))
    {
        continue;
    }

    if (idade > 0 && idade <= 10)
    {
        quantidadePessoasAteDezAnos++;
        pesoPessoasAteDezAnos += peso;
    }
    else if (idade > 10 && idade <= 20)
    {
        quantidadePessoasAteVinteAnos++;
        pesoPessoasAteVinteAnos += peso;
    }
    else if (idade > 20 && idade <= 30)
    {
        quantidadePessoasAteTrintaAnos++;
        pesoPessoasAteTrintaAnos += peso;
    }
    else
    {
        quantidadePessoasDemaisIdades++;
        pesoDemaisPessoas += peso;
    }
    i++;
}
double mediaDePesoPessoasAteDezAnos = pesoPessoasAteDezAnos / (double)quantidadePessoasAteDezAnos;
double mediaDePesoPessoasAteVinteAnos = pesoPessoasAteVinteAnos / (double)quantidadePessoasAteVinteAnos;
double mediaDePesoPessoasAteTrintaAnos = pesoPessoasAteTrintaAnos / (double)quantidadePessoasAteTrintaAnos;
double mediaDePesoPessoaDemaisIdades = pesoDemaisPessoas / (double)quantidadePessoasDemaisIdades;

Console.WriteLine($"Pessoas até 10 anos: {quantidadePessoasAteDezAnos} Média de peso: {mediaDePesoPessoasAteDezAnos:f2} kg.");
Console.WriteLine($"Pessoas até 20 anos: {quantidadePessoasAteVinteAnos} Média de peso: {mediaDePesoPessoasAteVinteAnos:f2} kg.");
Console.WriteLine($"Pessoas até 30 anos: {quantidadePessoasAteTrintaAnos} Média de peso: {mediaDePesoPessoasAteTrintaAnos:f2} kg.");
Console.WriteLine($"Pessoas das demais idades: {quantidadePessoasDemaisIdades} Média de peso: {mediaDePesoPessoaDemaisIdades:f2} kg.");