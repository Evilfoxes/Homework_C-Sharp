﻿// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Enter five-digit number: ");
int number = int.Parse(Console.ReadLine());
int RevNumber = 0;
int modNumber = number;

if (number > 10000 && number <99999)
{
    while (modNumber > 0)
    {
        RevNumber = (RevNumber * 10) + (modNumber % 10);
        modNumber = modNumber / 10;
    }

    if (RevNumber == number)
    {
        Console.WriteLine ($"YES {number} it's palindrome");
    }
    else
    {
        Console.WriteLine ($"NO {number} this number is not a pollindrome");
    }
}
else
{
    Console.WriteLine($"{number} wrong number!!!");
}