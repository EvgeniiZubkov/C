// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountNumber(int num)
{
    num = Math.Abs(num);
    int count = default;
    while (num > 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count > 0 ? count : 1;
}

int countNumber = CountNumber(number);
Console.WriteLine($"Количество цифр в числе {countNumber}");