using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Loader
    {
        /// <summary>
        /// Метод, реализующий скачивание исходного HTML страницы.
        /// </summary>
        /// <param name="url">Адрес сайта.</param>
        /// <param name="location">Путь для сохранения.</param>
        public static void GetStringHtml(string url, string location)
        {
            WebClient webClient = new WebClient();
            //webClient.Encoding = Encoding.UTF8;
            using (StreamWriter sw = new StreamWriter(location + "\\ourHTML.txt", false, Encoding.UTF8))
            {
                sw.WriteLine(webClient.DownloadString(url));
                sw.Close();
            }
        }

    }
}
