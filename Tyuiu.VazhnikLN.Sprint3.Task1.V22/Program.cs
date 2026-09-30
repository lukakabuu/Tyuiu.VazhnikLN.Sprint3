using System;
using Tyuiu.VazhnikLN.Sprint3.Task1.V22.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task1.V22

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double a = 1.5;
            int k = 1;
            int z = 20;
            Console.WriteLine("Значение a = 1,5:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSeries(a, k, z);
            Console.WriteLine("Значение ряда = " + res);


        }
    }
}
