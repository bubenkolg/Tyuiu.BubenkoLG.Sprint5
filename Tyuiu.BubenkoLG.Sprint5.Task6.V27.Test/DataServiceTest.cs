using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint5.Task6.V27.Lib;
using System.IO;

namespace Tyuiu.BubenkoLG.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint5\Tyuiu.BubenkoLG.Sprint5.Task6.V27\bin\Debug\net8.0\InPutDataFileTask6V27.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}