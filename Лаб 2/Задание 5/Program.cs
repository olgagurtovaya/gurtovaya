using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            if (x < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            double result;
            result = 4 * Math.PI * x*x*x/3;
            Console.WriteLine("{0:F4}", result);
        }
    }
}
