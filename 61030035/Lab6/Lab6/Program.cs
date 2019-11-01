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
            int x = 17;
            double y = x / 4.0;
            double z = y * y;
            Console.WriteLine(y);
            Console.WriteLine(z);

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine(a + (b++));
            Console.WriteLine(a + b);
            Console.WriteLine(a + (++b));
            Console.WriteLine(a + b);
            Console.WriteLine(14 / a);
            Console.WriteLine(14 % a);
        }
    }
}
