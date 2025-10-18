using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MalkovaMS.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
        string str = "";
        foreach (char item in value)
        {
            if (Char.IsDigit(item) == true)
                    str += item;
        }
        return Convert.ToInt32(str);
        }
    }
}
