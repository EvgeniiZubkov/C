// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это не возможно, программа должна вывести сообщение.

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

// 1 4 7
// 5 9 2
// 8 4 2

int[,] ColumnsReplaceRows(int[,] matrix)
{
    int[,] replaceMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            replaceMatrix[i, j] = matrix[j,i];
        }
    }
    return replaceMatrix;
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

int[,] matrixRndInt = CreateMatrixRndInt(3, 3, 1, 4);
if(matrixRndInt.GetLength(0) == matrixRndInt.GetLength(1))
{
PrintMatrix(matrixRndInt);
Console.WriteLine();
int[,] newMatrix = ColumnsReplaceRows(matrixRndInt);
PrintMatrix(newMatrix);
}
else Console.Write("Массивы не совпадают");