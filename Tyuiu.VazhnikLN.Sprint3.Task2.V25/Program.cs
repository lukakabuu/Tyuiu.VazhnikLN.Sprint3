using System;
using Tyuiu.VazhnikLN.Sprint3.Task2.V25.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task2.V25

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int n = 5;
            int k = 1;
            int z = 13;
            Console.WriteLine("Значение n = 5:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSeries(n, k, z);
            Console.WriteLine("Значение ряда = " + res);


        }
    }
}
