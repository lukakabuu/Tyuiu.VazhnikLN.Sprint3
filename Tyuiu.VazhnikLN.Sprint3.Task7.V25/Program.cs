using System;
using Tyuiu.VazhnikLN.Sprint3.Task7.V25.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task7.V25

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int start = -5;
            int end = 5;
            int i = 0;
            int z = -5;
            double[] res = ds.GetMassFunction(start, end);
            Console.WriteLine($"Отрезок [{start};{end}]");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" x    F(x)");
            for (i = 0; i < (res.Length - 1); i++)
            {
                if (z < 0)
                {
                    Console.WriteLine(z + " | " + res[i]);
                    z++;
                }
                else
                {
                    Console.WriteLine(z + "  | " + res[i]);
                    z++;
                }
            }


        }
    }
}
