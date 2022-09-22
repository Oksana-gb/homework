// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetPrintArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return arr;
}

void ArithmeticMeanColumn(int [,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum+= arr[i, j];
        }
        Console.Write(Math.Round(sum/arr.GetLength(1),1) + "\t");
    }
}

int[,] array = GetPrintArray(3,3,0,10);
Console.WriteLine();
ArithmeticMeanColumn(array);
