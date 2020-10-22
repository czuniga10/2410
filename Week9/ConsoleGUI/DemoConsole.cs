using System;

namespace ConsoleGUI
{
    public class DemoConsole
    {

        public static void DemoColor()
        {
            Console.WriteLine("T I T L E");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Cyan;

            var height = 19;
            var topOfSq = 4;
            var margin = 3;

            for (var n = 0; n < height / 2; n++)
            {
                Console.CursorTop = topOfSq + n;
                toggleColor();
                for (var i = 0; i < height - n*2; i++)
                {
                    var str = "{0," + (2 * height - (n*4)) + " }";
                    Console.CursorLeft = margin + (n*2);
                    Console.WriteLine(str, " ");
                }

            }

            Console.CursorTop = 30;
        }

        private static void toggleColor()
        {
            if (Console.BackgroundColor == ConsoleColor.DarkGreen)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
        }
    }
}
