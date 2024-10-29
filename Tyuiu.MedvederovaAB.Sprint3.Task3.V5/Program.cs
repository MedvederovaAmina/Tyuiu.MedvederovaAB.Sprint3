using Tyuiu.MedvederovaAB.Sprint3.Task3.V5.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3   |  Выполнила: Медведерова А. Б.   |  ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Оператор цикла foreach.                                 *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #5                                                    *");
            Console.WriteLine("* Выполнила: Медведерова Амина Борисовна | ПКТб-24-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* Написать программу с использованием цикла foreach, которая    *");
            Console.WriteLine("* заменяет буквы а на * в строке: fifa al fall.                 *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*****************************************************************");

            DataService ds = new DataService();

            string value = " fifa al fall ";
            char replaceable = 'a';
            char replacement = '*';


            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Символ, который нужно заменить = " + replaceable);
            Console.WriteLine("Символ, на который нужно заменить = " + replacement);


            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Полученная строка = " + ds.ReplaceCharInString(value, replaceable, replacement));
            Console.ReadKey();
        }
    }
    
}
