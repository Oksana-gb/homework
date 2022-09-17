// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetPrintArray(int m, int n, int max)
{
    double[,] res = new double[m, n];
    Random rand = new Random();  
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = Math.Round((rand.NextDouble() - 0.5) * 2 * max, 1);
            Console.Write(res[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return res;
}

double[,] array = GetPrintArray(3, 4, 10);