Console.WriteLine("введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2)
{Console.WriteLine("Верно!");
}
else
{Console.WriteLine("Не верно!");
}