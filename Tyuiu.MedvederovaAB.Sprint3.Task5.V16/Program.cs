using Tyuiu.MedvederovaAB.Sprint3.Task5.V16.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Использование вложенных циклов.                         *");
            Console.WriteLine("* Задание #5                                                    *");
            Console.WriteLine("* Вариант #16                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда с            *");
            Console.WriteLine("* использованием вложенных циклов.                              *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();
            int x = 2;
            int startvalue1 = 1;
            int stopvalue1 = 3;
            int startvalue2 = 1;
            int stopvalue2 = 10;

            Console.WriteLine("Переменная Х = " +  x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startvalue1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopvalue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startvalue2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopvalue2);


            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startvalue1, stopvalue1, startvalue2, stopvalue2));
            Console.ReadKey();

        }
    }
}
