//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и 
//  минимальным элементами массива.

//  [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int size = 0;
int array = 0;

double[] CreatearrayayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintarrayayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]:F1}");
    }
    Console.WriteLine("]");
}

void FindMaxMin(int[] array)
{
    int min = array[0];
    int max = array[0];
    int index = 1;
    while(index < size)
    {
        if (array[index] < min) min = array[index];
        else if (array[index] > max) max = array[index];
        index++;
    }
    int diff = max - min;
    Console.WriteLine(min + " " + max);
}

PrintarrayayDouble(array);
Console.WriteLine();
FindMaxMin(array);
Console.WriteLine(max-min);