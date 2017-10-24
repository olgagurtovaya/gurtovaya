using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int x;
            x = int.Parse(a);
            string b;
            b = Console.ReadLine();
            int y;
            y = int.Parse(b);
            if (x < 0)

            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            if (y < 0)

            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            int c,d;
            c = x * 100 / y;
            d = x * 100 % y;
            Console.WriteLine("Количество изделий{0},остаток{1}",c,d);








        }
    }
}
