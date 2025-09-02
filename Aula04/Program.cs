namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-----CADASTRO DE USUARIO-----");

        //Solicitar o nome do Usuario
        Console.WriteLine("Digite Seu Nome:");
        string name = Console.ReadLine();


        //Solicitar a Idade do Usuario 
        Console.WriteLine("Digite Sua Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("----------");

        Console.WriteLine("Nome do Usuario: " + name);
        Console.WriteLine("Idade do Usuario: " + age);
    }
}