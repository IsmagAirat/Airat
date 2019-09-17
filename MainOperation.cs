using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class MainOperation
    {
        /// <summary>
        /// Метод, вызывающий другие методы для реализации поиска 20-ти значений тега href и 
        /// вывода их на косоль и в текстовый документ.
        /// </summary>
        /// <param name="location"></param>
        public static void WhatToDo(string location)
        {
            Location.CheckFiles(location);

            Console.WriteLine("\nВведите адрес сайта:");
            string site = Console.ReadLine();

            try
            {
                Loader.GetStringHtml(site, location);
                FileWork.DoResult(location, FileWork.GetStringList(location));
                Console.WriteLine("Всё готово!");
            }

            catch (System.Net.WebException)
            {
                Console.WriteLine("Ошибка в адресе сайта.");
            }
        }
    }
}
