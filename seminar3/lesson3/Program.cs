// Формула вычисления расстояния между двумя точками А(xa,ya) и B(xb,yb)
// AB=√(xb-xa)²(yb-ya)²

// Подметод нахождения корня из числа
// double num = Math.Sqrt(49);
// Console.WriteLine(num); 

// Подметод возведения числа в квадрат
// double num = Math.Pow(2);
// Console.WriteLine(num); 

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("введите x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите y2");
int y2 = Convert.ToInt32(Console.ReadLine());

//                        степень числа указывается после запятой
double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(x2-x1,2));

Console.WriteLine(result);