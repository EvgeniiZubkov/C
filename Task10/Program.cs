// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

// int secondNumber = (number / 10) % 10;

// if (number > 99 && number < 1000)
//     Console.WriteLine($"Вторая цифра введенного числа: {secondNumber}");
// else if (number < -99 && number > -1000)
//     Console.WriteLine($"Вторая цифра введенного числа: {secondNumber * -1}");
// else
//     Console.WriteLine("Число не трехзначное");

int SecondNumber(int num)
{
int secondNumber = (num / 10) % 10;

if (num > 99 && num < 1000)
    Console.WriteLine($"Вторая цифра введенного числа: {secondNumber}");
else if (num < -99 && num > -1000)
    Console.WriteLine($"Вторая цифра введенного числа: {secondNumber * -1}");
else
    Console.WriteLine("Число не трехзначное");
    return secondNumber = (num / 10) % 10;
}

int secondNumber = SecondNumber(number);