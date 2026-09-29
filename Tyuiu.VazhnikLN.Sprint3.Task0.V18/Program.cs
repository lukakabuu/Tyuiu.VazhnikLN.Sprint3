using System;
using Tyuiu.VazhnikLN.Sprint3.Task0.V18.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task0.V18

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 1;
            int k = 1;
            int z = 6;
            Console.WriteLine("Значение x = 1:");
            Console.WriteLine("Значение k = 1:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetMultiplySeries(x, k, z);
            Console.WriteLine("Значение произведений = " + res);
            

        }
    }
}