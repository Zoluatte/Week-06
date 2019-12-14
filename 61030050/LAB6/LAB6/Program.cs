using System;

class Program
{
    static void Main(string[] args)
    {
        UseParams(1, 2, 3, 4, 5, 7, 14, 21); 
    }

    static void UseParams(params int[] list)
    {
        for (int i = 0; i <= list.Length; i++)
        {
            if (i % 7 == 0)
            {
                Console.Write(list[i] + "");
            }

        }
        Console.ReadLine();
    }
}