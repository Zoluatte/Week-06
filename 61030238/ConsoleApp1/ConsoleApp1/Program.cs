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
            int b = add(1, 2, 3, 4, 5);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("1+5+8+4+1+6+6+8 = " + add(1, 5, 8, 4, 1, 6, 6, 8));
            Console.ReadLine();
        }

        static int add(params int[] i)
        {
            int sum = 0; ;
            foreach (int j in i)
                sum += j;
            return sum;
        }
    }
    }

