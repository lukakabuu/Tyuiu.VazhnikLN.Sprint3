using System;
using Tyuiu.VazhnikLN.Sprint3.Task6.V3.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task6.V3

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int start = 13;
            int end = 19;
            Console.WriteLine($"Отрезок [{start};{end}]");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumTheDivisors(start, end);
            Console.WriteLine("Сумма делителей больше 8 = " + res);


        }
    }
}
