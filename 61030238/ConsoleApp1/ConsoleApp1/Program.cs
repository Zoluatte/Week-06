using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 3;
            byte b = 5;

            Console.WriteLine(a | b);
            Console.WriteLine(a & b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a & b);
            Console.WriteLine(a << 1);
            Console.WriteLine(a << 2);
            Console.WriteLine(a >> 1);

        }
    }
}
