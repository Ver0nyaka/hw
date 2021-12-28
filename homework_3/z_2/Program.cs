using System;

namespace z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phone = new string[5, 2];
            phone[0, 0] = "Златина Вероника";
            phone[1, 0] = "Исакова Даша";
            phone[2, 0] = "Григорьева Елизавета";
            phone[3, 0] = "Портнягина Арина";
            phone[4, 0] = "Скиба Вероника";
            phone[0, 1] = "89546273849";
            phone[1, 1] = "89251736402";
            phone[2, 1] = "89263910374";
            phone[3, 1] = "89451930472";
            phone[4, 1] = "89027293027";

            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 2; j++) 
                {
                    Console.Write($"{phone[i,j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
