using Tyuiu.MalkovaMS.Sprint3.Task7.V17.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int StartValue = -5;
        int StopValue = 5;
        Console.Title = "Спринт #3 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");

        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Старт шага = " + StartValue);
        Console.WriteLine("Конец шага = " + StopValue);
        Console.WriteLine("***************************************************************************");
        int len = StopValue - StartValue + 1;
        double[] res = ds.GetMassFunction(StartValue, StopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+---------+-----------+");
        Console.WriteLine("|    X    |    f(x)   |");
        Console.WriteLine("+---------+-----------+");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("|{0,5:d}    |  {1, 6:f2}   |", StartValue, res[i]);
            StartValue++;
        }
        Console.WriteLine("+---------+-----------+");
        Console.ReadKey();
    }
}