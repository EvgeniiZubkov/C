// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] mtrx1, int[,] mtrx2)
{
    int[,] newMatrix = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int multiply = 0;
            for (int k = 0; k < mtrx1.GetLength(1); k++)
            {
                multiply += mtrx1[i, k] * mtrx2[k, j];
            }
            newMatrix[i, j] = multiply;
        }
    }
    return newMatrix;
}

int[,] matrix1 = CreateMatrixRndInt(2, 3, 1, 2);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(3, 2, 2, 3);
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] multiplyMatrix = MultiplyMatrix(matrix1, matrix2);
    PrintMatrix(multiplyMatrix);
}
else Console.WriteLine("Количество столбцов не соответствует количеству строк");