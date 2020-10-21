using System;

namespace LABS_2410
{
    /// <summary>
    /// Lab01 - CountbyN lab that uses a nested for loop to implement the series of numbers.
    /// 
    /// Author: Chad Zuniga
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 5; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write("{0,2} ",i * j);
                }
                Console.WriteLine();
            }
        }
    }
}