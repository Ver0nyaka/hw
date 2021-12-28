using System;

namespace z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string hello = Console.ReadLine();
            char[] olleh = hello.ToCharArray();
            int last = olleh.Length - 1;
            for (int i = last; i >= 0; i--)
            {
                Console.Write(olleh[i]);
            }



        }
    }
}
