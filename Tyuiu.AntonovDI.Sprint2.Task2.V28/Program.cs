using Tyuiu.AntonovDI.Sprint2.Task2.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Антонов Д. И. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *"); 
        Console.WriteLine("* b вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
        Console.WriteLine("* области.                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y: ");
        int y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);
        if (res == true)
            Console.WriteLine("Точка находится в заштрихованой области");
        else
            Console.WriteLine("Точка не находится в заштрихованой области");

        Console.ReadKey();
    }
}