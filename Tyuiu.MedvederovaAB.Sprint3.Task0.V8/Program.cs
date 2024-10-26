using Tyuiu.MedvederovaAB.Sprint3.Task0.V8.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла for.                                     *");
            Console.WriteLine("* Задание #0                                                    *");
            Console.WriteLine("* Вариант #8                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу с использованием цикла for, которая        *");
            Console.WriteLine("* вычисляет произведение ряда по формуле, при а = 0,25.         *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");
            DataService ds = new DataService();
            double value = 0.25;
            int startvalue = 1;
            int stopvalue = 10;

            Console.WriteLine("Переменная А = " + value);
            Console.WriteLine("Старт шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startvalue, stopvalue));
            Console.ReadKey();
        }
    }
}
