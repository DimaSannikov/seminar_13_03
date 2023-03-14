// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел для расчета: ");
int amount = int.Parse(Console.ReadLine());


int ToCountNumbersMoreThanZero(int amount)
{
    int count = 0;
    for (int i = 1; i <= amount; i++)
    {
        Console.Write($"Введите число {i}: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество чисел больше 0 => {ToCountNumbersMoreThanZero(amount)}");