using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint5.Task5.V5.Lib;
using System.IO;

namespace Tyuiu.BubenkoLG.Sprint5.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task5.V5\bin\Debug\net8.0\InPutDataFileTask5V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}