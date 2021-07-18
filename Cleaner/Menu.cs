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
            
            Console.WriteLine("1 - Полная очистка кэша");
            Console.WriteLine("2 - Очистка кэша определённого браузера");
            Console.WriteLine("3 - Выход");
        }
        public void EnterError()
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Введены некорректные данные!! Пожалуйста повторите ввод.");
        }
    }
}