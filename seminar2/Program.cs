// int num = new Random().Next(100, 1000);
// int a = num / 100;
// int b = num % 10;
// Console.WriteLine($"{num} - {a}{b}");

// Console.WriteLine("введите число");
// int a = int.Parse(Console.ReadLine());
// if (a % 7 == 0 &  a % 23 == 0)
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine("некратно");

Console.WriteLine("введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2");
int b = int.Parse(Console.ReadLine());
if (a * a == b)
    Console.WriteLine("число 1 в квадрате равно числу 2");
else if (b * b == a )
     Console.WriteLine("число 2 в квадрате равно числу 1");
else Console.WriteLine("числа не являются квадратом друг дурга");