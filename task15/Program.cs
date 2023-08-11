// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());

if((number > 5) && (number < 8))
{
    Console.WriteLine("Day off");
}
else if((number > 0) && (number < 6))
{
    Console.WriteLine("Weekday");
}
else
{
    Console.WriteLine("Wrong number");
}