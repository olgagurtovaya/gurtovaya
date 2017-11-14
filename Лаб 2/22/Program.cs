using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
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
            if (y <= 0)
            {
                Console.WriteLine("Масса должна быть пложительна");
                return;
            }
            double result;
            result = z* Math.PI / 180;
            double s;
            s = Math.Cos(result);
            double x;
            x = y * 9.8067 * s;
            Console.WriteLine("{0:F4}", x);
        }
    }
}
