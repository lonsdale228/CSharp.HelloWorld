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
            Console.Clear();// CLR
            var text = Console.ReadLine();
            Console.WriteLine(text);
        }
    }
}
