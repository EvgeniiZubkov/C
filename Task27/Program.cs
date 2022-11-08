// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    int sum = 0;
    num = Math.Abs(num);

    while (num / 10 > 0)
    {
        int ostatok = num % 10;
        sum = sum + ostatok;
        num = num / 10;
    }
    sum = num + sum;

    return sum;
}

int sumNumber = SumNumber(number);

Console.WriteLine($"Сумма отдельных цифр из введенного числа равна: {sumNumber}");