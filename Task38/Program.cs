// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = { 7.5, 10.1, 9.3, 4.2, 1.9 };

void MinMaxArray(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max <= arr[i]) max = arr[i];
        else min = arr[i];
    }
    Console.WriteLine($"Максимальное число в массиве = {max} , минимальное число в массиве = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным числами массива = {max - min}");
}

MinMaxArray(array);