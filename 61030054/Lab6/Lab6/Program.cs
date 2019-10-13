using System;
namespace testspa
{ 

class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            UseParams(2, 1, 3, 4, 5, 7, 14, 21,);

        }

        private static void UseParams(int[] listParams )
        {
            for (int i = 0; i <= list.Length; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(list[i] + "")
                }
            }
            Console.ReadLine();

        }
    }
}































