using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
           
            string b;
            b = Console.ReadLine();
            double y;
            y = double.Parse(b);
            if (y < 0)
                
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            if (x < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            double result;
            result = x * y / 2;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
