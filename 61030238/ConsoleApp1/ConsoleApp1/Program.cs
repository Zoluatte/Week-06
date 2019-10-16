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

            double a;
            Console.WriteLine("ป้อนค่าa");
            a = double.Parse(Console.ReadLine());

            add(a);
            Console.ReadLine();
        }

        static double add(double a)
        {
            double c;
            c = a % 2;
            if (c == 0)
            {
                Console.WriteLine("เลขคู่");
            }
            else
            {
                Console.WriteLine("เลขคี่");
            }
            return c;
        }

    }
}