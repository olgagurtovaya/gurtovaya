using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
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
            double x;
            x = (y * z) + (d * z * z) / 2;
            Console.WriteLine("{0:F2}", x);

        }
    }
}
