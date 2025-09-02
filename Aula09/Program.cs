using System;

namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======Operadores Lógicos=====");

        bool isLogged = true;
        bool hasAdminAcces = false;

        Console.WriteLine("/nInformações do Usuário:");
        Console.WriteLine("Usuario Logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAcces);

        Console.WriteLine("/nPermissões:");

        //Operador (||) - Ou
        if (isLogged || hasAdminAcces)
        {
            Console.WriteLine("Acesso ao sistema concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado");
        }


        //Operador (&&) - E
        if (isLogged && hasAdminAcces)
        {
            Console.WriteLine("Acesso ao painel de administrador concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de administrador negado");
        }

        //Operador (!) - "Não..."
        if (!isLogged)
        {
            Console.WriteLine("Usuario não está logado");
        }
        else
        {
            Console.WriteLine("Usuario está logado");
        }
    }
}