// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine());

void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

    if(y1 == y2 & k1 != k2)
    {
        Console.WriteLine($"Линии пересекаются в точке => ({x}; {y1})");
    }
    else
    {
        Console.WriteLine($"Линии параллельны и не пересекаются");
    }
}


FindIntersectionPoint(b1, k1, b2, k2);
