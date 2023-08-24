// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой находиться эта точка.

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Enter point coordinates ");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
                ? $"The specified coordinates corresponde to a quarter -> {quarter}" 
                : "Incorrect coordinates enterd";
Console.WriteLine(result);
