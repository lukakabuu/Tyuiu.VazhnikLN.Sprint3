using System;
using Tyuiu.VazhnikLN.Sprint3.Task3.V12.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task3.V12

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string s = "bkkrk ckkkcs ksr";
            char c = 'k';
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetMaxCharCount(s, c);
            Console.WriteLine("Максимальное кол-во символов k стоящих рядом с собой = " + res);


        }
    }
}