using System;

namespace z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"Число {a} - чётное");
            }
            else
            {
                Console.WriteLine($"Число {a} - нечётное");
            }
        }
    }
}
