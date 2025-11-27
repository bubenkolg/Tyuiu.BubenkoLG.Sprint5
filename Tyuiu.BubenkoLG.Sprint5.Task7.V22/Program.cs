using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BubenkoLG.Sprint5.Task7.V22.Lib;

namespace Tyuiu.BubenkoLG.Sprint5.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                 ");
            Console.WriteLine("* Задание #7                                                               ");
            Console.WriteLine("* Вариант #22                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан файл InPutDataFileTask6V27.txt, в котором есть набор символьных      ");
            Console.WriteLine("* данных. Заменить все знаки препинания на #. Полученный результат         ");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V22.txt.                             ");

            string path1 = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task7.V22\bin\Debug\net8.0\InPutDataFileTask7V22.txt";
            string path2 = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task7.V22\bin\Debug\net8.0\OutPutDataFileTask7V22.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Данные находятся в файле: " + path1);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path1);

            Console.WriteLine(" Данные записаны в файл: " + res);

            using StreamReader reader = new(res);
            string strX = reader.ReadToEnd();

            Console.WriteLine("Данные: " + strX);

            Console.ReadKey();
        }
    }
}