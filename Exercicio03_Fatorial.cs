
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());
        int fatorial = 1;
        int i = 1;

        while (i <= numero)
        {
            fatorial *= i;
            i++;
        }

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }
}
