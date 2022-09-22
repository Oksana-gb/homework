// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int minValue, int maxValue)
{
    int[,] res = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
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

int[,] ProductMatrices(int[,] arr, int[,] arr2)
{
    int[,] res = new int[2, 2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                res[i, j] += arr[i, k] * arr2[k, j];
            }
        }
    }
    return res;
}

int[,] array = GetArray(0, 10);
PrintArray(array);
Console.WriteLine();
int[,] array2 = GetArray(0, 10);
PrintArray(array2);
Console.WriteLine();
PrintArray(ProductMatrices(array, array2));