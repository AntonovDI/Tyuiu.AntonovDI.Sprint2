using Tyuiu.AntonovDI.Sprint2.Task0.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 1054;
        int y = 375;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);
        Console.Title = "Спринт #2 | Выполнил: Антонов Д. И. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнени1 (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
        Console.WriteLine("* выражений, которая вернёт логическую последовательность(массив):        *");
        Console.WriteLine("* (True, True, True, True, True, False), при x = 1054, y = 375            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X - " + x);
        Console.WriteLine("Y - " + y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}