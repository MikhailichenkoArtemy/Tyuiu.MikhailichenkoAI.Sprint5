
using System.IO;
using Tyuiu.MikhailichenkoAI.Sprint5.Task5.V26.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint5.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V26.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}