﻿// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write($"{Arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void SortRows(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            for (int n = 0; n < Arr.GetLength(1) - 1; n++)
            {
                if (Arr[i, n] > Arr[i, n + 1])
                {
                    int k = Arr[i, n + 1];
                    Arr[i, n + 1] = Arr[i, n];
                    Arr[i, n] = k;
                }
            }
        }
    }
}

int[,] array = GetArray(3, 4, 1, 10);
PrintArray(array);
Console.WriteLine();
SortRows(array);
PrintArray(array);