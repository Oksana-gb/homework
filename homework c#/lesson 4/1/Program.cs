// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++)
{
    result *= a;
}
Console.Write(result);