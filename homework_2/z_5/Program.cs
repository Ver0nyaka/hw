using System;

namespace z_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название месяца:");
            string month = Console.ReadLine();
            Console.WriteLine("Введите среднюю температуру:");
            int temp = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (((month == "Декабрь") || (month == "Январь") || (month == "Февраль")) && (temp > 0))
                {
                    Console.WriteLine("Дождливая зима");
                }
                else Console.WriteLine("Не могу выполнить данную задачу");
            }
        }
    }
}
