// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1");
double numK1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1");
double numB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
double numK2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2");
double numB2 = Convert.ToInt32(Console.ReadLine());

double[] FindDot(double k1, double b1, double k2, double b2)
{
    double[] array = new double[2];

    array[0] = k2 * (b2 - b1) / (k1 - k2) + b2;
    array[1] = k1 * (b2 - b1) / (k1 - k2) + b1;
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] dot = FindDot(numK1, numB1, numK2, numB2);
PrintArray(dot);