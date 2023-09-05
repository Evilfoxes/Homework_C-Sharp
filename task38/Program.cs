//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и 
//  минимальным элементами массива.

//  3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

double FindMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double diff = max - min;
    return diff;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]:F1}, ");
        else Console.Write($"{array[i]:F1}");
    }
    Console.WriteLine("]");
}

double[] arr = CreateArrayRndDouble(5, 1 ,100);
PrintArrayDouble(arr);
double findMaxMin = FindMaxMin(arr);
Console.WriteLine($"Difference between max and min element: = {findMaxMin:F1} ");