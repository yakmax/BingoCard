using System;

namespace Bingo75GenerateNumbers
{
    class BingoCard
    {
        static int[] rndnum = { 0, 0, 0, 0, 0 };
        static string[] newbingostring = new string[24];

        public static string[] GetCard()
        {
            String str = "BINGO";
            int k = 0;
            int[] b;
            for (int j = 0; j < 5; j++)
            {
                b = BingoCard.GetFive();
                for (int i = 0; i < 5; i++)
                {
                    if (5 * j + i == 12)
                    {
                        k = 1;
                        continue;
                    }
                    newbingostring[5 * j + i - k] = str[j] + Convert.ToString(b[i] + 15 * j);
                }
            }
            return newbingostring;
        }

        public static int[] GetFive()
        {
            Random rng = new Random();
            for (int i = 0; i < 5; i++)
            {
                rndnum[i] = rng.Next(1, 16);
                if (i == 0) continue;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (rndnum[i] == rndnum[j]) rndnum[i] = rng.Next(1, 16);
                }
            }
            return rndnum;
        }

    }
}
