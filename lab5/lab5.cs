using System;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
        const int M = 4;
        const int N = 3;
        static void Main(string[] args)
        {
            int[,] matrix = new int[M,N] {{ 1, 10, 20},
                                          { 9,  3, 30},
                                          {15, 16, 40},
                                          {12,  2, 25}};

            List<int> num = new List<int>();

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < M; i++)
            {
                int maxrow = int.MinValue;
                for (int j = 0; j < N; j++)
                {
                    maxrow = Math.Max(maxrow, matrix[i, j]);
                }
                set.Add(maxrow);
            }

            for (int j = 0; j < N; j++)
            {
                int mincol = int.MaxValue;
                for (int i = 0; i < M; i++)
                {
                    mincol = Math.Min(mincol, matrix[i, j]);
                }

                if (set.Contains(mincol))
                {
                    num.Add(mincol);
                }
            }

            if (num.Count == 0)
                Console.WriteLine("0");

            for (int i = 0; i < num.Count; i++)
                Console.WriteLine(num[i]);
        }
    }
}