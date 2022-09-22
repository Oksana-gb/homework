//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Sorting(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int m = 0; m < arr.GetLength(1); m++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int k = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = k;
                }
            }
        }

    }
}

int[,] array = GetArray(4, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
Sorting(array);
PrintArray(array);