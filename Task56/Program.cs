// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }

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

int[] NewArray(int[,] matrix)
{
    int[] newArray = new int[matrix.GetLength(0)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[count] = newArray[count] + matrix[i, j];
        }
        count++;
    }
    return newArray;
}

int MinRow(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (min <= array[i])
        {
            min = i;
            temp = min;
        }
        else
        array[i] = temp;
    }
    return min;
}

int[,] matrixRndInt = CreateMatrixRndInt(4, 4, 0, 3);
PrintMatrix(matrixRndInt);
Console.WriteLine();
int[] newArray = NewArray(matrixRndInt);
PrintArray(newArray);
int minRow = MinRow(newArray);
Console.WriteLine($"{minRow}");