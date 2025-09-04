namespace Aula23;

public class Program
{
    public static void Main()
    {
        Person person = new Person();
        person.Name = "João da Silva";

        Console.WriteLine("Digite uma idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string response = person.IfLegalPersonRefactorName(age, person.Name);

        Console.WriteLine(response); 
    }
}