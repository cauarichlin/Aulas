namespace Aula12;

public class Program
{
    public static void Main()
    {
        //int i = 0;

        //while (i <= 1000)
        // {
        //    Console.WriteLine(i);
        //   i++;
        // }

        double budget = 100;

        while (budget > 0)
        {
            Console.WriteLine(budget);
            //Realizando alguma operação
            budget--;
        }

        Console.WriteLine("Atenção! Saldo Insuficiente");
    }
}