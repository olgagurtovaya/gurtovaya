using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
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
            B= Console.ReadLine();
            double b;
            b = double.Parse(B);
            string C;
            C = Console.ReadLine();
            double c;
            c= double.Parse(C);
            if (y <= 0)
            {
                Console.WriteLine("Масса должна быть пложительна");
                return;
            } 
            double x;
            x = b * b - 4 * a * c;
            Console.WriteLine("{0:F4}", x);
        }
    }
}
