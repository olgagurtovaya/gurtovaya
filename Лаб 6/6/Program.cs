using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            double c = 0;
            if (a < b)
                while (a <= b)
                {
                    Console.Write(" ");
                    Console.Write(a);
                    a = a + 1;
                }
            else
                while (b <= a)
                {
                    Console.Write(" ");
                    Console.Write(a);
                    a = a - 1;
                }
                }
            }
        }
    



