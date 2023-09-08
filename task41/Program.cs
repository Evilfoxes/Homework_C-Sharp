// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    Console.Write(message); 
    string value = Console.ReadLine(); 
    int result = Convert.ToInt32(value); 
    return result;
}

int[] EnterNum(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Promt($"Enter number {i+1}: ");
    }
    return array; 
}

int EboveZero(int[] arr)
{
    int eboveZero = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) 
        eboveZero++;
    }
    return eboveZero;
}

int countnumber = Promt("How many numbers will you enter: ");
Console.WriteLine();
int[] resultArray = EnterNum(countnumber);
Console.WriteLine();
int result = EboveZero(resultArray);
Console.Write($"Quantity number > 0 -> {result}");
