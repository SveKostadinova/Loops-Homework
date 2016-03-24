using System;


class CalculateFactorial
{
    static void Main()
    {
        Console.Write("Enter two numbers n and k - 1<k<n<100 \nn = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int firstFactorials = 1;
        int kFactorials = 1;
        int count = 1;


        for (int i = n - k + 1; i <= n; i++)
        {
            firstFactorials *= i;
            if (count <= k)
            {
                kFactorials *= count;
                count++;
            }
        }
       
                Console.WriteLine("n!/(k!*(n-k)!) = {0}", firstFactorials/kFactorials);
    }
}

