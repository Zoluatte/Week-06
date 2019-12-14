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
            int s, l;
            Console.WriteLine("Enter number start:");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number last:");
            l = int.Parse(Console.ReadLine());
            Output(s, l);
            
        }
        static void Output(int s, int l)
        {
            for (int n = s ; n <= l ; n++)
            { 
                if (n % 7 == 0)
                    Console.Write($"number:{n}");
                Console.ReadLine();
            }
        }
    }

}
