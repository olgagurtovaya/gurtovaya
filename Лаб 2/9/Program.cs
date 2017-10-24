using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            b = Console.ReadLine();
            int y;
            y = int.Parse(b);
            int d;

            d = y%360;
            Console.WriteLine( d);
        }
    }
}
