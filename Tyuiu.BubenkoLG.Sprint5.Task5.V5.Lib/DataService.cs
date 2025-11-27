using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Runtime.InteropServices;

namespace Tyuiu.BubenkoLG.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            using StreamReader reader = new(path);
            string strX = reader.ReadToEnd();
            
            string[] strM = strX.Split(' ');
            for (int i = 0; i < strM.Length; i++)
            {
                if (strM[i].Contains("."))
                {
                    strM[i] = strM[i].Replace(".", ",");
                }
            }
            double[] mtrx = new double[strM.Length];
            for (int i = 0; i < strM.Length; i++)
            {
                mtrx[i] = Convert.ToDouble(strM[i]);

            }
            double n = Math.Round(mtrx.Max() - mtrx.Min(),3);
            return n;
        }
    }
}