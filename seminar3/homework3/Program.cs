﻿// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число n");
int n = Convert.ToInt32(Console.ReadLine());

int count =1;
while (count<=n)
{
    Console.WriteLine(count*count*count);
    count++;
}