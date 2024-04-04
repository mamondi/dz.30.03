using System;

namespace dz30._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Del.Del del = new Del.Del();

            Console.WriteLine("Парні числа:");
            var evens = del.FilterNumbers(numbers, del.IsEven);
            foreach (var number in evens)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Непарні числа:");
            var odds = del.FilterNumbers(numbers, del.IsOdd);
            foreach (var number in odds)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Прості числа:");
            var primes = del.FilterNumbers(numbers, del.IsPrime);
            foreach (var number in primes)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Числа Фібоначчі:");
            var fibonacci = del.GetFibonacciNumbers(numbers);
            foreach (var number in fibonacci)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
