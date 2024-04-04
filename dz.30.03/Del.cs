using System;

namespace dz30._03
{
    internal class CreditCard
    {
        public string CardNumber { get; }
        public string CardHolderName { get; }
        public string ExpiryDate { get; }
        public string Pin { get; private set; }
        public decimal CreditLimit { get; }
        public decimal Balance { get; private set; }

        public event Action TopUp;
        public event Action Spend;
        public event Action CreditStarted;
        public event Action LimitReached;
        public event Action PinChanged;

        public CreditCard(string cardNumber, string cardHolderName, string expiryDate, string pin, decimal creditLimit, decimal balance)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
            Pin = pin;
            CreditLimit = creditLimit;
            Balance = balance;
        }

        public void TopUpMoney(decimal amount)
        {
            Balance += amount;
            TopUp?.Invoke();
        }

        public void SpendMoney(decimal amount)
        {
            Balance -= amount;
            Spend?.Invoke();
            if (Balance < 0 && CreditStarted != null)
            {
                CreditStarted.Invoke();
                if (Math.Abs(Balance) >= CreditLimit && LimitReached != null)
                {
                    LimitReached.Invoke();
                }
            }
        }

        public void StartCredit()
        {
            if (Balance < 0)
            {
                CreditStarted?.Invoke();
            }
        }

        public void ChangePin(string newPin)
        {
            Pin = newPin;
            PinChanged?.Invoke();
        }

        public void DisplayCardInfo()
        {
            Console.WriteLine($"Номер картки: {CardNumber}");
            Console.WriteLine($"ПІБ власника: {CardHolderName}");
            Console.WriteLine($"Термін дії карти: {ExpiryDate}");
            Console.WriteLine($"Поточний баланс: {Balance}");
            Console.WriteLine($"Кредитний ліміт: {CreditLimit}");
            Console.WriteLine();
        }
    }
}
