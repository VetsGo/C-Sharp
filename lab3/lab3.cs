using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 0, c = 0, d = 0;
            if (num > 99 && num < 1000)
            {
                a = (num % 1000) / 100;
                b = (num % 100) / 10;
                c = num % 10;
                d = a + b + c;
                if(d%2 == 0)
                {
                    Console.WriteLine("The sum of the digits of this 3-digit number is an even number: " + d);
                }
                else
                {
                    Console.WriteLine("The sum of the digits of this 3-digit number is an odd number: " + d);
                }

            }
            else
            {
                Console.WriteLine(num + " is not a 3-digit number!");
            }
            Console.ReadLine(); 
        }
    }
}
