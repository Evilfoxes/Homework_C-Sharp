// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно
// одновременно 7 и 23.

// 14 -> Нет 
// 46 -> Нет
// 161 -> Да 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultiplicityTwoDigits(number, 7 ,23);
Console.WriteLine(result ? "Да" : "Нет");

bool MultiplicityTwoDigits(int number1, int number2, int number3)
{
    return number1 % number2 == 0 && number1 % number3 == 0;
}