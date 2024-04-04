using System;

namespace dz30._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MessageDisplay messageDisplay = new MessageDisplay();

            messageDisplay.DisplayMessage("Це звичайне повідомлення.");
            messageDisplay.DisplayMessageWithPrefix("Увага:", "Це повідомлення має префікс.");
            messageDisplay.DisplayMessageInUppercase("Це повідомлення у верхньому регістрі.");
            Console.WriteLine();
            messageDisplay.DisplayCustomMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla blandit tristique enim, id vehicula lorem ultrices vitae. Ut volutpat orci eget purus porttitor, quis vulputate dolor elementum. Aliquam lacus arcu, euismod at semper eget, fermentum nec nunc. Sed vitae enim lectus. Phasellus dictum ac ligula nec egestas.");
        }
    }
}
