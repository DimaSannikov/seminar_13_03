// Напишите программу, которая будет создавать копию заданного массива с
// помощью поэлементного копирования.

int[] array = {1, 2, 3, 4, 5, 6};

int[] newArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] secondNewArray(int[] array)
{
    int[] secondNewArray = new int[array.Length];
    Array.Copy(array, secondNewArray, array.Length);
    return secondNewArray;
}

Console.WriteLine("["+$"{String.Join(", ", newArray(array))}"+"]");
Console.WriteLine();
Console.WriteLine("["+$"{String.Join(", ", secondNewArray(array))}"+"]");