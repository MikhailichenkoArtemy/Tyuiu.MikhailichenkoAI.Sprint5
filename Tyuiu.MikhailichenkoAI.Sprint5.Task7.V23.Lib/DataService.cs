using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MikhailichenkoAI.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V23.txt"); FileInfo fileInfo = new FileInfo(pathSave); if (fileInfo.Exists) { fileInfo.Delete(); }
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                str = reader.ReadToEnd();
            }

            string res = Regex.Replace(str, "[а-яА-ЯёЁ]+", "");
            res = res.Replace(" .", ".").Replace(" ,", ",").Replace("  ", " ");

            using (StreamWriter writer = new StreamWriter(pathSave, false))
            {
                writer.Write(res);
            }

            return pathSave;
        }
    }
}