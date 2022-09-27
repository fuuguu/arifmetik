//Голубихин Данила 22-ИСП-2/2 Вариант 20
using System;

try
{
    Console.WriteLine("Введите x: ");
    string x = Console.ReadLine();
    double x1 = double.Parse(x);
    Console.WriteLine("Введите y: ");
    string y = Console.ReadLine();
    double y1 = double.Parse(y);
    double a = 1 + (Math.Sin(Math.Sqrt(x1 + 1)));
    double b = Math.Cos(12 * y1 - 4);
    double c = a / b;
    int res = (int)Math.Round(c);
    Console.WriteLine("Результат: ");
    Console.WriteLine(res);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

