using System.IO;
using Tyuiu.MikhailichenkoAI.Sprint5.Task2.V30.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 3, -1, -3 }, { -2, -5, 0 }, { -8, -7, 2 } };
            string path = ds.SaveToFileTextData(matrix);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}