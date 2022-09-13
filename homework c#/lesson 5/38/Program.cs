// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = GetPrintArray(5);
difference();

double[] GetPrintArray(int max)
{
    double[] arr = new double[10];
    Random rand = new Random();              // рандом сюда вынесли чтобы не нагружать систему, но я пока не поняла как это работает
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= Math.Round(rand.NextDouble() * max, 3);           //для целых чисел будет arr[i]= rand.Next(max);
        // arr[i] = (rand.NextDouble() 0,5) * 2 * max;    // эту с строку мне дал тот кто проверял, но че-то не работает , надо разобраться
        // arr[i] = Math.Round(arr[i], 3);        // оказалось ее можно объединить в одну строку с присвоением
        Console.Write(arr[i] + " ");
    }
    return arr;
}
double difference()
{
    double result = 0;
    double min = array[0];
    double max = 0;
    foreach (double value in array)
    {
        min = value < min ? value : min;
        max = value > max ? value : max;
    }
    result = max - min;
    Console.WriteLine();
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max-min = {result}");
    return result;
}
