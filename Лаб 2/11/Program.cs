﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            b = Console.ReadLine();
            double y;
            y = double.Parse(b);
            if (y < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            double d;
            d = Math.Sqrt(y);
            Console.WriteLine("{0:F4}", d);
        }
    }
}
