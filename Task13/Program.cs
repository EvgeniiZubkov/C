// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstStep = default;

int ThirdNumber(int num)
{
    if (num < 0)
    {
        num = num * -1;
    }
    while (num > 999)
    {
        firstStep = num / 10;
        num = firstStep;
    }
    if (num > 99 && num < 999)
        Console.WriteLine(num % 10);
    if (num < 100)
        Console.WriteLine("Третьей цифры нет!");

    return firstStep = number;
}
int thirdNumber = ThirdNumber(number);