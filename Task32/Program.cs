// Напишите программу замены элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

int[] InversionArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) Console.Write($"{array[i] * -1},");
        else Console.Write($"{array[i] * -1},");
    }

    return array;
}

int[] arr = CreateArrayRndInt(4, -9, 9);
PrintArray(arr);
InversionArray(arr);