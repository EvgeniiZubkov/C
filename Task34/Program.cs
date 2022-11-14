// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositiveNum(int[] newArray)
{
    int positive = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] % 2 == 0) positive = positive + 1;
    }
    return positive;
}

int[] arr = (CreateArrayRndInt(5, 100, 999));
PrintArray(arr);
Console.WriteLine($"Количество четных элементов в массиве = {PositiveNum(arr)}");