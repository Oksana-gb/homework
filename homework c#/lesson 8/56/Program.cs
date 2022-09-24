// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t ");  //
        }
        Console.WriteLine();
    }
}

int FindMinSum(int[,] arr)
{
    int sum = 0;
    int row = 1;
    int minSum =Int32.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine(sum);
        row = sum < minSum ? i + 1 : row;
        minSum = sum < minSum? sum: minSum;
        sum=0;
    }
    Console.WriteLine($"в {row} строке наименьшая сумма элементов");
    return row;
}

int[,] array = GetArray(7, 6, 0, 10);
PrintArray(array);
Console.WriteLine();
FindMinSum(array);