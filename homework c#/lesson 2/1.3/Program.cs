// Console.WriteLine("введите цифру от 1 до 7");
// int a = int.Parse(Console.ReadLine());
// if (a==6 | a==7)
// Console.WriteLine("выходной");
// else if (a<6)
// Console.WriteLine("будний день");
// else
// Console.WriteLine($"{a} не входит в диапазон 1-7, введите другую цифру");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// d=\sqrt{{(x_b — x_a)}^2 + {(y_b — y_a)^2
// int a = int.Parse(Console.ReadLine());

// if (a>4 && a<1) Console.WriteLine("введите число заново");
// if (a==1) Console.WriteLine("x(0;+), y(0;+)");
// if (a==2) Console.WriteLine("x(-;0), y(0;+)");
// if (a==3) Console.WriteLine("x(-;0), y(-;0)");
// if (a==4) Console.WriteLine("x(0;+), y(-;0)");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("введите цифру ");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру ");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру ");
double za = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру ");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру ");
double yb = double.Parse(Console.ReadLine());
Console.WriteLine("введите цифру ");
double zb = double.Parse(Console.ReadLine());

double d=Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine(d);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 - 1 4 9 16 25

// Console.WriteLine("введите число");
// int a = int.Parse(Console.ReadLine());
// for (int i =1; i < a+1; i++) 
// {
// double b = Math.Pow(i,2);
// Console.Write($"{b}, ");
// }

// int n = 5;
// Console.WriteLine(String.Join(" ",Enumerable.Range(1, n).Select(n => n*n)));

