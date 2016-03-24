using System;

class PrintCards
{
    static void Main()
    {
        
        for (int card = 2; card < 15; card++)
        {
            for (int suit = 1; suit < 5; suit++)
            {
                switch (card)
                {
                    case 2: Console.Write("2"); break;
                    case 3: Console.Write("3"); break;
                    case 4: Console.Write("4"); break;
                    case 5: Console.Write("5"); break;
                    case 6: Console.Write("6"); break;
                    case 7: Console.Write("7"); break;
                    case 8: Console.Write("8"); break;
                    case 9: Console.Write("9"); break;
                    case 10: Console.Write("10"); break;
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;
                }
                switch (suit)
                {
                    case 1: Console.Write('\u2663'); break;
                    case 2: Console.Write('\u2666'); break;
                    case 3: Console.Write('\u2665'); break;
                    case 4: Console.Write('\u2660'); break;
                }
                
            }
            Console.WriteLine("\n");
        }
    
    }
}

