using System;

namespace dz30._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Del del = new Del();

            Console.WriteLine("Поточний час:");
            del.DisplayCurrentTime();

            Console.WriteLine("Поточна дата:");
            del.DisplayCurrentDate();

            Console.WriteLine("Поточний день тижня:");
            del.DisplayCurrentDayOfWeek();

            double triangleArea = del.CalculateTriangleArea(5, 7);
            Console.WriteLine($"Площа трикутника зі сторонами 5 та 7: {triangleArea}");

            double rectangleArea = del.CalculateRectangleArea(4, 8);
            Console.WriteLine($"Площа прямокутника зі сторонами 4 та 8: {rectangleArea}");
        }
    }
}
