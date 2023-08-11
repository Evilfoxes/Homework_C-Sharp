// Напишите программу, которая принимает на вход 
// два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> Да
// -4, 16 -> Да
// 25, 5 -> Да
// 8, 9 -> Нет

Console.WriteLine("Введите 1-ое число: ");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int number2 =Convert.ToInt32(Console.ReadLine());

bool result = MultiplicityTwoDigits(number1, number2);
Console.WriteLine(result ? "Да" : "Нет");

bool MultiplicityTwoDigits(int num1, int num2)
{
    return num1 / num2 == num2 || num2 / num1 == num1;
}