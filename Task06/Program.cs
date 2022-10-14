// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). Например: 4 -> да -3 -> нет 7 -> нет

Console.WriteLine("Введите четное целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 2)
    Console.WriteLine("Число четное");
else Console.WriteLine("Число не четное");