using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parlament
{
    internal class Whille
    {

        public void wh_16()
        {
            int days = 1;
            int first = 10;
            double process = 10;

            Console.WriteLine("\nВведите процент");
            double P = double.Parse(Console.ReadLine());
            while (P <= 0 || P > 50)
            {
                Console.WriteLine("\nЧисло должно быть больше 0 и меньше 50");
                P = double.Parse(Console.ReadLine());
            }

            while (process < 200)
            {
                process += process * (P/100);
                days++;
            }

            Console.WriteLine($"\nЧисло пройденных дней - {days}");

        }

    }
}
