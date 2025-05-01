
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        string tarefa;
        
        while (true)
        {
            Console.WriteLine("Digite uma tarefa para adicionar (ou digite 'sair' para finalizar):");
            tarefa = Console.ReadLine();
            
            if (tarefa.ToLower() == "sair")
            {
                break;
            }
            
            tarefas.Add(tarefa);
        }
        
        Console.WriteLine("
Tarefas:");
        foreach (var t in tarefas)
        {
            Console.WriteLine($"- {t}");
        }
    }
}
