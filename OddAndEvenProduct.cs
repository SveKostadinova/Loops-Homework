using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter n integers in a single line, separated by a space:");
     

        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int even = 1;
        int odd = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);

            if (i % 2 == 0)
            {
                odd *= number;
            }
            else
            {
                even *= number;
            }
        }

        if (even == odd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + even);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + odd);
            Console.WriteLine("even_product = " + even);
        }
    }
}

