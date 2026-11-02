using System.IO;
using Tyuiu.MikhailichenkoAI.Sprint5.Task6.V10.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:", "DataSprint5", "InPutDataFileTask6V10.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}