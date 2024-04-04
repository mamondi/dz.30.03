using System;

namespace dz30._03
{   internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CreditCard creditCard = new CreditCard("1234567890123456", "John Doe", "12/25", "1234", 5000, 1000);

            creditCard.TopUp += () => Console.WriteLine("Рахунок поповнено");
            creditCard.Spend += () => Console.WriteLine("Кошти знято з рахунку");
            creditCard.CreditStarted += () => Console.WriteLine("Розпочато використання кредитних коштів");
            creditCard.LimitReached += () => Console.WriteLine("Досягнуто ліміт кредитних коштів");
            creditCard.PinChanged += () => Console.WriteLine("PIN успішно змінено");

            creditCard.DisplayCardInfo();

            creditCard.TopUpMoney(2000);
            creditCard.SpendMoney(500);
            creditCard.StartCredit();
            creditCard.SpendMoney(3000);
            creditCard.ChangePin("4321");
        }
    }
}
