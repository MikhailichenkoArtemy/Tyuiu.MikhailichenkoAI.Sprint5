using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MikhailichenkoAI.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double sumPositive = 0; double sumNegative = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string cleanLine = line.Replace(',', '.').Trim();

                    if (double.TryParse(cleanLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        if (number > 0)
                        {
                            sumPositive += number;
                        }
                        else if (number < 0)
                        {
                            sumNegative += number;
                        }
                    }
                }
            }

            double difference = sumPositive - sumNegative;

            return Math.Round(difference, 3);
        }
    }
}