using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
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
            double c;
            c = X*Y + X*D + D*Y;
            Console.WriteLine(c);
        }
    }
}
