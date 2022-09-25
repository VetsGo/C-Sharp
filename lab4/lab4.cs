using System;

namespace lab4
{
    class Program
    {
		const int N = 4;
        static void Main(string[] args)
        {
			int[] a = new int[N] { 1,4,10,14};
			
			int[] b = new int[N] { 2,8,20,21};
			
			int[] c = new int[N*2];

			int i = 0, j = 0, k = 0;

			while (i < N && j < N)
			{
				if (a[i] < b[j])
					c[k++] = a[i++];
				else
					c[k++] = b[j++];
			}
			while (i < N)
				c[k++] = a[i++];

			while (j < N)
				c[k++] = b[j++];

			Console.WriteLine("Sorted array of two arrays");
			for (i = 0; i < N*2; i++)
				Console.Write(c[i] + " ");

			Console.ReadKey();
		}
    }
}