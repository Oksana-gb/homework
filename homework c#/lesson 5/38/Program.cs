// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = GetPrintArray();
difference();

double[] GetPrintArray ()
{
    double[] arr = new double[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().NextDouble();
        arr[i]= Math.Round(arr[i], 3);
        Console.Write(arr[i]+" ");
    }
    return arr;
}  
double difference ()
{
double result = 0;
double min = array[0];
double max = 0;
foreach (double value in array)
{
    min = value<min? value: min;
    max = value>max? value: max;
}
result = max - min;
Console.WriteLine();
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"max-min = {result}");
return result;
}
