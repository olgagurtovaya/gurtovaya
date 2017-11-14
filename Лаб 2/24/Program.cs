using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            A = Console.ReadLine();
            double a;
            a = double.Parse(A);
            string B;
            B = Console.ReadLine();
            double b;
            b = double.Parse(B);
            string C;
            C = Console.ReadLine();
            double c;
            c = double.Parse(C);
            if (a<= 0)
            {
                Console.WriteLine("Масса должна быть пложительна");
                return;
            }
            if (b<= 0)
            {
                Console.WriteLine("Масса должна быть пложительна");
                return;
            }
            if (c<= 0)
            {
                Console.WriteLine("Дистанция должня быть положительна");
                return;
            }
            double x;
            x = 9.8067 * ((a * b) /(c * c));
            Console.WriteLine("{0:F4}", x);

        }
    }
}
