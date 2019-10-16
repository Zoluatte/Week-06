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

            double a, b, c, d, f;
            double v = 0.5;
            Console.WriteLine("พื้นที่คางหมู");
            Console.WriteLine("ความสูง");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("ด้านคู่ขนานด้านที่1");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("ด้านคู่ขนานด้านที่2");
            d = double.Parse(Console.ReadLine());
            b = c + d;
            f = add(a, b, v);
            Console.WriteLine(f);
        }

        static double add(double a, double b, double v)
        {
            return v * (a * b);
        }

    }
}
