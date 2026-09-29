using System.Net.WebSockets;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VazhnikLN.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double s = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                s *= Math.Pow((2 / (Math.Cos(value) + 0.5)), i);
            }
            return Math.Round(s, 3);
        }
    }
}
