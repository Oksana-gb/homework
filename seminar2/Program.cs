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

// Console.WriteLine("введите число 1");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("введите число 2");
// int b = int.Parse(Console.ReadLine());
// if (a * a == b)
//     Console.WriteLine("число 1 в квадрате равно числу 2");
// else if (b * b == a )
//      Console.WriteLine("число 2 в квадрате равно числу 1");
// else Console.WriteLine("числа не являются квадратом друг дурга");

// Console.WriteLine("введите число");  // пример использования функции(метода)
// int num = int.Parse(Console.ReadLine());

// int GetSumNumber(int numA)
// {
//     int sum = 0;
//     while (numA>0)
//     {
//         sum=sum+numA;
//         numA--;
//     }
// return sum;
// }
// Console.WriteLine(GetSumNumber(num));

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Console.WriteLine("введите число");
// int num = int.Parse(Console.ReadLine());

// int Count(int numA)
// {
//     int sum = 0;
//     while (numA > 0)
//     {
//         numA /= 10;
//         sum++;
//     }
//     return sum;
// }
// Console.WriteLine(Count(num));

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Console.WriteLine("введите число");
// int num = int.Parse(Console.ReadLine());

// int Count(int numA)
// {
//     int sum = 1;
//     if (numA > 0)
//     {
//         while (numA > 0)
//         {
//             sum *= numA;
//             numA--;
//         }
//         return sum;
//     }
//     else
//     {
//     return 0;
//     }
// }
// Console.WriteLine(Count(num));

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] array = new int[8];

int[] method(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 2);
    }
    return a;
}

void print(int[] b)
{
    for (int i = 0; i < b.Length; i++)
    {
       Console.Write(b[i]);
    }
}

method(array);
print(array);