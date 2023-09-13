// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}


int SumRowElements(int[,] matrix, int iRow)
{
    int sumElements = matrix[iRow,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sumElements += matrix[iRow, j];
        }
    return sumElements;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2d);
int minSumRow = 1;
int sumRowElements = SumRowElements(array2d, 0);
for (int i = 1; i < array2d.GetLength(0); i++)
{
  int temSumLine = SumRowElements(array2d, i);
  if (sumRowElements > temSumLine)
  {
    sumRowElements = temSumLine;
    minSumRow = i;
  }
}

Console.WriteLine($"The smallest sum of elements, located in line -> {minSumRow}");