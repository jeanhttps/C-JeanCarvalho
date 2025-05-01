
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma senha:");
        string senha = Console.ReadLine();
        
        if (senha.Length >= 8 && 
            Regex.IsMatch(senha, @"[A-Z]") && 
            Regex.IsMatch(senha, @"[0-9]") && 
            Regex.IsMatch(senha, @"[\!\@\#\$\%\^\&\*\(\)\_\+\-=\[\]\{\};:'"",<>\./?]"))
        {
            Console.WriteLine("Senha forte.");
        }
        else
        {
            Console.WriteLine("Senha fraca.");
        }
    }
}
