// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

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

void FindNumber(int row, int column, int[,] arr)
{
    if (row<arr.GetLength(0) && column<arr.GetLength(1))
    {
        Console.Write(arr[row,column]);
    }
    else
    {
        Console.Write("такого числа в массиве нет");
    }

}


int[,] array = GetPrintArray(3, 4, 0, 10);
Console.WriteLine("введите номер строки");
int i = int.Parse(Console.ReadLine())-1;
Console.WriteLine("введите номер колонки");
int j = int.Parse(Console.ReadLine())-1;
FindNumber(i, j, array);
