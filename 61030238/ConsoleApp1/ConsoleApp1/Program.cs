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

            for (int t = 0; t <= 100; t++)
            {
                String aa = "";
                while (t > 0)
                {
                    if (t >= 2)
                    {
                        aa = (t % 2) + aa;
                    }
                    else
                    {
                        aa = t + aa;
                    }
                    t = t / 2;


                }


                int n = int.Parse(aa);
                Console.WriteLine(n);
            }
        }
    }
}



