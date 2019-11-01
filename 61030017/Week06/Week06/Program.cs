using System;

class Program
{
    static void Main()
    {
        float weight;
        Console.WriteLine("Input your weight");
        weight = float.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on moon is : {0:F1}",calculate(ref weight));
    }

    static float calculate(ref float weight)
    {
        weight /= 10;
        weight *= 1.6f;
        return weight;
    }
}