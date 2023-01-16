using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array2d = new int [N,N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array2d[i, j] = (((i + 1) % 2 == 1 && (j + 1) % 2 == 1) || ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)) ? 1 : 0;
                    Console.Write(array2d[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
