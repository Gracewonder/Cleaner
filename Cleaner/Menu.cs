using System;

namespace Cleaner
{
    public class Menu
    {
        public void EnterGreeting()
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("*******************************");
            Console.WriteLine("****** Добро пожаловать! ******");
            Console.WriteLine("*******************************");
        }
        public void EnterChoice()
        {
            Console.ForegroundColor=ConsoleColor.Green;

            int choice;
            Console.WriteLine("1 - Полная очистка кэша");
            Console.WriteLine("2 - Очистка кэша определённого браузера");
            Console.WriteLine("3 - Выход");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3 :
                    break;
                default:
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод! Выберите заново!");
                    break;
            }
        }
        public void EnterError()
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Введены некорректные данные!! Пожалуйста повторите ввод.");
        }
    }
}