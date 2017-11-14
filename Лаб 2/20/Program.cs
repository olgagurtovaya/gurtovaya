using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double y;
            y = double.Parse(a);
            string b;
            b = Console.ReadLine();
            double z;
            z = double.Parse(b);
            string c;
            c = Console.ReadLine();
            double d;
            d = double.Parse(c);
            if (y < 0)
            {
                Console.WriteLine("Значение должно быть неотрицательным");
                return;
            }
            if (z < 0)
            {
                Console.WriteLine("Значение должно быть неотрицательным");
                return;
            }
            if (d < 0)
            {
                Console.WriteLine("Значение должно быть неотрицательным");
                return;
            }
                double x;
            x = (y * z*z) / 2;
            Console.WriteLine("Кинетическая энергия составляет:"); Console.WriteLine("{0:F4}", x);
            Console.WriteLine("Дж");

            Double X;
            X = y * 9.8067 * d;
            Console.WriteLine("Потенциальная энергия составляет:");
            Console.WriteLine("{0:F4}", X); Console.WriteLine("Дж");
        }
    }
}
