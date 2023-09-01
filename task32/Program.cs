﻿// Напишите программу замена елементов мвссива:
// положительные элементы массива замените на 
// соответсвующие отризательные и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void InversionArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] newarr = CreateArrayRndInt (5, -5, 9);
PrintArray (newarr);
Console.Write(" -> ");
InversionArray(newarr);
PrintArray(newarr);