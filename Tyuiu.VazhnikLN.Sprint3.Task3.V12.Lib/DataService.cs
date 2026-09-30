using System.ComponentModel.Design;
using System.Net.WebSockets;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VazhnikLN.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            
            int maxx = 0;
            int cur = 0;
            foreach (char c in value)
            {
                if (item == c)
                {
                    cur++;
                    if (cur > maxx)
                    {
                        maxx = cur;
                    }
                }
                else cur = 0;
            }
            return maxx;
        }
    }
}
