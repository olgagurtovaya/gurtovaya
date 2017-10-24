using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
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
            d = Math.Sin(result);
            Console.WriteLine("{0:F4}",d);
        }
    }
}
