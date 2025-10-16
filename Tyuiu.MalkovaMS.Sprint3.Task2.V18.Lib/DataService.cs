using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MalkovaMS.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1.0;
            double i = startValue;
            do
            {
                res *= (Math.Cos(value) + Math.Pow((i / 8), 3));
                i++;
            } while (i <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
