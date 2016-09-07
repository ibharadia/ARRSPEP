using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler5
{
    class ProjectEulerSolution5
    {
        static void Main(string[] args)
        {
            Console.Write("Please Wait...");

            var num = 1;
            while (true)
            {
                bool isDiv = false;
                for (int i = 1; i <= 20; i++)
                {
                    if ((num%i) != 0)
                    {
                        isDiv = false;
                        break;
                    }
                    else isDiv = true;
                }
                if (isDiv) break;
                else num++;
            }
            Console.Write("\rThe first number divisible by 1 through 20"
                +" with no remainder is: {0}", num);
            Console.WriteLine("\nPress enter to continue...");
            var quit = Console.ReadLine();
        }
    }
}
