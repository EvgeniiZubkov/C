// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());


int DegreeOfNumber(int numberA, int numberB)
{
    int count = 1;
    int numberC = 1;
    while (count <= numberB)
    {
        numberC = numberC * numberA;
        count++;
    }
    return numberC;
}

int numC = DegreeOfNumber(numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} = {numC}");