﻿// 3. Напишите программу, которая будет выдавать 
// название дня недели по заданому номеру.
// 3 -> Wednesday
// 5 -> Friday

Console.WriteLine("Enter the number from 1 to 7");
string num = Console.ReadLine();
if (num == "1") 
{
    Console.WriteLine("Monday");
}
else if (num == "2") 
{
    Console.WriteLine("Tuesday");
}
else if (num == "3") 
{
    Console.WriteLine("Wednesday");
}
else if (num == "4") 
{
    Console.WriteLine("Thursday");
}
else if (num == "5") 
{
    Console.WriteLine("Friday");
}
else if (num == "6") 
{
    Console.WriteLine("Saturday");
}
else if (num == "7") 
{
    Console.WriteLine("Sunday");
}

else
{
    Console.WriteLine("Wrong number!!!");
}
