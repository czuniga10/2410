using System;

namespace ConsoleGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoConsole.DemoColor();

            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n");
        }
    }
}

    