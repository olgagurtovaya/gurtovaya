using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            string b;
            b = Console.ReadLine();
            Console.WriteLine("INSERT INTO points (x, y) VALUES"+"("+"'"+a+"'"+","+"'"+b+"'"+")");
            
        }
    }
}
