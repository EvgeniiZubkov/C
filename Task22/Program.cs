// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int x)
{
    int count = 1;
    int result = default;
    while (count <= x)
    {
        result = count * count;
        System.Console.WriteLine($"Для числа {count} квадрат = {result}");
        count++;
    }
}

Square(number);