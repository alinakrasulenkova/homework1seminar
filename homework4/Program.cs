// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int a=1;
while(a<=num)
{
   if (a%2==0)
   {
    Console.WriteLine(a); 
   }
    a++;
}