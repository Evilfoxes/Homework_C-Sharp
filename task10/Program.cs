﻿// Напишите программу, которая принимает
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter third-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 10 % 10;

Console.WriteLine($"Second digits {number} - {result}");