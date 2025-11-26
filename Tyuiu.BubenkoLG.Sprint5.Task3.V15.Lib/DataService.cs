using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BubenkoLG.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            double f = -1.4 * x * x * x + 2.3 * x * x + 0.6 * x;
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(Math.Round(f, 3)));
            }
            return path;
        }
    }
}