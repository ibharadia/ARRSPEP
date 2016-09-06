using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler3
{
    class ProjectEulerSolution3
    {
        static void Main(string[] args)
        {
            var num = 600851475143;
            var divisor = 2;
            while (true)
            {
                if (IsPrime(divisor))
                {
                    if (num%divisor == 0)
                    {
                        Console.WriteLine("\r" +num +" is divisible by the prime number: " + divisor);
                        Console.WriteLine();
                    }                  
                    Console.Write("\rChecking prime number {0}", divisor);
                }
                divisor++;
                if (divisor == 10000)
                    break;
            }
            Console.Write("\rPress Enter to continue...");
            var quit = Console.ReadLine();
        }

        public static bool IsPrime(int x)
        {
            var isPrime = false;
            for (var i = 1; i < x; i++)
            {
                if ((x%i == 0) && (i != x) && (i != 1))
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    isPrime = true;
                }
            }
            return isPrime;
        }
    }
}
