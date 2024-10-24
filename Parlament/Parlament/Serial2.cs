using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parlament
{
    internal class Serial2
    {

        public void se_20()
        {
            int k = 0;

            Console.WriteLine("\nВведите длину набора");
            int N = int.Parse(Console.ReadLine());
            while (N <= 1)
            {
                Console.WriteLine("\nЧисло должно быть больше 1");
                N = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВведите числа набора");
            var lst = new List<double>();

            for (int i = 0; i < N; i++)
            {
                lst.Add(double.Parse(Console.ReadLine()));
            }
            var n = lst.ToArray();

            Console.WriteLine("\nЧисла меньшие своего правого соседа:");
            for (int i = 1; i < N; i++)
            {
                if (n[i] > n[i - 1])
                {
                    Console.Write($"{n[i - 1]}, ");
                    k++;
                }
            }

            Console.Write($"\n\nКоличество таких чисел составляет: {k}\n");
        }
    }
}
