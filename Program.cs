using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int dimension = 6;
            int[] array = new int[dimension];
            int sum = 0;
            for (int i = 0; i <= dimension; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine((double)sum/(dimension+1)); 
            Console.ReadKey();

        }
    }
}
