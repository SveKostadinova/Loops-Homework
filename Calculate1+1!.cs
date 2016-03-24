using System;

class Calculate
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        double result = 1;
        double nFactorial = 1;
        double xn = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            xn *= x;
            result += nFactorial / xn;
        }
        Console.WriteLine("{0:F5}", result);
    
    }
}
