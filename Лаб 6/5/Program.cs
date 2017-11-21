using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            string b;

            a = double.Parse(Console.ReadLine());
            b = Console.ReadLine();
            if (a <0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }

            //    Console.Write(" \" ");
            //Console.Write(b);
            //Console.Write(b);
            //Console.Write(b);
            //Console.Write(b);
            //Console.Write(b);
            //Console.Write(b);
            //Console.Write(b);
            //Console.Write(b);
            //Console.Write(" \" ");
            double c = 0;
            Console.Write(" \" ");
            while (a > c)         
            {
             Console.Write(b);
             c = c + 1;
             }
            Console.Write(" \" ");
          
        }
    }
}
