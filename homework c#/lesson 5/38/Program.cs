// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = GetPrintArray(5);
difference();

double[] GetPrintArray(int max)
{
    double[] arr = new double[10];
    Random rand = new Random();              // рандом сюда вынесли чтобы не нагружать систему, но я пока не поняла как это работает
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rand.NextDouble() - 0.5) * 2 * max, 3); // rand.NextDouble() генерирует числа в диапазоне [0, 1]. Если вычесть 0.5, то получим диапазон [-0.5, 0.5]
                                                                     //Чтобы сделать диапазон [-1, 1] нужно умножить на 2. А умножая на 100, мы получаем диапазон [-100, 100]
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
    result = Math.Round(max - min, 3);
    Console.WriteLine();
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max-min = {result}");
    return result;
}
