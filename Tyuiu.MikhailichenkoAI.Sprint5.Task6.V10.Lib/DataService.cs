using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MikhailichenkoAI.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Length == 4)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}