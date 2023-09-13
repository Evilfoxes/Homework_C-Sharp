// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20
// 15 18

int[,] CreateRndMatrix(int m, int n) 
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(2, 6);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array) // Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}");
            else Console.Write($"{array[i, j],3}");
        }
        Console.WriteLine();
    }
}

void ProdOfTwoMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i, k] * secondMatrix[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
}

Console.WriteLine("First matrix:");
int [,] firstMatrix = CreateRndMatrix(2, 2);
PrintMatrix(firstMatrix);

Console.WriteLine();
Console.WriteLine("Second matrix:");
int [,] secondMatrix = CreateRndMatrix(2, 2);
PrintMatrix(secondMatrix);

int[,] resultMatrix = new int[2, 2];
ProdOfTwoMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine();
Console.WriteLine($"Product of two matrix:");
PrintMatrix(resultMatrix);