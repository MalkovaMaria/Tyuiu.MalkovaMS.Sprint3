using Tyuiu.MalkovaMS.Sprint3.Task1.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int value = 2;
        int StartValue = 1;
        int StopValue = 6;

        Console.Title = "Спринт #3 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");

        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, используя цикл for, которая вычисляет произведение  *");
        Console.WriteLine("* ряда по формуле, при а = 2                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Переменная а = " + value);
        Console.WriteLine("Старт шага = " + StartValue);
        Console.WriteLine("Конец шага = " + StopValue);
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, StartValue, StopValue));
        Console.ReadKey();
    }
}