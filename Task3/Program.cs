using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int dimension = 10;
            Random random = new Random();
            Console.WriteLine("Автоматически сформируем массив из {0} элементов", dimension);
            int[] array = new int[dimension];
            for (int i = 0; i < dimension; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine(); 
            int halfOfArray = dimension / 2 - 1;
            
            for (int i = 0; i < halfOfArray; i++)
            {
                for (int j = i+1; j < halfOfArray + 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.Write("{0} ", array[i]);
            }
            
            for (int i = halfOfArray; i < dimension-1; i++)
            {
                for (int j = i + 1; j < dimension; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.Write("{0} ", array[i]);
            }

            Console.Write("{0} ", array[dimension-1]);
            Console.WriteLine();
            Console.WriteLine("Массив успешно отсортирован по возрастанию до половины и по убыванию от половины");
            Console.ReadLine();
        }
    }
}
