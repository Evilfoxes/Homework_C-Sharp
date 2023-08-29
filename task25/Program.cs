// Напишите цикл который принимает на вход 
// два числа (A и B) и возводит число A в на туральную
// степень B.

// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Enter natural number (A): ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter natural number (B): ");
int B = Convert.ToInt32(Console.ReadLine());

int deg = 1;
for (int i = 0; i < B; i++)
{
    deg = deg * A;
}
Console.WriteLine($"{A} raised to a natural degree {B} = {deg}");
