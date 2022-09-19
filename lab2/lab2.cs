using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter nn = ");
            int nn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter nk = ");
            int nk = Convert.ToInt32(Console.ReadLine());
            double p = 1;

            if (0 <= nn && nn <= nk)
            {
                for (int i = nn; i <= nk; i++)
                {
                    p *= (Math.Pow(i, 2) + Math.Pow(-1, Math.Pow(i, 2) + Math.Pow(-1, i) * i) * i) / (3 * Math.Pow(i, 2) + 5);
                }
                Console.WriteLine("The product of a number series = " + p);
            }
            else
            {
                Console.WriteLine("<0 <= nn <= nk> condition is not fulfilled!");
            }
            Console.ReadLine();
        }
    }
}
