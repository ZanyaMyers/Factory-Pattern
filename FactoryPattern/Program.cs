using System.ComponentModel;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nya's Wall Decorations");
            Console.WriteLine("Choose from the following menu to learn more");
            Console.WriteLine(" - Peel and Stick");
            Console.WriteLine(" - Paint");
            Console.WriteLine(" - Picture Frames");
            string userInput = Console.ReadLine();

          IWallDecor decor = DecorFactory.GetWallDecor(userInput);

            decor.ChooseWallDecor();

         
        }
    }
}