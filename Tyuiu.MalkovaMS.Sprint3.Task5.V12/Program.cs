using Tyuiu.MalkovaMS.Sprint3.Task5.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 5;
        int start1 = 1;
        int stop1 = 3;
        int start2 = 1;
        int stop2 = 10;
        Console.Title = "Спринт #3 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");

        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычслить сумму сумм ряда при х = 5.                                     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Старт шага 1 = " + start1);
        Console.WriteLine("Конец шага 1 = " + stop1);
        Console.WriteLine("Старт шага 2 = " + start2);
        Console.WriteLine("Конец шага 2 = " + stop2);
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Произведение ряда = " + ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
        Console.ReadKey();
    }
}