using System;

namespace lab1
{
    class lab1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double num = 0;

            num = 2 * Math.Pow(x, 4) - 3 * Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 5 * x + 6;
            Console.WriteLine("num = " + num);
            Console.ReadLine();
        }
    }
}
