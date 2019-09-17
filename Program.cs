using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        static void Main()
        {
            string location = "C:\\TestTask1";

            Console.WriteLine("Тестовое задание №1. Исмагилов Айрат.");
            Console.WriteLine("Для выхода из приложения нажмите Q.");
            Console.WriteLine("Все файлы будут сохраняться по пути \"C:\\TestTask1\\\".");
            Console.WriteLine("Для продолжения работы нажмите Y. Для изменения пути нажмите C.");
            Console.WriteLine("------------------------------------------------------------------------------");

            ConsoleKeyInfo whatToDo;
            whatToDo = Console.ReadKey();

           
            while (whatToDo.Key != ConsoleKey.Q)
            {
                switch (whatToDo.Key)
                {
                    case ConsoleKey.Y:
                        MainOperation.WhatToDo(location);
                        break;

                    case ConsoleKey.C:
                        location = Location.ChangeLocation(location);
                        Console.WriteLine($"Текущий путь к файлам {location}.");
                        break;

                    default:
                        Console.WriteLine("\nПри нажатии на эту клавишу ничего не происходит, попробуйте ещё раз.");
                        break;
                }
                Console.WriteLine("------------------------------------------------------------------------------");
                //Console.WriteLine($"\nВсе файлы будут сохраняться по пути { location}");
                //Console.WriteLine("Для изменения пути нажмите C.\nДля продолжения работы нажмите Y.");
                Console.WriteLine($"Что дальше делаем?{Environment.NewLine}");
                whatToDo = Console.ReadKey();
            }

        }

    }
}
