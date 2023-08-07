// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i < number)
{
    if (i % 2 == 0)
    {
    Console.Write($"{i}, ");
    }
i = i + 2;
}
if(i == number)
{
    Console.WriteLine($"{i}. ");
}