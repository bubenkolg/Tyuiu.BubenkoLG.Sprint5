using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BubenkoLG.Sprint5.Task3.V15.Lib;

namespace Tyuiu.BubenkoLG.Sprint5.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл.                     ");
            Console.WriteLine("* Задание #3                                                               ");
            Console.WriteLine("* Вариант #15                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("*                            3       2                                     ");
            Console.WriteLine("* Дано выражение F(x) = -1.4x  + 2.3x  + 0.6x, вычислить его значение      ");
            Console.WriteLine("* при x = 5, результат сохранить в бинарный файл OutPutFileTask3.bin       ");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.            ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");

            Console.ReadKey();
        }
    }
}
