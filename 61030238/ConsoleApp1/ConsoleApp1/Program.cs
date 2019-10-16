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

            int a, e;
            Console.WriteLine("ป้อนค่าเริ่มต้น");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ป้อนค่สิ้นสุด");
            e = int.Parse(Console.ReadLine());
            add(a, e);
            Console.ReadLine();
        }

        static int add(int a, int e)
        {
            double c;
            while (a < e)
                a = a + 1;
            c = a % 7;
            if (c == 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Write("");
            }

            return a;

        }
    }

}

