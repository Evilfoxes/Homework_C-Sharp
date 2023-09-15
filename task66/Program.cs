// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int SumNumbersFromMToN(int numberN, int numberM)
{
    if (numberN > numberM) return 0;
    return SumNumbersFromMToN(numberN, numberM - 1) + numberM;
}

if (numN >= numM)
{
    Console.WriteLine($"M = {numM}; N = {numN} -> {SumNumbersFromMToN(numM, numN)}");
}
else
{
    Console.WriteLine($"N = {numN}; M = {numM} -> {SumNumbersFromMToN(numN, numM)}.");
}