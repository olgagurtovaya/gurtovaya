using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            b = Console.ReadLine();
            double y;
            y = double.Parse(b);
            string a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            if (x > 0)
            {
                Console.WriteLine("Значение X должно быть не положительным");
                return;
            }
            double d;
            d = y * Math.Sqrt(-7*x);
            Console.WriteLine("{0:F4}", d);
        }
    }
}
