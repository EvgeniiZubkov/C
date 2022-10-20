// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
void Cube(int num)
{
    int count = 1;
    double result = default;
    while (count <= num)
    {
        result = Math.Pow(count, 3);
        Console.WriteLine($"Кубическое значение числа {count}: {result}");
        count++;
    }
}
Cube(number);
}
else
Console.WriteLine("Не верное значение");