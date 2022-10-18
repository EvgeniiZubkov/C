// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("Нет");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Нет");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Нет");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Нет");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Нет");
// }
// else if (number == 6)
// {
//     Console.WriteLine("Да");
// }
// else if (number == 7)
// {
//     Console.WriteLine("Да");
// }
// else
//     Console.WriteLine("Нет такого дня");

int DayOff(int num)
{
    int dayOff = number;
    if (num == 1)
    {
        Console.WriteLine("Нет");
    }
    else if (num == 2)
    {
        Console.WriteLine("Нет");
    }
    else if (num == 3)
    {
        Console.WriteLine("Нет");
    }
    else if (num == 4)
    {
        Console.WriteLine("Нет");
    }
    else if (num == 5)
    {
        Console.WriteLine("Нет");
    }
    else if (num == 6)
    {
        Console.WriteLine("Да");
    }
    else if (num == 7)
    {
        Console.WriteLine("Да");
    }
    else
        Console.WriteLine("Нет такого дня");
    return DayOff(num);
}

int dayOff = DayOff(number);