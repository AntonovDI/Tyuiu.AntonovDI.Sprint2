using Tyuiu.AntonovDI.Sprint2.Task4.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        Console.Title = "Спринт #2 | Выполнил: Антонов Д. И. | ИСТНб-25-1";
         
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
        Console.WriteLine("* использованием тернарного оператора.                                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной X - ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y - ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.Calculate(x, y);
        Console.WriteLine("Результат выполнения программы -" + res);
        Console.ReadKey();

    }
} 