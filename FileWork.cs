using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask
{
    class FileWork
    {
        /// <summary>
        /// Метод, реализующий чтение HTML в виде txt-документа по указанному пути, и вывод результатов в консоль.
        /// </summary>
        /// <param name="location">Путь для сохранения.</param>
        /// <returns></returns>
        public static string GetStringList(string location)
        {
            StreamReader sr = new StreamReader(location + "\\ourHTML.txt");
            string alltext = sr.ReadToEnd();
            var matches = Regex.Matches(alltext, "<a.+?href=\"(.+?)\"");
            string result = $"{Environment.NewLine}{Environment.NewLine}Результаты:{Environment.NewLine}";
            

            if (matches.Count < 20)
            {
                result += CreateHrefs(matches.Count, matches);
            }
            else
            {
                result += CreateHrefs(20, matches);
            }

            Console.WriteLine(Environment.NewLine + result);
            sr.Close();
            return result;
        }

        /// <summary>
        /// Метод, реализующий сохранение результата в текстовый документ по указанному пути.
        /// </summary>
        /// <param name="location">Путь для сохранения.</param>
        /// <param name="text">Все полученные ссылки.</param>
        public static void DoResult(string location, string text)
        {
            StreamWriter sw = new StreamWriter(location + "\\result.txt", false);
            sw.Write(text);
            sw.Close();
        }
        
        /// <summary>
        /// Метод, реализующий поиск ссылок в атрибутах href.
        /// </summary>
        /// <param name="maxcount">Количество тегов а с атрибутом href</param>
        /// <param name="match">Коллекция тегов а</param>
        /// <returns></returns>
        public static string CreateHrefs (int maxcount, MatchCollection match)
        {
            int count = 0;
            string result = "";

            while (count < maxcount)
            {
                for (int i = 0; i < match[count].Value.Length - 4; i++)
                {
                    if (match[count].Value.Substring(i, 4) == "href")
                    {
                        i += 6;
                        string buff = "";

                        while (match[count].Value.Substring(i, 1) != @"""")
                        {
                            buff += match[count].Value.Substring(i, 1);
                            i++;
                        }
                        result += $"{count + 1}. {buff} {Environment.NewLine}";
                    }
                }
                count++;
            }
            return result;
        }
    }
}
