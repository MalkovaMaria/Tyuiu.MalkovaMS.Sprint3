using System.Net.Http.Headers;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MalkovaMS.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            while (startValue <= stopValue)
            {
                res *= (Math.Pow(value, startValue) - (1.0/4)) * Math.Cos(5);
                startValue++;
            }
            return Math.Round(res, 3);
        }   
    }
}
