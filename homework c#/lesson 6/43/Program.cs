// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CrossPoint(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) Console.Write("прямые не пересекаются!");
else
Console.Write($"точка пересечения: ({x}; {y})");
}

Console.WriteLine("введите число b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число k2: ");
int k2 = int.Parse(Console.ReadLine());
CrossPoint(k1,b1,k2,b2);