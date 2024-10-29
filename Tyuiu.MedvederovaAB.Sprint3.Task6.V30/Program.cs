using Tyuiu.MedvederovaAB.Sprint3.Task6.V30.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Обработка целочисленной информации.                     *");
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #30                                                   *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу, которая ищет среди чисел, принадлежащих   *");
            Console.WriteLine("* отрезку [11,17] количество делителей.                         *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();
            
            int startvalue = 11;
            int stopvalue = 17;
            

            
            Console.WriteLine("Старт шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);
            


            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Колличество делителей = " + ds.GetSumTheDivisors(startvalue, stopvalue));
            Console.ReadKey();
        }
    }
}
