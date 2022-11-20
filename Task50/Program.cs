// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void SearchElement(int[,] matrix, int x, int y)
{
    int matrixRowsLength = matrix.GetLength(0);
    int matrixColumnsLength = matrix.GetLength(1);

    if (x > matrixRowsLength || y > matrixColumnsLength)
    Console.WriteLine("Такого элемента в массиве нет");
    else
    {
        for (int i = 0; i < matrix.GetLength(0) + 1; i++)
        {
            if (i == x)
            {
                for (int j = 0; j < matrix.GetLength(1) + 1; j++)
                {
                    if (j == y)
                    Console.Write($"Искомый элемент массива равен: {matrix[i - 1, j - 1]}");
                }
            }
        }
    }
}

int[,] matrixRndInt = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrixRndInt);

Console.WriteLine("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

SearchElement(matrixRndInt, row, column);
