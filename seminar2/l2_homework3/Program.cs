// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, 
//  является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1>=1 && num1<=5)
{
    Console.WriteLine("не является выходным");
}
else if (num1==6||num1==7)
{
    Console.WriteLine("выходной"); 
}
else
{
   Console.WriteLine("такого дня недели не существует"); 
}