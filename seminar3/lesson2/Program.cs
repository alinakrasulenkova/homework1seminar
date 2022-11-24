// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек 
// в этой четверти (x и y).

Console.WriteLine("введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

if (num==1)
{
    Console.WriteLine("x - любое число, которое больше 0, а y - любое больше 0"); 
}
else if (num==2)
{
    Console.WriteLine("x - любое число, которое меньше 0, а y - любое число больше 0"); 
}
else if (num==3)
{
    Console.WriteLine("x - любое число, которое меньше 0, а y - любое число меньше 0"); 
}
else if (num==4)
{
    Console.WriteLine("x - любое число, которое больше 0, а y - любое число меньше 0"); 
}
else
{
    Console.WriteLine("ошибка"); 
}