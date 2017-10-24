using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            b = Console.ReadLine();
            double y;
            y = double.Parse(b);
            double result;
            result = y * Math.PI / 180;
            double d;
            d = 5* Math.Cos(result);
            Console.WriteLine("{0:F4}", d);
        }
    }
}
