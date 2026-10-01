using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VazhnikLN.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double s = 0;
            for (startValue = -5; startValue <= stopValue;  startValue++)
            {
                if (startValue == 0) break;
                else s += Math.Sin(startValue) / startValue;
            }
            return Math.Round(s, 3);
        }
    }
}
