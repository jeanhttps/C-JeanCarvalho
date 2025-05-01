
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu peso (kg):");
        double peso = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite sua altura (m):");
        double altura = double.Parse(Console.ReadLine());
        
        double imc = peso / (altura * altura);
        
        Console.WriteLine($"Seu IMC é: {imc}");
        
        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade");
        }
    }
}
