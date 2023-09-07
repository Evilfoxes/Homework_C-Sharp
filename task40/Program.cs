// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("Enter the lenght of the first side: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the lenght of the second side: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the lenght of the third side: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(num1, num2, num3);
Console.WriteLine(result? "Triangle exists" : "Triangle does not exist");

bool IsExistTriangle(int side1, int side2, int side3)
{
    // if(side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 +side2) return true;
    // else return false;
    return (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 +side2)
}