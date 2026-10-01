using System;
using Tyuiu.VazhnikLN.Sprint3.Task4.V1.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task4.V1

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x1, x2;
            x1 = -5;
            x2 = 5;
            Console.WriteLine($"Дан отрезок [{x1};{x2}]");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x1, x2);
            Console.WriteLine("Сумма значений выражений sin(x) / x до 0 = " + res);


        }
    }
}
