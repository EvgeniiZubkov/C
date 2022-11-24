// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    if(num == 0) return num;
    return num % 10 + SumNumber(num / 10);
}

int sumNumber = SumNumber(number);
Console.WriteLine(sumNumber);