﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например: 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count <= number)
{
if (count % 2 == 0)
Console.WriteLine(count);
count = count + 1;
}