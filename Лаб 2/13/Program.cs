using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            b = Console.ReadLine();
            double y;
            y = double.Parse(b);
            if (61-y < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double d;
            d = 3*Math.Sqrt(61-y);
            Console.WriteLine("{0:F4}", d);
           
            }
        }
    }
    

