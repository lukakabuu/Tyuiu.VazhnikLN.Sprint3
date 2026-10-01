using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VazhnikLN.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V3
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int i, j;
            int s = 0;
            for (i = startValue; i <= stopValue; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if ((i % j == 0) && (j > 8)) s += j;
                }

            }
            return s; 
        }
    }
}
