using System;

namespace homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matr = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            Console.WriteLine($"{matr[0, 0]}");
            Console.WriteLine($" {matr[0, 1]}");
            Console.WriteLine($"  {matr[1, 0]}");
            Console.WriteLine($"   {matr[1, 1]}");

        }
    }
}
