using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "vjfvji*fuvfi*nakanofuhvcuifhrvjruivjyotsubaurefjuer*eifuhureieifcnhufourtwoeight";
            int c = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '*') c++;
            }
            Console.WriteLine("Amount of <*> is " + c);
            Console.ReadLine();
        }
    }
}