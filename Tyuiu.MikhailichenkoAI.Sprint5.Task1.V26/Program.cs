
using System.IO;
using Tyuiu.MikhailichenkoAI.Sprint5.Task1.V26.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint5.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); int startValue = -5; int stopValue = 5;
            Console.Title = "Спринт #5 | Выполнил: Михайличенко А. И. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Михайличенко Артемий Игоревич | ИИПб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (2x + 6) / (cos(x) + x) - 3.                        *");
            Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.  *");
            Console.WriteLine("* Результат сохранить в текстовый файл и вывести на консоль в таблицу.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            string[] valueArray = File.ReadAllLines(res);
            int x = startValue;

            foreach (string value in valueArray)
            {
                Console.WriteLine($"| {x,8} | {value,8} |");
                x++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}