namespace Aula25
{
    public class Program
    {
        decimal balance = 1000;

        public void CheckBalance()
        {
            Console.WriteLine("Seu saldo é de R$" + balance);
        }

        public void Deposit()
        {
            Console.WriteLine("Informe o valor a ser depositado: R$ ");

            if (decimal.TryParse(COnsole.ReadLine(), out decimal amount) && amount > 0)
            {
                balance += amount;
            }

            else
            {
                Console.WriteLine("Valor Inválido. Tente novamente");
            }
        }

        public void WithDraw()
        {
            Console.WriteLine("informe o valor a ser retirado: R$ ");

            if (decimal.TryParse(COnsole.ReadLine(), out decimal amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;
                    Console.WriteLine("Valor de ");
                }
            }
            else
            {
                Console.WriteLine("Valor Inválido. Tente novamente");
            }
        }
    }
}
