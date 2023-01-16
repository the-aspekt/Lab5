using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array2d = new int[N, N];
            Console.WriteLine("Введите элементы массива. Их будет {0}.", N*N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    array2d[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вы ввели массив:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write("{0, 4} ", array2d[i, j]);
                Console.WriteLine();
            }
            int sum = 0;   
            for (int i = 0; i < N; i++)
                    sum += array2d[i,i];
            Console.WriteLine("Сумма по главной диагонали составляет {0}", sum);
            bool flag = true;

            for (int i = 0; i < N; i++)
            {
                int sumCheckX, sumCheckY;
                sumCheckX = sumCheckY = 0;
                for (int j = 0; j < N; j++)
                {
                    sumCheckX += array2d[i, j];
                    sumCheckY += array2d[j, i];
                }
                Console.WriteLine("Суммы по {0} строке и по {0} столбцу составляют соответственно {1} и {2} ", i, sumCheckX, sumCheckY);
                if ((sumCheckX != sum) || (sumCheckY != sum))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                int sumCheck = 0;
                for (int j = 0; j < N; j++)
                    sumCheck += array2d[N-1-j, j];
                Console.WriteLine("Сумма по второстепенной диагонали составляет {0}", sumCheck);
                flag = sumCheck == sum;
            }
            if (flag)
            {
                Console.WriteLine("Квадрат является магическим!");
            }
            else
            {
                Console.WriteLine("Квадрат не является магическим!");
            }
            
            Console.ReadLine();
        }
    }
}
