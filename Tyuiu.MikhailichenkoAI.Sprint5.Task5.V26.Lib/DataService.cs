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
                    string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string str in numbers)
                    {
                        string cleanStr = str.Replace(',', '.').Trim();

                        if (cleanStr.Contains("."))
                        {
                            if (double.TryParse(cleanStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                            {
                                number = Math.Round(number, 3);

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
                }
            }

            double difference = sumPositive - sumNegative;

            return Math.Round(difference, 3);
        }
    }
}