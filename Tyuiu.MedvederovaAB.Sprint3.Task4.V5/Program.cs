using Tyuiu.MedvederovaAB.Sprint3.Task4.V5.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах .    *");
            Console.WriteLine("* Задание #4                                                    *");
            Console.WriteLine("* Вариант #5                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу с использованием операторов continue и     *");
            Console.WriteLine("* break в цикле.                                                *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();

            int startvalue = -5;
            int stopvalue = 5;

            Console.WriteLine("Старт шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);


            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.Calculate(startvalue, stopvalue));
            Console.ReadKey();
            
        }
    }
}
