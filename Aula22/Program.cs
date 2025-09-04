namespace Aula22;

public class Program
{
    public static void Main()
    {
        var bankPraiano = new Bank();
        bankPraiano.Name = "Banco Praiano";
        bankPraiano.Id = 02545;

        bankPraiano.RequestNewCard();
    }
}