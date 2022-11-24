// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(0,1000); 
Console.WriteLine(num);

if (num>99)
{
    int result = (num%100)%10;
    Console.WriteLine(result);
}

else
{
    Console.WriteLine("третьего числа нет");
}