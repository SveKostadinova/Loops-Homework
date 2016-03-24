using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 100)
        {
            BigInteger nnFactorials = 1;
            BigInteger nFactorials = 1;
            BigInteger n1Factorials = 1;

            for (int i = 1; i <= 2*n; i++)
            {
                nnFactorials *= i;
            }

            for (int j = 1; j <= n; j++)
            {
                nFactorials *= j;
            }

            for (int k = 1; k <= n + 1; k++)
            {
                n1Factorials *= k;
            }
            


            Console.WriteLine("Catalan(n) = {0}", nnFactorials/(nFactorials*n1Factorials));
            
        }
        else
        {
            Console.WriteLine("n is out of range");
        }
        
    }
}

