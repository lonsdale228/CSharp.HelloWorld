using System;
using System.Threading;

namespace ShWan.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //смена цвета в консоле
            Console.WriteLine("Hello World!");
            Thread.Sleep(2000); //sleep
            Console.Clear();// CLR screen
            var test = Console.ReadLine();// принимает любое значение
            Int32 text = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(text);
        }
    }
}
