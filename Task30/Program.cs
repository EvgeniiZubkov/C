// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write(array[i] + " ");
// }

void MassiveZeroOne()
{
    int[] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}

MassiveZeroOne();


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