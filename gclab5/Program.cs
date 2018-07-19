using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y = true;
            while (y)
            {
                Console.WriteLine("Hello user! I am a factorial calculator. Please enter and integer from 1 to 10:");
                long userLong = long.Parse(Console.ReadLine());

                long result = userLong;
                for (long i = 1; i < userLong; i++)
                    result = result * i;
                Console.WriteLine(result);

                //continue y/n
                bool invalid = true;
                while (invalid)
                {
                    Console.WriteLine("Continue? (y/n):");
                    ConsoleKeyInfo pressed = Console.ReadKey();
                    Console.WriteLine();
                    bool isY = pressed.Key == ConsoleKey.Y;
                    bool isN = pressed.Key == ConsoleKey.N;

                    invalid = !isY && !isN;
                    y = isY;
                }
            }


        }
        //25! is limit
       /* 
        public static long Factorial(long i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
        */
        
        /*
        static bool ShouldContinue()
        {
            //continue y/n
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("Continue? (y/n):");
                ConsoleKeyInfo pressed = Console.ReadKey();
                Console.WriteLine();
                bool isY = pressed.Key == ConsoleKey.Y;
                bool isN = pressed.Key == ConsoleKey.N;

                invalid = !isY && !isN;
                y = isY;
            }*/

    }
}
