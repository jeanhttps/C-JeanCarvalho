
using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];
        
        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();

            Console.WriteLine($"Cadastro do produto {i + 1}:");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        double valorTotal = 0;
        Console.WriteLine("
Produtos cadastrados:");
        foreach (var produto in produtos)
        {
            valorTotal += produto.Preco * produto.Quantidade;
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}");
        }

        Console.WriteLine($"
Valor total em estoque: {valorTotal}");
    }
}
