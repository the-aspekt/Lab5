using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int dimension = 20;
            Random random = new Random();
            Console.WriteLine("Автоматически сформируем массив из {0} элементов", dimension);
            int[] array = new int[dimension];
            for (int i = 0; i < dimension; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int number = 0;
            for (int i = 0; i < dimension; i++)
            {
                if (((array[i] % 2) == 1) && (array[i] > 0) && ((i+1) % 2 == 0))
                    number++;
            }
           
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах равно {0}", number);
            Console.ReadLine();
        }
    }
}
