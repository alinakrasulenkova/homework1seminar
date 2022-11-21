// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.


Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max=num1;

if (num2>num1)
{
    if (num2>num3)
    {
       max=num2; 
    }
    
}
if (num3>num1)

{
    if (num3>num2)
    {
      max=num3;  
    }
    
}
Console.WriteLine("максимальное число " +max);