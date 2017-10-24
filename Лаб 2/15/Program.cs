using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            b = Console.ReadLine();
            double y;
            y = double.Parse(b);
            if (y < -273.15)
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
                return;
            }
            double d;
            d = y * 1.8 + 32;
            Console.WriteLine("{0:F4}", d);
        }
    }
}
