// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = 1;

    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
        // sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(num);

Console.WriteLine($"произведение чисел чисел от 1 до {num} = {sumNumbers}");


// Console.WriteLine("Введите количество элементов массива : ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] NameArray(int size)
// {
//     int[] array = new int[size]; // 
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {   
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+",");
//     }
// }

// int[] nameArray = NameArray(num);
// PrintArray(nameArray);