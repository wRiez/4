using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parlament
{
    internal class Forr
    {

        public void fo_16()
        {
            Console.WriteLine("\nВведите число и степень");
            double A = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            while (N < 0)
            {
                Console.WriteLine("\nЧисло должно быть больше 0");
                N = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nВсе степени числа {A}");
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{Math.Pow(A, i)}, ");
            }
            Console.WriteLine("");
        }

    }
}
