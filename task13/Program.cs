// Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(number);
if (NumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + NumberText[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}