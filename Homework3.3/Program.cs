using System;

namespace Homework3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Chet = true;
            int i = 2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Проверим ваше число, простое ли оно!");
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());
            while (i <= number / 2)
            {
                if (number % i == 0)
                {
                    Chet = false;
                    break;
                }
                i++;
            }
            if (Chet == true)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();

        }
    }
}