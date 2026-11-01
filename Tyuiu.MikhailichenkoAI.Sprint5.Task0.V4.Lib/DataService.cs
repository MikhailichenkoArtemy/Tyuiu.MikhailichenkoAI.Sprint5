using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task0.V4.Lib
{
    public class DataService : ISprint5Task0V4
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = 2 * Math.Pow(x, 3) + 0.5 * Math.Pow(x, 2) - 3.5 * x + 2; 
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}