using System;

namespace Bingo75GenerateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] m = BingoCard.GetCard();
            for (int i = 0; i < 24; i++)
            {
                Console.Write(m[i]);
                Console.Write(" ");
            }
        }
    }
}
