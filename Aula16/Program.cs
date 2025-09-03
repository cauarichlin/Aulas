namespace Aula16;

public class Program
{
    public static void Main()
    {
        string[] fruits = { "Maçã", "Banana", "Caju", "Manga" };

        Console.WriteLine(fruits[1]);

        Console.WriteLine(separtor);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("Quantidade de Índices: " + fruits.Length);

        Console.WriteLine(separator);

        Console.WriteLine("Valor antes da alteração: " + fruits[1]);

        fruits[1] = "Abacaxi";

        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }   
    }
}