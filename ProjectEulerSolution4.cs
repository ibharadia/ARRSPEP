using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler4
{
    class ProjectEulerSolution4
    {
        static void Main(string[] args)
        {
            var product = 0;
            var maxProduct = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    product = i*j;
                    if (IsPalindrome(product))
                    {
                        Console.WriteLine("{0} times {1} equals {2} ; A palindrome.", i, j, product);
                        if (maxProduct < product) maxProduct = product;
                    }
                }
            }
            Console.WriteLine("\n\tThe highest valued palindrome product was {0}!\n", maxProduct);
            Console.Write("Press enter to continue...");
            var quit = Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {
            var numString = x.ToString();
            char[] numChars = numString.ToCharArray();
            Array.Reverse(numChars);
            var numStringRev = new string(numChars);

            if (numString == numStringRev) return true;
            else return false;
        }
    }
}
