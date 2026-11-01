using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt"); 
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            double y;
            string strY = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Cos(x) + x) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((2 * x + 6) / (Math.Cos(x) + x) - 3, 2);
                }

                strY += y.ToString();

                if (x != stopValue)
                {
                    strY += Environment.NewLine;
                }
            }

            File.WriteAllText(path, strY);
            return path;
        }
    }
}