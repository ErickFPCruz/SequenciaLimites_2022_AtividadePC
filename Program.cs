Console.Clear();

int nrLimiteComeco, nrLimiteFinal;

Console.Write("Escreva o número do começo: ");
nrLimiteComeco = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Escreva o número do final: ");
nrLimiteFinal = Convert.ToInt32(Console.ReadLine()!);

if (nrLimiteComeco > nrLimiteFinal)
{
    Console.WriteLine("\nA sequência foi programada para ser crescente!");
}

else
{

    while (nrLimiteComeco <= nrLimiteFinal)
    {
        Console.Write($"{nrLimiteComeco} ");
        nrLimiteComeco++;
    }
}
Console.WriteLine();