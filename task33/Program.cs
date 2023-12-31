﻿// Задайте массив. Напишите программу которая определяет, 
// присутсвует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool SearchNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
    }
    return false;
}

int[] newarr = CreateArrayRndInt (5, -5, 9);
PrintArray (newarr);

Console.Write("Enter search number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool searchNum = SearchNum(newarr, number);
Console.WriteLine(searchNum ? "Number present" : "Number missing");