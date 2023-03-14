// Напишите программу, которая будет преобразовывать десятичное
// число в двоичное.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

string RetBinaryNum(int number)
{
    string result = string.Empty;
    while(number > 0)
    {
        result = Convert.ToString(number % 2) + result;
        number = number / 2;
        // Console.WriteLine(result);
    }
    return result;
}
Console.WriteLine(RetBinaryNum(num));