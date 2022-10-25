// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrom (int num)
{
int num1 = default;
int num2 = default;
int num3 = default;
int num4 = default;

if (num < 0)
{
    num = num * -1;
}
if (num > 9999 && num < 100000)
{
    num1 = num / 10000;
    num2 = (((num / 10) / 10) / 10) % 10;
    num3 = num % 10;
    num4 = (num / 10) % 10;
    if (num1 == num3 && num2 == num4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Некорректные входные данные");
    }
}
else
{
    Console.WriteLine("Некорректные входные данные");
}
}

Palindrom(number);