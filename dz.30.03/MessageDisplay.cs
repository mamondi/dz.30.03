using System;

namespace dz30._03
{
    internal class MessageDisplay
    {
        public delegate void DisplayMessageDelegate(string message);

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayMessageWithPrefix(string prefix, string message)
        {
            Console.WriteLine($"{prefix} {message}");
        }

        public void DisplayMessageInUppercase(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        public void DisplayCustomMessage(string message)
        {
            Console.WriteLine($"Custom: {message}");
        }
    }
}
