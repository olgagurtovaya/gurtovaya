using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
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
            if (Y < 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            if (X+Y < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }

            double c;
            c = -5 * Math.Sqrt(X+ Math.Sqrt(Y));
            Console.WriteLine("{0:F4}", c);

        }

    }
}
 