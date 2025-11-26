using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BubenkoLG.Sprint5.Task1.V28.Lib;

namespace Tyuiu.BubenkoLG.Sprint5.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.                 ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #28                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дана функция                                                             ");
            Console.WriteLine("*          cos(x)                                                          ");
            Console.WriteLine("* F(x) = --------- - sin(x) * 12x + 2                                      ");
            Console.WriteLine("*         x - 0,7                                                          ");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1.  ");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть         ");
            Console.WriteLine("* вернуть значение 0. Результат сохранить в текстовый файл                 ");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль  в таблицу.    ");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                         ");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("* Начало шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");

            Console.ReadKey();
        }
    }
}
