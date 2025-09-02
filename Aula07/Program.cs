namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==========Operadores de Atribuição");

        //Inicializar a variável
        int x = 10;
        Console.WriteLine("Valor Inicial da Variável de x: " + x);

        //Operador de Atribuição Simples (=)
        x = 20;
        Console.WriteLine("/nAtribuição Simples(=)");
        Console.WriteLine("Valor de x: " + x);


        //Atribuição Composta (Incremento) (++) 
        x++; //Equivale a x = x + 1

        Console.WriteLine("/n Atribuição Composta Incremento (++)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (+=) 
        x += 10; //Equivale x = x + 10

        Console.WriteLine("/n Atribuição Composta Incremento (+=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (-=) 
        x -= 10; //Equivale x = x - 10

        Console.WriteLine("/n Atribuição Composta Incremento (-=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (*=) 
        x *= 10; //Equivale x = x * 10

        Console.WriteLine("/n Atribuição Composta Incremento (*=)");
        Console.WriteLine("Novo valor de x: " + x);
        
             //Atribuição Composta (/=) 
        x /= 10; //Equivale x = / * 10

        Console.WriteLine("/n Atribuição Composta Incremento (/=)");
        Console.WriteLine("Novo valor de x: " + x );
    }
}