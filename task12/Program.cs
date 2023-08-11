// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второмую Если первое число не кратно второму, 
// то программа выводит остаток от деления.

//     34, 5 -> не кратно, остаток 4
//     16, 4 -> кратно

Console.WriteLine("Введите превое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = number1 % number2;

if (remainder == 0)
{
    Console.WriteLine("Число: " + number1 + " кратное числу: " + number2 );
}
else 
{
    Console.WriteLine("Число: " + number1 + " не кратное числу: " + number2 + " остаток от деления: " + remainder);
}