// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");
string str = Console.ReadLine();

int num = Convert.ToInt32(str); 

if (num>99)
{
        Console.WriteLine(str[2]+ " третья цифра числа");
}

else
{
    Console.WriteLine("третьего числа нет");
}