using System.IO;
using Tyuiu.MikhailichenkoAI.Sprint5.Task0.V4.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(2);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}