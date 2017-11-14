using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            x = Console.ReadLine();
            double X;
            X = double.Parse(x);
            string y;
            y = Console.ReadLine();
            double Y;
            Y = double.Parse(y);
            string d;
            d = Console.ReadLine();
            double D;
            D = double.Parse(d);
            if (X < 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            if (Y< 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }

            double c;
            c = D/(X+Y);
            Console.WriteLine("{0:F4}", c);
        }
    }
}
