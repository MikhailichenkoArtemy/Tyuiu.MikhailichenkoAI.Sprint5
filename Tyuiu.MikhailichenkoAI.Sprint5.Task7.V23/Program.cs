
using System.IO;
using Tyuiu.MikhailichenkoAI.Sprint5.Task7.V23.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint5.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Михайличенко А. И. | ИИПБ26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Михайличенко Артем Иванович | ИИПБ26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V23.txt. Удалить все        *");
            Console.WriteLine("* русские слова из файла. Полученный результат сохранить в OutPutFile.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:", "DataSprint5", "InPutDataFileTask7V23.txt");
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат сохранен в файл:");

            string pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSave);
            Console.ReadKey();
        }
    }
}