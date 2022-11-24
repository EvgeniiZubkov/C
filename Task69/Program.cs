// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowAToB(int numA, int numB)
{
    if (numB == 0) return 1;
    return PowAToB(numA, numB - 1) * numA;
}

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int powAToB = PowAToB(numberA, numberB);
Console.WriteLine(powAToB);
