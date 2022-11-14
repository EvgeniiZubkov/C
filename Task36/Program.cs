﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumPositive(int[] newArray)
{
    int sum = 0;
    for (int i = 1; i < newArray.Length; i+=2) sum = sum + newArray[i];
    return sum;
}

int[] arr = (CreateArrayRndInt(5, 1, 9));
PrintArray(arr);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {SumPositive(arr)}");