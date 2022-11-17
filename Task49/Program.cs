// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++) // 2
    {
       for (int i = 0; i < matrix.GetLength(0); i++) // 
       {
             matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
       }
        
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,4} ", array[i, j]);

        Console.WriteLine("]");
    }
}

int[,] ReplaceEvenElem(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) 
            {
                matrix[i,j] *=  matrix[i,j];
            }        
        } 
    }
    return matrix;
}

int[,] newMatrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(newMatrix);
Console.WriteLine();
int[,]replaceEvenElemMatrix = ReplaceEvenElem(newMatrix);
PrintMatrix(replaceEvenElemMatrix);
