namespace Aula21;

public class Program
{

    public static void Main()
    {
        var cakeStrawberry = new Cake();

        cakeStrawberry.Id = 472;
        cakeStrawberry.Name = "Bolo de Morango Recheado";
        cakeStrawberry.Description = "Intolerantes a lactose, não consumir!";
        cakeStrawberry.Value = 30;
        cakeStrawberry.IsFilling = true;

        //3. Mostrar ao usuário

        Console.WriteLine("Id: " + cakeStrawberry.Id);
        Console.WriteLine("Nome: " + cakeStrawberry.Name);
        Console.WriteLine("Descrição: " + cakeStrawberry.Description);
        Console.WriteLine("Valor: R$ " + cakeStrawberry.Value);
        Console.WriteLine("É recheado?: " + cakeStrawberry.IsFilling);


        var cakeChocolate = new Cake();

        cakeChocolate.Id = 556;
        cakeChocolate.Name = "Bolo de Chocolate";
        cakeChocolate.Description = "Cacau meio amargo";
        cakeChocolate.Value = 45;
        cakeChocolate.IsFilling = false;

        Console.WriteLine("Id: " + cakeStrawberry.Id);
        Console.WriteLine("Nome: " + cakeStrawberry.Name);
        Console.WriteLine("Descrição: " + cakeStrawberry.Description);
        Console.WriteLine("Valor: R$ " + cakeStrawberry.Value);
        Console.WriteLine("É recheado?: " + cakeStrawberry.IsFilling);

        // Listas de Bolos 
        Console.WriteLine("Lista de Bolos - Criação de Lista");

        List<Cake> cakeList = new List<Cake>();
        cakeList.add(cakeStrawberry);
        cakeList.Add(cakeChocolate);

        // Visualizar
        Console.WriteLine("Id: " + cakeStrawberry.Id);
        Console.WriteLine("Nome: " + cakeStrawberry.Name);
        Console.WriteLine("Descrição: " + cakeStrawberry.Description);
        Console.WriteLine("Valor: R$ " + cakeStrawberry.Value);
        Console.WriteLine("É recheado?: " + cakeStrawberry.IsFilling);


    }
}