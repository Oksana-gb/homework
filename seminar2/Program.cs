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

// int[] array = new int[8];

// int[] method(int[] a)
// {
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(0, 2);
//     }
//     return a;
// }

// void print(int[] b)
// {
//     for (int i = 0; i < b.Length; i++)
//     {
//        Console.Write(b[i]);
//     }
// }

// method(array);
// print(array);


//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void PrintArray(int[] array)
// {
//     Console.WriteLine("Вывод массива: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine("");
// }


// int[] array = GetArray(12, -9, 9);
// PrintArray(array);

// int positiveSum = 0;
// int negativeSum = 0;

// foreach (int value in array)
// {
// positiveSum += value > 0 ? value : 0;
// negativeSum += value < 0 ? value : 0;
// }

// Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

// ---------------------------------

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] array = GetArray(12,-10,10);

// PrintArray(array);
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]*=-1;
// }

// PrintArray(array);

//-------------------------------------------

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. (не мое решение)

// int[] array = GetArray(12, -10, 10);
// PrintArray(array);

// string search(int[] array_num, int num)
// {
// for (int i = 0; i < array_num.Length; i++)
// {
// if (array_num[i] == num)
// {
// return "Число есть";
// }
// }
// return"Числа нет";
// }

// Console.WriteLine(search(array, 5));

// ---------------------------------------------------

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int Sum(int[] arr)
// {
//     int col = 0;
//     foreach (int value in arr)
//     {
//         if (value > 10 && value < 100)
//         {
//             col+=1;
//         }
//     }
//     return col;
// }

// int[] array = GetArray(123, -200, 200);
// PrintArray(array);
// Console.WriteLine(Sum(array));

// --------------------

//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];

// for (int i = 0; i < size; i++)
// {
// res[i] = new Random().Next(minValue, maxValue + 1);
// }

// return res;
// }

// void ReversArray(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int k = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = k;
// }
// }

// int[] array = GetArray(9, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// ReversArray(array);
// Console.WriteLine(String.Join(" ", array));

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.WriteLine("введите число");
// int a = int.Parse(Console.ReadLine());
// string result="";
// while (a>0)
// {
//     result = a%2 + result;
//     a/=2;
// }
// Console.Write(result);


// int number = int.Parse(Console.ReadLine());

// string res1 = Convert.ToString(number, 2); //varint 1
// // string res2 = DecToNum(number, 2);      //varint 2

// Console.WriteLine($"{number}->{res1}");

// // Универсальный математический для перевода из 10 в любую
// string DecToNum(int decNumber, int otherSystem)
// {
// string res = "";
// string nums = "0123456789ABCDEF";
// while (decNumber > 0)
// {
// int ost = decNumber / otherSystem;
// res = nums[decNumber - otherSystem * ost] + res;
// decNumber /= otherSystem;
// }
// return res;
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// if (a+b>c & a+c>b & c+b>a)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

string[] st = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
bool IsTriangle(int a, int b, int c) { return (((a + b) > c) && ((a + c) > b) && ((b + c) > a)); }
Console.WriteLine(IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])));