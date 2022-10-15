// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например: 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int print = 0;
while (count < number)
{
    if (print == count % 2)
        Console.WriteLine(print);
    else
    count = count + 1;
}