using Tyuiu.MedvederovaAB.Sprint3.Task2.V19.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла do-while.                                *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #19                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу с использованием цикла do - while, которая *");
            Console.WriteLine("* вычисляет сумма ряда по формуле.                              *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();
            
            int startvalue = 1;
            int stopvalue = 10;

            Console.WriteLine("Старт шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);


            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startvalue, stopvalue));
            Console.ReadKey();
        }
    }
    
}
