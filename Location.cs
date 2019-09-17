using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Location
    {
        /// <summary>
        /// Метод, реализующий смену директории для сохранения файлов.
        /// </summary>
        /// <param name="oldlocation">Старый путь для сохранения файлов.</param>
        /// <returns></returns>
        public static string ChangeLocation(string oldlocation)
        {
            Console.WriteLine("\nВведите полный путь для сохранения.\nДля отмены введите \"cancel\" (без кавычек).");
            string newlocation = Console.ReadLine();
            if (newlocation.Equals("cancel"))
            {
                return oldlocation;
            }

            //CheckFiles(newlocation);
            if (newlocation[1] != ':')
            {
                Console.WriteLine($"Смотрите в папке Debug.");
                return $"{Environment.CurrentDirectory}\\{newlocation}";
            }
            else
            {
                return newlocation;
            }
        }
        
        /// <summary>
        /// Метод, реализующий создание необходимых файлов и папки, если их не существует.
        /// </summary>
        /// <param name="location">Путь для сохранения файлов</param>
        public static void CheckFiles(string location)
        {
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            if (!File.Exists(location + "\\ourHTML.txt"))
            {
                using (File.Create(location + "\\ourHTML.txt")) { };
            }

            if (!File.Exists(location + "\\result.txt"))
            {
                using (File.Create(location + "\\result.txt")) { };
            }
        }
    }

}
