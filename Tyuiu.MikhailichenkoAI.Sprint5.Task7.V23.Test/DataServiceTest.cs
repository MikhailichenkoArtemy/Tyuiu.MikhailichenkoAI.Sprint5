using System.IO;
using Tyuiu.MikhailichenkoAI.Sprint5.Task7.V23.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:", "DataSprint5", "InPutDataFileTask7V23.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}