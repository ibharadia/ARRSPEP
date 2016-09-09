using System;

namespace ProjectEuler9
{
    class ProjectEulerSolution9
    {
        static void Main(string[] args)
        {
            double a,b,c;
            b = 0; c = 0;

            var isThousand = false;
            for (a = 0; a < 1000; a++)
            {
                for (b = 0; b < 1000; b++)
                {
                    double cSqu = Math.Pow(a, 2) + Math.Pow(b, 2);
                    c = Math.Sqrt(cSqu);
                    if (a<b && b<c && (a+b+c == 1000))
                    {
                        Console.WriteLine("{0} + {1} + {2} = 1000", a, b, c);
                        isThousand = true;
                        break;
                    }
                }
                if (isThousand) break;
            }
            var product = a*b*c;
            Console.WriteLine("The product abc is: {0} \nPress Enter to continue...", product);
            Console.ReadLine();
        }
    }
}
