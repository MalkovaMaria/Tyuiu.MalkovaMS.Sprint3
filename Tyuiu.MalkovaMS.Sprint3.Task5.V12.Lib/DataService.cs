using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MalkovaMS.Sprint3.Task5.V12.Lib
{
    public class DataService : ISprint3Task5V12
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int l = startValue1;  l <= stopValue1; l++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum = sum + Math.Cos(k) + (x / 2);

                }
            }
            return Math.Round(sum, 3);
        }
    }
}
