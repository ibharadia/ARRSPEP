using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1
{
    class ProjectEulerSolution1
    {
        static void Main(string[] args)
        {

            var threes = 0;
            var multiple1 = 0;
            var x = 1;

            while ((multiple1+3)<1000)
            {
                
                multiple1 = (3*x);
                if ((multiple1%5) != 0)
                {
                    threes = (threes + multiple1);
                    Console.WriteLine("The next multiple of three is " + multiple1 + "!!");
                }
                else Console.WriteLine("Removed a multiple of five here.");
                x++;
            }

            var fives = 0;
            var multiple2 = 0;
            var y = 1;

            while ((multiple2+5)<1000)
            {
                multiple2 = (5*y);
                fives = (fives + multiple2);

                Console.WriteLine("The next multiple of five is " +multiple2 +"!!");

                y++;
            }

            var solution = (threes + fives);
            Console .WriteLine("The final sum: " +solution);
            var quit = Console.ReadLine();

        }
    }
}
