using System;

class Summertime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int widthBottom = 2 * n;
        int widthTop = n + 1;
        int height = 3 * n + 1;

        Console.WriteLine("{0}{1}{0}",
            new String(' ', n/2),
            new String('*', widthTop));

        for (int i = 0; i < (n - 1)/2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
            new String(' ', n / 2),
            '*',
            new String(' ', n - 1));
        }

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
            new String(' ', ((n / 2) - i)),
            '*',
            new String(' ', (n - 1 + 2*i)));

        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                '*',
                new String('.', widthBottom - 2));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                '*',
                new String('@', widthBottom - 2));
        }
        

        Console.WriteLine(new String ('*', widthBottom));
    }
}

