using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
                return;
            }
            while (b >= a)
            {
                Console.Write(" ");
                Console.Write(b);
                b = b - 1;
            }
        }
    }
}



