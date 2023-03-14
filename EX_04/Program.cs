// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


int[] returnFibNumbers(int number)
{
    int[] arrayFib = new int[2] {0, 1};
    for (int i = 2; i < number; i++)
    {
        if(number > 2)
        {
            Array.Resize(ref arrayFib, arrayFib.Length + 1);
            arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
        }
    }
    return arrayFib;
}



void returnFibNumbs(int number)
{
    int num = 0;
    int nextNum = 1;
    Console.Write($"{num}, {nextNum}");
    for (int i = 3; i <= number; i++)
    {
        int newNextNum = num + nextNum;
        num = nextNum;
        nextNum = newNextNum;
        Console.Write($", {newNextNum}");
    }
}


Console.WriteLine("["+$"{String.Join(", ", returnFibNumbers(number))}"+"]");
returnFibNumbs(number);
