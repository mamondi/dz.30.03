using System;

namespace dz30._03
{
    internal class Del
    {
        public void DisplayCurrentTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public void DisplayCurrentDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }

        public void DisplayCurrentDayOfWeek()
        {
            Console.WriteLine(DateTime.Today.DayOfWeek);
        }

        public double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}
