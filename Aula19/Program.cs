namespace Aula19;
using System.IO;

public class Program
{
    public static void Main()
    {
        string path = @"D:\Aulas\Aula19\";
        string fileName = "shopping_list.txt";
        string filePath = path + fileName;

        List<string> shoopingList = new List<string>();

        if (fileName.Exists(filePath))
        {
            shoopingList.AddRange(fileName.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("/n=== Lista de Compras ====");
            Console.WriteLine("1. Adicionar Item");
            Console.WriteLine("2. Remover Item");
            Console.WriteLine("3. Exibir Lista");
            Console.WriteLine("4. Sair");
            Console.WriteLine("Escolha um número para continuar");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o nome do item para adicionar:");
                    string itemInsert = Console.ReadLine();

                    if (string.IsNullOrEmpety(itemInsert))
                    {
                        shoopingList.Add(itemInsert);
                        console.WriteLine($"Item '{itemInsert}' adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio!");
                    }
                    break;

                case "2":
                    Console.WriteLine("Digite o nome do item para remover:");
                    string itemToRemove = Console.ReadLine();

                    if (shoopingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Item '{itemToRemove}' Removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemToRemove}' não encontrado!");
                    }

                case "3":
                    Console.WriteLine("/n Itens na sua lista de Compras: ");

                    if (shoopingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista está vazia!");
                    }
                    else
                    {
                        for (int i = 0; i < shoopingList.Count; i++)
                        {
                            Console.WriteLine($"{i + i}. {shoopingList[i]}");
                        }
                    }
                    break;
                case "4":
                    file.WriteAllLines(filePath, shoopingList);
                    Console.WriteLine("Lista salva com sucesso! Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção da Inválida. Tente novamente");
                 
                
            }
            }
    } 
}
