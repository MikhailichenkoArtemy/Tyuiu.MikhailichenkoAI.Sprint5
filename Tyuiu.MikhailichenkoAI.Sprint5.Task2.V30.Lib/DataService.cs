
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MikhailichenkoAI.Sprint5.Task2.V30.Lib
{
    public class DataService : ISprint5Task2V30
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv"); FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                    str += matrix[i, j].ToString();

                    if (j != columns - 1)
                    {
                        str += ";";
                    }
                }

                if (i != rows - 1)
                {
                    str += Environment.NewLine;
                }
            }

            File.WriteAllText(path, str);
            return path;
        }
    }
}