using System;

class Program
{
    static void Main()

    {
        int number;

        Console.WriteLine("Enter Interger Number : ");

        number = int.Parse(Console.ReadLine());
        Banana(number);

        Console.ReadLine();

    }

    static void Banana(int number)
    {
        if ((number % 2) == 0)
        {

            Console.WriteLine("{0} Is Even", number);
        }
        else
        {
            Console.WriteLine("{0} Is Odd", number);
        }
    }
}
