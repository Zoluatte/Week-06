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
            double d = 5e9d;
            Console.WriteLine(d);
            int i = checked((int)d);
            Console.WriteLine(i);

        }
    }
}
