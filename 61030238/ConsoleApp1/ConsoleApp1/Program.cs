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

            double a, c;
            double v = 1 / 6;
            Console.WriteLine("น้ำหนักเรา");

            a = double.Parse(Console.ReadLine());

            c = add(a, v);
            Console.WriteLine(c);
        }

        static double add(double a, double v)
        {
            return a * v;
        }
    }

}

