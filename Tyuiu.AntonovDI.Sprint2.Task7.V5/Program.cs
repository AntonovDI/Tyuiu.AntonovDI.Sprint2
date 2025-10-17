using Tyuiu.AntonovDI.Sprint2.Task7.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        bool res;
        Console.Title = "Спринт #2 | Выполнил: Антонов Д. И. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *"); 
        Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
        Console.WriteLine("* X,Y в заштрихованной области.                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        res = ds.CheckDotInShadedArea(x, y);
        if (res)
        {
            Console.WriteLine("Да, точка с указанными координатами находится в области");
        }
        else
        {
            Console.WriteLine("Точки с указанными координатами в области нет");
        }
    }
}