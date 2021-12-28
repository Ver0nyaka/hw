using System;

namespace z_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] fight = new char[10, 10];
            fight[0, 0] = 'O'; fight[0, 1] = 'O'; fight[0, 2] = 'O'; fight[0, 3] = 'O'; fight[0, 4] = 'O'; fight[0, 5] = 'X'; fight[0, 6] = 'O'; fight[0, 7] = 'O'; fight[0, 8] = 'O'; fight[0, 9] = 'O';
            fight[1, 0] = 'X'; fight[1, 1] = 'O'; fight[1, 2] = 'O'; fight[1, 3] = 'O'; fight[1, 4] = 'O'; fight[1, 5] = 'X'; fight[1, 6] = 'O'; fight[1, 7] = 'O'; fight[1, 8] = 'O'; fight[1, 9] = 'O';
            fight[2, 0] = 'O'; fight[2, 1] = 'O'; fight[2, 2] = 'O'; fight[2, 3] = 'O'; fight[2, 4] = 'O'; fight[2, 5] = 'O'; fight[2, 6] = 'O'; fight[2, 7] = 'O'; fight[2, 8] = 'O'; fight[2, 9] = 'O';
            fight[3, 0] = 'O'; fight[3, 1] = 'X'; fight[3, 2] = 'X'; fight[3, 3] = 'X'; fight[3, 4] = 'O'; fight[3, 5] = 'O'; fight[3, 6] = 'O'; fight[3, 7] = 'O'; fight[3, 8] = 'X'; fight[3, 9] = 'X';
            fight[4, 0] = 'O'; fight[4, 1] = 'O'; fight[4, 2] = 'O'; fight[4, 3] = 'O'; fight[4, 4] = 'X'; fight[4, 5] = 'O'; fight[4, 6] = 'O'; fight[4, 7] = 'O'; fight[4, 8] = 'O'; fight[4, 9] = 'X';
            fight[5, 0] = 'O'; fight[5, 1] = 'O'; fight[5, 2] = 'O'; fight[5, 3] = 'O'; fight[5, 4] = 'X'; fight[5, 5] = 'O'; fight[5, 6] = 'O'; fight[5, 7] = 'O'; fight[5, 8] = 'O'; fight[5, 9] = 'X';
            fight[6, 0] = 'O'; fight[6, 1] = 'O'; fight[6, 2] = 'O'; fight[6, 3] = 'O'; fight[6, 4] = 'X'; fight[6, 5] = 'O'; fight[6, 6] = 'O'; fight[6, 7] = 'O'; fight[6, 8] = 'O'; fight[6, 9] = 'O';
            fight[7, 0] = 'X'; fight[7, 1] = 'O'; fight[7, 2] = 'O'; fight[7, 3] = 'O'; fight[7, 4] = 'X'; fight[7, 5] = 'X'; fight[7, 6] = 'X'; fight[7, 7] = 'X'; fight[7, 8] = 'O'; fight[7, 9] = 'O';
            fight[8, 0] = 'X'; fight[8, 1] = 'O'; fight[8, 2] = 'X'; fight[8, 3] = 'O'; fight[8, 4] = 'O'; fight[8, 5] = 'O'; fight[8, 6] = 'O'; fight[8, 7] = 'O'; fight[8, 8] = 'O'; fight[8, 9] = 'O';
            fight[9, 0] = 'X'; fight[9, 1] = 'O'; fight[9, 2] = 'X'; fight[9, 3] = 'O'; fight[9, 4] = 'O'; fight[9, 5] = 'O'; fight[9, 6] = 'O'; fight[9, 7] = 'O'; fight[9, 8] = 'O'; fight[9, 9] = 'O';

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{fight[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
