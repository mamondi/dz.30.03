using System;

namespace dz30._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Calculator calculator = new Calculator();

            double num1 = 10;
            double num2 = 5;

            Console.WriteLine($"Додавання: {calculator.Add.Invoke(num1, num2)}");
            Console.WriteLine($"Віднімання: {calculator.Subtract.Invoke(num1, num2)}");
            Console.WriteLine($"Множення: {calculator.Multiply.Invoke(num1, num2)}");
        }
    }

    internal class Calculator
    {
        public delegate double ArithmeticOperation(double num1, double num2);

        public ArithmeticOperation Add;
        public ArithmeticOperation Subtract;
        public ArithmeticOperation Multiply;

        public Calculator()
        {
            Add = (x, y) => x + y;
            Subtract = (x, y) => x - y;
            Multiply = (x, y) => x * y;
        }
    }
}
