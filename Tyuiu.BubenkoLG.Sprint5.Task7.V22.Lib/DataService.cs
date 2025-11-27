using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Runtime.InteropServices;

namespace Tyuiu.BubenkoLG.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string path2 = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task7.V22\bin\Debug\net8.0\OutPutDataFileTask7V22.txt";
            FileInfo fileInfo = new FileInfo(path2);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path2);
            }

            using StreamReader reader = new(path);
            string strX = reader.ReadToEnd();
            
            strX = strX.Replace(".", "#");
            strX = strX.Replace(",", "#");
            strX = strX.Replace("!", "#");
            strX = strX.Replace("-", "#");
            strX = strX.Replace("?", "#");

            File.AppendAllText(path2, strX);

            return path2;
        }
    }
}
