
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou frase:");
        string entrada = Console.ReadLine().ToLower();
        string semEspacos = new string(entrada.Where(c => !char.IsWhiteSpace(c)).ToArray());
        string reverso = new string(semEspacos.Reverse().ToArray());

        if (semEspacos == reverso)
        {
            Console.WriteLine("É um palíndromo.");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
}
