using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint5.Task7.V22.Lib;
using System.IO;

namespace Tyuiu.BubenkoLG.Sprint5.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile1()
        {
            string path1 = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task7.V22\bin\Debug\net8.0\InPutDataFileTask7V22.txt";
            FileInfo fileInfo1 = new FileInfo(path1);
            bool fileExists1 = fileInfo1.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists1);

        }
        public void CheckedExistsFile2()
        {
            string path2 = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task7.V22\bin\Debug\net8.0\OutPutDataFileTask7V22.txt";
            FileInfo fileInfo2 = new FileInfo(path2);
            bool fileExists2 = fileInfo2.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists2);

        }

    }
}
