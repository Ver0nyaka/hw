using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Среднесуточная температура: {(min+max)/2} ");
            Console.ReadLine();
        }
    }
}
