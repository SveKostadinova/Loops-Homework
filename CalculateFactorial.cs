using System;
using System.Numerics;

class CalculateFactorial
{
    static void Main()
    {
        Console.Write("Enter two numbers n and k - 1<k<n<100 \nn = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
       
                

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            if (i <= k)
            {
                kFactorial *= i;
            }
        }
        Console.WriteLine("n!/k! = {0}", nFactorial/kFactorial);
    }
}

//     Second way
//    static void Main()
//    {
//        Console.Write("Enter two numbers n and k - 1<k<n<100 \nn = ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("k = ");
//        int k = int.Parse(Console.ReadLine());

//        BigInteger divideTwoFactorials = 1;
       
//        for (int i = k + 1; i <= n; i++)
//        {
//            divideTwoFactorials *= i;
//        }
//        Console.WriteLine("n!/k! = {0}", divideTwoFactorials);
//    }











