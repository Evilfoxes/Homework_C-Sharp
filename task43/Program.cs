// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Across(double b1, double k1, double b2, double k2)
{
    if (k1==k2 && b1==b2)
    {
        Console.WriteLine ($"The lines coincide: ");
    }
    else if (k1==k2)
    {
        Console.WriteLine ($"Lines are parallel: ");
    }
    else
    {
        double x = -(b1 - b2) / (k1 - k2);
        double y = k1 * x + b1;
        x = Math.Round(x, 3);
        y = Math.Round(y, 3);
        Console.WriteLine ($"Intersection at point: ({x}; {y})");
    
    }

}

Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Across(b1, k1, b2, k2);