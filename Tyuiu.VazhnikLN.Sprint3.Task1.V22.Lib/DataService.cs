using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VazhnikLN.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            while (startValue <=  stopValue)
            {
                s += (Math.Pow(value, startValue) + 0.5) * Math.Cos(startValue);
                startValue++;
            }
            return Math.Round(s, 3);
        }
    }
}
