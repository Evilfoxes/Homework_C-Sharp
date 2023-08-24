// Напишите программу, которая принимает на вход координаты двух 
// точек и находит растояние между ними в 2D пространсве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21



double Distance(int x1, int y1, int x2, int y2)
{
    int side1 = x1 - x2;
    int side2 = y1 - y2;
    double distance = Math.Sqrt(side1 * side1 + side2 * side2);
    return distance;
}

Console.WriteLine("Enter coordinate fierst point");
Console.Write("X Coordinate point A: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y Coordinate point A: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate second point");
Console.Write("X Coordinate point B: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y Coordinate point B: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);
