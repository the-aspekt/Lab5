using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int dimension = 15;
            Random random = new Random();
            Console.WriteLine("Автоматически сформируем массив из {0} элементов", dimension);
            int[] array = new int[dimension];
            for (int i = 0; i < dimension; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
                Console.WriteLine();

            }
            int sum = array.Min() + array.Max();
            Console.WriteLine("Сумма максимального и минимального элементов массива равна {0}", sum);
            Console.ReadLine();

        }
    }
}
