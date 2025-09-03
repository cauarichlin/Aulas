namespace Aula17;

public class Program
{
    public static void Main()
    {
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Abacate",
            "Pera"
        };

        Console.WriteLine(fruits[2]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        fruits.Add("Limão");
        fruits.Add("Laranja");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        fruits.Remove("Limão");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        Console.WriteLine("Quantidade de Frutas: " + fruits.Count);

        fruits[2] = "Maracujá";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

          Console.WriteLine(separator);

        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
      

    }
}