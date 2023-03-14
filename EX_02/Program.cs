// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с такими сторонами.

Console.Write("Введите число 1: ");
int side1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int side2 = int.Parse(Console.ReadLine());

Console.Write("Введите число 3: ");
int side3 = int.Parse(Console.ReadLine());

if(side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
{
    Console.WriteLine("Треугольник с такими сторонами может существовать");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не может существовать");
}