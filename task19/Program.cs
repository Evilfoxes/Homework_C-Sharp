// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Enter a five-digit number: ");
string number = Console.ReadLine();
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write($"{number} - YES, it is palindrome");
    }
    else
    {
        Console.Write($"{number} - NO, this number is not a palindrome");
    }
}