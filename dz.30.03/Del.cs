using System;
using System.Collections.Generic;

namespace Del
{
    internal class Del
    {
        internal delegate bool FilterDelegate(int number); 

        public List<int> FilterNumbers(int[] numbers, FilterDelegate filter)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (filter(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public List<int> GetFibonacciNumbers(int[] numbers)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (IsFibonacci(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public bool IsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }

        public bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }
    }
}
