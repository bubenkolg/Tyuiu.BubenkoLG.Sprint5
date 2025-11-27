using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BubenkoLG.Sprint5.Task5.V5.Lib;

namespace Tyuiu.BubenkoLG.Sprint5.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла.                          ");
            Console.WriteLine("* Задание #5                                                               ");
            Console.WriteLine("* Вариант #5                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V5.txt, в котором есть       ");
            Console.WriteLine("* набор значений. Найти разницу между максимальным и минимальным целыми    ");
            Console.WriteLine("* числами в файле. Полученный результат вывести на консоль.                ");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.          ");
            //string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task5.V5\bin\Debug\net8.0\InPutDataFileTask5V5.txt";

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