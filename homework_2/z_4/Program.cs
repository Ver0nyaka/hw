using System;

namespace z_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int potato = 70;
            int mayonnaise = 68;
            int chocolate = 43;
            int sum = potato + mayonnaise * 2 + chocolate * 5;
            Console.WriteLine("      Кассовый чек      ");
            Console.WriteLine("    Кассир: Макиенко    ");
            Console.WriteLine($"Картошка     {potato}*1");
            Console.WriteLine($"Стоимость........{potato}");
            Console.WriteLine($"Майонез      {mayonnaise}*2");
            Console.WriteLine($"Стоимость.......{mayonnaise * 2}");
            Console.WriteLine($"Шоколад      {chocolate}*5");
            Console.WriteLine($"Стоимость.......{chocolate*5}");
            Console.WriteLine("__________________");
            Console.WriteLine($"{DateTime.Now}         ");
            Console.WriteLine($"Итог............{sum} руб.");
        }
    }
}
