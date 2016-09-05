using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2
{
    class ProjectEulerSolution2
    {
        static void Main(string[] args)
        {

            var x = 1;
            var isOne = true;
            var y = 0;
            var fibonacci = 0;
            var z = 4000000;
            var evenTotal = 0;

            while ((x+y)<z)
            {
                fibonacci = (x + y);
                x = y;
                y = fibonacci;



                if ((fibonacci%2) != 0 && (fibonacci>1))
                {
                    Console.WriteLine("The next number in the Fibonacci sequence is odd!! "
                                      + fibonacci + "!!");
                }
                else if (fibonacci>1)
                {
                    Console.WriteLine("The next number in the Fibonacci sequence is even!! " 
                        + fibonacci + "!!");
                    evenTotal = (evenTotal + fibonacci);
                }
                else if (isOne)
                {
                    Console.WriteLine("The first number in the Fibonacci sequence is, of course 1");
                    isOne = false;
                }
            }
            Console.WriteLine("The total of all even Fibonacci numbers below four million is " 
                +evenTotal +"!");
            var end = Console.ReadLine();
        }
    }
}
