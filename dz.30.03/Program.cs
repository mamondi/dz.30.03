using System;

namespace dz30._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            NumberChecker numberChecker = new NumberChecker();

            int number = 17; // <- Ввід числа

            Console.WriteLine($"Число {number} парне: {numberChecker.Check(number, numberChecker.IsEven)}");
            Console.WriteLine($"Число {number} непарне: {numberChecker.Check(number, numberChecker.IsOdd)}");
            Console.WriteLine($"Число {number} просте: {numberChecker.Check(number, numberChecker.IsPrime)}");
            Console.WriteLine($"Число {number} є числом Фібоначчі: {numberChecker.Check(number, numberChecker.IsFibonacci)}");
        }
    }
}
