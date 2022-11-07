// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = 1;

    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
        // sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(num);

Console.WriteLine($"произведение чисел чисел от 1 до {num} = {sumNumbers}");