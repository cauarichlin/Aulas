namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======Operadores Relacionais====== /n");
        Console.WriteLine("Digite o primeiro numero: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        int y = Convert.ToInt32(Console.ReadLine());

        string result;

        bool condition = x == y;

        //Operador de Igualdade (==)
        if (x == y)
        {
            result = "x é igual a y";
        }
        else
        {
            result = "x é doferente de y";
        }
        Console.WriteLine("/nIgualdade (==): " + result);

        //Operador de Diferença (!=)
        if (x != y)
        {
            result = "x é diferente de y";
        }
        else
        {
            result = "x é igual a y";
        }
        Console.WriteLine("/nIgualdade (!=): " + result);

        //Operador Maior que (>)
        if (x > y) ;
        {
            result = "x é maior que y";
        }
        else {
            result = "x não é maior que y";
        }
        Console.WriteLine("/nMaior que (>): " + result);

        //Operador Menor que (<)
        if (x < y)
        {
            result = "x é menor que y";
        }
        else
        {
            result = "x não é menor que y";
        }
        Console.WriteLine("/nMenor que (<): " + result);

        //Operador Maior ou Igual (>=)
        if (x >= y)
        {
            result = "x é maior ou igual a y";
        }
        else
        {
            result = "x não é maior ou igual a y";
        }
        Console.WriteLine("/nMaior ou igual que (>=): " + result);

        //Operador Menor ou Igual (>=)
        if (x <= y)
        {
            resukt = "x é menor ou igual a y";
        }
        else
        {
            result = "x não é menor ou igual a y ";
        }
        Console.WriteLine("/nMenor ou igual que (<=): " + result);
    }
}