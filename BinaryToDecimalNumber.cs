using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary integer number: ");
        string input = Console.ReadLine();
        long number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '1')
            {
                double power = input.Length - 1 - i;
                number = number + (long)Math.Pow(2, power);
            }
        }
        Console.WriteLine("Decimal form: {0}", number);
    }
}

