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
            long c = Factorial(5);
            Console.WriteLine("Factorial of 5 = {0}", c);
            Console.ReadLine();
        }

        static long Factorial(int n)
        {
            if (n == 0)  // Factorial 0 = 1
                return 1;
            return n * Factorial(n - 1);

        }
    }
}
