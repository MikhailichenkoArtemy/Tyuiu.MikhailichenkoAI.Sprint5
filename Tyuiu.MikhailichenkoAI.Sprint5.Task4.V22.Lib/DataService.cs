using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX.Replace('.', ','));
            double res = Math.Round(Math.Pow(x, 3) * Math.Sin(x) - 4 * x, 3);
            return res;
        }
    }
}