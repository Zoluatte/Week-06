using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
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
