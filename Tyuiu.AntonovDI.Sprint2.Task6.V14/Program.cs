using Tyuiu.AntonovDI.Sprint2.Task6.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Антонов Д. И. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая получает от пользователя значения для k и d *");
        Console.WriteLine("* - номер дня по счёту и с какого дня недели начинается год (1 -          *");
        Console.WriteLine("* понедельник, 7 - воскресенье), после чего говорит какой день недели это *");
        Console.WriteLine("* будет. Причём надо использовать краткую форму записи switch.            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int k; int d;
        Console.WriteLine("Введите значение k:");
        k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение d:");
        d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.FindDayName(k, d));
        Console.ReadKey();
    }
}