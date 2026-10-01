using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VazhnikLN.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[11];
            int i;
            int m = 0;
            for (i = startValue; i <= stopValue; i++)
            {

                res[m] = Math.Round(Math.Cos(i) + 2 * i - (Math.Sin(i) * 3 * i), 2);
                m++;
            }
            return res;
        }
    }
}
