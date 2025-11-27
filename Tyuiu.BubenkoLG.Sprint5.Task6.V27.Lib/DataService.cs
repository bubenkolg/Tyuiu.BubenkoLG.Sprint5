using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Runtime.InteropServices;

namespace Tyuiu.BubenkoLG.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            using StreamReader reader = new(path);
            string strX = reader.ReadToEnd();
            string[] strM = strX.Split(' ');
            int count = 0;
            for (int i = 0; i < strM.Length; i++)
            {
                if ((strM[i].Contains('0') || strM[i].Contains('1') || strM[i].Contains('2') || strM[i].Contains('3') || strM[i].Contains('4') || strM[i].Contains('5') || strM[i].Contains('6') || strM[i].Contains('7') || strM[i].Contains('8') || strM[i].Contains('9')) && (strM[i].Length == 3))
                {
                    count++;
                }
            }
            return count;
        }
    }
}