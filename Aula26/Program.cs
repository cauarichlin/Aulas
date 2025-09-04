namespace Aula27;

public class Program
{
    public static void Main()
    {
        Cake cakeChocolate = new Cake("Chocolate", "Coco", "Chocolate", 3, "Médio");

        Cake cakeMorango = new Cake("Morango", "Morango", "Chocolate", 1, "Pequeno");

        Console.WriteLine($"Sabor: {cakeChocolate.Flavor}");
        Console.WriteLine($"Recheio: {cake.Chocolate}");
        Console.WriteLine($"Cobertura: {cake.Chocolate}");
        Console.WriteLine($"Camadas: {cake.Chocolate}");
        Console.WriteLine($"Tamanho: {cake.Chocolate}");

        Console.WriteLine($"Sabor: {cakeStrawberry.Flavor}");
        Console.WriteLine($"Recheio: {cake.Strawberry}");
        Console.WriteLine($"Cobertura: {cake.Strawberry}");
        Console.WriteLine($"Camadas: {cake.Strawberry}");
        Console.WriteLine($"Tamanho: {cake.Strawberry}");
    }
}
