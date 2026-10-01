using System;
using Tyuiu.VazhnikLN.Sprint3.Task5.V11.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task5.V11

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startvalue1 = 1;
            int startvalue2= 1;
            int stopvalue1 = 3;
            int stopvalue2 = 10;
            int x = 5;
            Console.WriteLine("Старт шага суммы 1-го ряда = " + startvalue1);
            Console.WriteLine("Старт шага суммы 1-го ряда = " + startvalue2);
            Console.WriteLine("Конец шага суммы 1-го ряда = " + stopvalue1);
            Console.WriteLine("Старт шага суммы 1-го ряда = " + stopvalue2);
            Console.WriteLine("Значение x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSumSeries(x, startvalue1, startvalue2, stopvalue1, stopvalue2);
            Console.WriteLine("Сумма ряда = " + res);


        }
    }
}