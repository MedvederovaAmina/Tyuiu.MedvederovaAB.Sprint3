using Tyuiu.MedvederovaAB.Sprint3.Task1.V30.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла while.                                   *");
            Console.WriteLine("* Задание #1                                                    *");
            Console.WriteLine("* Вариант #30                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу с использованием цикла while, которая      *");
            Console.WriteLine("* вычисляет произведение ряда по формуле, при t = 0,5.         *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");
            DataService ds = new DataService();
            double value = 0.5;
            int startvalue = 1;
            int stopvalue = 12;

            Console.WriteLine("Переменная T = " + value);
            Console.WriteLine("Старт шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);


            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startvalue, stopvalue));
            Console.ReadKey();
        }
    }
}
