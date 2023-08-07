// 1. Напишите программу, которая на вход принимает два 
// числа и проверяет, явлется ли превое число квадратом
// Второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Enter the first number");
int number1 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 =  Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2 )
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}