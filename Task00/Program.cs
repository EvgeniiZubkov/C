// Напишите программу, которая:
// 1. на вход принимает число и
// 2. на выход выдает его квадрат

// например 4 -> 16

Console.WriteLine("введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
// srtring str = Console.ReadLine();
// int number = Convert.ToInt32(str);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} ={square}");