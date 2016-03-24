using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNumber = randomGenerator.Next(min, max + 1);
            Console.Write("{0} ", randomNumber);
        }
    }
}

