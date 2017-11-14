using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
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
            if (y <= 0)
            {
                Console.WriteLine("Значение r1 должно быть не равно нулю");
                return;
            }
            if (z <= 0)
            {
                Console.WriteLine("Значение r2 должно быть не равно нулю");
                return;
            }
            double x;
            x = (1/y +1/z);
            Console.WriteLine("{0:F4}", x);
           


        }
    }
}
