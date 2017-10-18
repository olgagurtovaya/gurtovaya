using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            Console.WriteLine("SELECT first_name, last_name, group");
            Console.WriteLine("FROM students WHERE id" + "="+"'" +a+"'");
        }
    }
}
