using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler7
{
    class ProjectEulerSolution7
    {
        static void Main(string[] args)
        {
            var possiblePrime = 2;
            var thisPrime = 0;
            var numOfPrimes = 0;
            while (numOfPrimes < 10001)
            {
                thisPrime = PrimeNums(possiblePrime);
                if (thisPrime > 0)
                {
                    numOfPrimes++;
                    Console.WriteLine("Prime number " +numOfPrimes +" is: " +thisPrime);
                }
                possiblePrime++;
            }
            var quit = Console.ReadLine();
        }


        public static int PrimeNums(int x)
        {
            var returningNumber = 0;
            for (var i = 1; i < x; i++)
            {
                if ((x%i == 0) && (i != x) && (i != 1))
                {
                    returningNumber =  0;
                    break;
                }
                else
                {
                    returningNumber = x;
                }
            }
            return returningNumber;
        }
    }
}
