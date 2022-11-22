// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

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

int[] Index(int[,] matrix)
{
    int horizontal = 0;
    int vertical = 0;
    int min = matrix[horizontal, vertical];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                horizontal = i;
                vertical = j;
            }
        }
    }
    return new int[] { horizontal, vertical };
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

int[,] CreateMatrixMax(int[,] matrix, int m, int n)
{
    int[,] matrixMax = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int countHor = 0;
    int countVer = 0;
    for (int i = 0; i < matrixMax.GetLength(0); i++)
    {
        if (countHor == m) countHor++;
        for (int j = 0; j < matrixMax.GetLength(1); j++)
        {
            if (countVer == n) countVer++;
            {
                matrixMax[i, j] = matrix[countHor, countVer];
            }
            countVer++;
        }
        countVer = 0;
        countHor++;
    }
    return matrixMax;
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

int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(newMatrixRndInt);
Console.WriteLine();
int[] newMinElemArray = Index(newMatrixRndInt);
PrintArray(newMinElemArray);
Console.WriteLine();
int[,] newMatrixMax = CreateMatrixMax(newMatrixRndInt, newMinElemArray[0], newMinElemArray[1]);
PrintMatrix(newMatrixMax);