using System;
using System.Collections.Generic;

class Program
{
    static List<string> tarefas = new List<string>();
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Sistema de Tarefas ---");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Editar Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma das opções: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    ListarTarefas();
                    break;
                case "3":
                    EditarTarefas();
                    break;
                case "4":
                    RemoverTarefa();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AdicionarTarefa()
    {
        Console.Write("Digite a nova tarefa: ");
        string tarefa = Console.ReadLine();
        tarefas.Add(tarefa);
        Console.WriteLine("Tarefa adicionada com sucesso! Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }

    static void ListarTarefas()
    {
        Console.WriteLine("\n--- Lista de Tarefas ---");
        if(tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {tarefas[i]}");
            }
        }
        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }

    static void EditarTarefas()
    {
        ListarTarefas();
        Console.Write("Digite o número da tarefa que deseja editar: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= tarefas.Count)
        {
            Console.Write("Digite a nova descrição da tarefa: ");
            tarefas[indice - 1] = Console.ReadLine();
            Console.WriteLine("Tarefa editada com sucesso!");
        }
        else
        {
            Console.WriteLine("Pressione qualquer tecla para continuar.");
        }
        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadLine();
    }

    static void RemoverTarefa()
    {
        ListarTarefas();
        Console.Write("Digite o número da tarefa que deseja remover: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= tarefas.Count)
        {
            tarefas.RemoveAt(indice - 1);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Número inválido");
        }
        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }
}