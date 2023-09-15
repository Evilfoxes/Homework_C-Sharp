// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersFromMToN(int namberN, int numberM)
{
    if (namberN > numberM) return 0;
    return SumNumbersFromMToN(namberN, numberM - 1) + numberM;
}

Console.Write("Enter number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numN >= numM)
{
    Console.WriteLine($"M = {numM}; N = {numN} -> {SumNumbersFromMToN(numM, numN)}");
}
else
{
    Console.WriteLine($"N = {numN}; M = {numM} -> {SumNumbersFromMToN(numN, numM)}.");
}