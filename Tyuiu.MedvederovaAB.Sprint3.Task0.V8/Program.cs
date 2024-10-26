using Tyuiu.MedvederovaAB.Sprint3.Task0.V8.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            double value = 0.25;
            int startvalue = 1;
            int stopvalue = 10;
            Console.WriteLine("Переменная А = " + value);
            Console.WriteLine("Старт шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);
            Console.WriteLine("Результат = " + ds.GetMultiplySeries(value, startvalue, stopvalue));
        }
    }
}
