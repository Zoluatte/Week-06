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
            int val = 999;
            refMethod(ref val);
            Console.WriteLine(val);
            Console.ReadLine();
        }

        static void refMethod(ref int i)
        {
            i = i + 1;
        }
    }
    }

