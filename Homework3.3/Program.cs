using System;

namespace Homework3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Chet = true;
            int number;
            int i = 2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Проверим ваше число, простое ли оно!");
            do
            {
                Console.WriteLine("Введите число:");
                number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("Число ниже или равно нулю!\n");
                }
            } while (number <= 0);
            
            
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