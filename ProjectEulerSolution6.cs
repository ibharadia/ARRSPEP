using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler6
{
    class ProjectEulerSolution6
    {
        static void Main(string[] args)
        {
            var final1 = 0;
            var final2 = 0;

            for(var i=1; i <= 100; i++)
            {
                var num1 = (i*i);
                final1 = (final1 + num1);
            }

            for (var j = 1; j <= 100; j++)
            {
                final2 = (final2 + j);
            }
            final2 = (final2*final2);

            var final3 = (final2 - final1);

            Console.WriteLine("Sum of the squares of 1 through 100: " + final1);
            Console.WriteLine("Square of the sum of 1 through 100: " + final2);
            Console.WriteLine("The difference is: " + final3);
            var quit = Console.ReadLine();

        }
    }
}
