using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BubenkoLG.Sprint5.Task6.V27.Lib;

namespace Tyuiu.BubenkoLG.Sprint5.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: обработка текстовых файлов.                                        ");
            Console.WriteLine("* Задание #5                                                               ");
            Console.WriteLine("* Вариант #5                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан файл InPutDataFileTask6V27.txt, в котором есть набор символьных      ");
            Console.WriteLine("* данных. Найти количество трехзначных чисел в заданной строке.            ");

            string path = $@"{Path.GetTempPath()}\InPutDataFileTask5V5.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}