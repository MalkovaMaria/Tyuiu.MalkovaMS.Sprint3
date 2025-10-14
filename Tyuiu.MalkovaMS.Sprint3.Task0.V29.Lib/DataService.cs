using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MalkovaMS.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                SumSeries += (Math.Pow(value, 2 * i) + 1.0 / (i + 1)) * Math.Cos(value);
            }
            return Math.Round(SumSeries, 3);
        }
    }
}
