
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int numeroAleatorio = rand.Next(1, 101);
        int tentativa = 0;
        int chute;
        
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");
        
        while (true)
        {
            Console.Write("Digite seu palpite: ");
            chute = int.Parse(Console.ReadLine());
            tentativa++;
            
            if (chute < numeroAleatorio)
            {
                Console.WriteLine("O número é maior.");
            }
            else if (chute > numeroAleatorio)
            {
                Console.WriteLine("O número é menor.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativa} tentativas.");
                break;
            }
        }
    }
}
