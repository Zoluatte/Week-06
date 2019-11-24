using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week06
{
    class Program
    {
        static void Main(string[] args)
        {
            int s,l;
            Console.WriteLine("enter number start : ");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number last : ");
            l = int.Parse(Console.ReadLine());
            Output(s,l);
           
        }

        static void Output(int s,int l)
        {
            for (int n = s; n <= l; n++)
            {
                if (n % 7 == 0)
                Console.WriteLine($"number : {n}");

            }
            
        }
    }
}
