
using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} Celsius = {fahrenheit} Fahrenheit");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                double fahrenheit = double.Parse(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit} Fahrenheit = {celsius} Celsius");
            }
        }
        while (opcao != 3);
    }
}
