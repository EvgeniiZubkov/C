// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Какое количество чисел Вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int len)
{
    int[] array = new int[len];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива: {i}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositiveSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum+=1;
    }
    return sum;
}

int[] arr = CreateArray(size);
PrintArray(arr);
int summ = PositiveSum(arr);
Console.WriteLine($"Количество положительных элементов в массиве = {summ}");
