using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_06
{


    class Program
    {
        static void Main()
        {
            for (int dec = 1; dec <= 100; dec++)
            {
                string bin = null;
                int ans;
                int num = dec;
                int check = 0;

                while (num >= 1)
                {
                    ans = num % 2;
                    bin = ans.ToString() + bin;
                    num /= 2;
                }
                if (bin.Length > 4)
                {
                    if (bin.Length > 5)
                    {
                        if (bin.Length > 6)
                        {
                            //Console.WriteLine($"Decimal  : {dec}\nBinary : {bin}");
                            //Console.WriteLine(bin.Substring(2, 1));                            check = int.Parse(bin.Substring(2, 1));
                            checkBit5(check, dec);
                            //digit5[dec] = check;
                            continue;
                        }
                        //Console.WriteLine($"Decimal  : {dec}\nBinary : {bin}");
                        //Console.WriteLine(bin.Substring(1, 1));
                        check = int.Parse(bin.Substring(1, 1));
                        checkBit5(check, dec);
                        //digit5[dec] = check;
                        continue;
                    }
                    //Console.WriteLine($"Decimal  : {dec}\nBinary : {bin}");
                    //Console.WriteLine(bin.Substring(0, 1));
                    check = int.Parse(bin.Substring(0, 1));
                    checkBit5(check, dec);

                }
            }
        }
            static void checkBit5(int bin, int dec)
            {
                if (bin == 1)
                {
                    Console.WriteLine($"Decimal  : {dec}  Binary : {bin}");
                }
            }
        }
    }
